using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApplication_MVC_cursach.Models;

using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System;
using Microsoft.AspNetCore.Http;

namespace WebApplication_MVC_cursach.Controllers

{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        
        public ActionResult ShowResults(string action, IFormCollection form)
        {
            if (action == "back")
            {
                //Program.dbresults = ReadFile();
                return View(Program.dbresults.ToList());
            }
            else if(action == "save")
            {
                //List<Result> results = ReadFile();
                var results = new List<Result>();
                for (int i = 0; i < Program.dbresults.Count; i++)
                {
                    if (form[i.ToString()] != "false")
                    {
                        results.Add(Program.dbresults[i]);
                    }
                }
                if(results.Count != 0)
                {
                    Save(results);
                }
                return View(results.ToList());
            }
            else 
            {
                Program.dbresults = new List<Result>();
                string searchQuery = form["search"];
                Program.QueryString = searchQuery;
                //your google search api cx
                string cx = "???";
                //your google search api apiKey
                string apiKey = "???";

                var request = WebRequest.Create("https://www.googleapis.com/customsearch/v1?key=" + apiKey + "&cx=" + cx + "&q=" + searchQuery);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseString = reader.ReadToEnd();
                dynamic jsonData = JsonConvert.DeserializeObject(responseString);
                
                string[] separatingStrings = { ": ", "," };
                string temp_t = "";
                if (action == "video")
                {
                    temp_t = "video";
                }
                else if (action == "image")
                {
                    temp_t = "image";
                }
                else
                {
                    temp_t = "audio";
                }
                int count = 0;
                if (jsonData.items == null)
                {
                    return View(Program.dbresults.ToList());
                }
                foreach (var item in jsonData.items)
                {
                    Program.dbresults.Add(new Result
                    {
                        id = count,
                        ModelType = temp_t,
                        selected = false,
                        Title = item.title,
                        Link = item.link,
                        Snippet = item.snippet,
                        //		Img	"https://i.ytimg.com/vi/7wtfhZwyrcc/maxresdefault.jpg\"\r\n}"	string
                        Img = item.pagemap.cse_image[0].ToString().Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[1].Trim(new char[] { '"', '"' })
                        //Img = item.pagemap.imageobject[0].ToString().Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[3].Trim(new char[] { '"', '"' }),
                    });
                    count++;
                }
                WorkWithJpgStr();
            }
            return View(Program.dbresults.ToList());
        }
        void WorkWithJpgStr()
        {
            string subString = "\"";
            for (int i = 0; i < Program.dbresults.Count; i++)
            {
                int indexOfSubstring = Program.dbresults[i].Img.IndexOf(subString);
                Program.dbresults[i].Img = Program.dbresults[i].Img.Substring(0, indexOfSubstring);
            }
        }
        public void Save(List<Result> results)
        {
            if (results.Count != 0)
            {
                string name = "";
                if (results[0].ModelType == "video")
                {
                    name = "WorkWithDirectories\\video.xml";
                }
                else if (results[0].ModelType == "image")
                {
                    name = "WorkWithDirectories\\image.xml";
                }
                else
                {
                    name = "WorkWithDirectories\\audio.xml";
                }
                List<Result> l = ReadFile(name);
                l = Merge(l, results);
                SaveFile(l, name);
                //_ = SaveResultsAsync("video", "jojo", "url");
                for (int i = 0; i < results.Count; i++)
                {
                    string url = results[i].ModelType == "image" ? results[i].Img : results[i].Link;
                    WorkWithDirectories.Directories.SaveResults(results[i].ModelType, Program.QueryString, results[i].Title, url);
                }
            }
        }
        public List<Result> Merge(List<Result> l, List<Result> r)
        {
            for (int i = 0; i < r.Count; i++)
            {
                l.Add(r[i]);
            }
            return l;
        }
        public ActionResult ShowCash(string action)
        {
            string name = "";
            if (action == "video")
            {
                name = "WorkWithDirectories\\video.xml";
            }
            else if (action == "image")
            {
                name = "WorkWithDirectories\\image.xml";
            }
            else
            {
                name = "WorkWithDirectories\\audio.xml";
            }
            List<Result> results = ReadFile(name);
            return View(results.ToList());
        }
        XmlSerializer formatter = new XmlSerializer(typeof(List<Result>));
        public void SaveFile(List<Result> l, string name)
        {
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, l);
            }
        }
        public List<Result> ReadFile(string name)
        {
            List<Result> l = new List<Result>();
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate))
            {
                if (new FileInfo(name).Length != 0)
                {
                    l = (List<Result>)formatter.Deserialize(fs);
                }
            }
            return l;
        }
        public ActionResult Choose()
        {
            //List<Result> results = ReadFile();
            return View(Program.dbresults.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
}

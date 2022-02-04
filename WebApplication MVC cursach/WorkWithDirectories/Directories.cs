using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using VideoLibrary;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace WebApplication_MVC_cursach.WorkWithDirectories
{
    public class Directories
    {
        static public string FindPath()
        {
            string[] separatingStrings = { "\\" };
            //"C:\\Users\\vikyc\\source\\repos\\WebApplication MVC cursach\\WebApplication MVC cursach\\bin\\Debug\\netcoreapp3.1\\"
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string[] newpath = path.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            string np = "";
            for (int i = 0; i < newpath.Length - 4; i++)
            {
                np += newpath[i] + "\\";
            }
            return np;
        }
        static public void CreateDirTree()
        {
            string path = FindPath();
            string subpath = @"Downloaded files\video";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
            path += "Downloaded files\\";
            subpath = @"image";
            dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);

            //_ = SaveResultsAsync("video", "jojo", "url");
        }
        static public void SaveResults(string item, string query, string name, string url)
        {
            // item == video or image or audio
            string[] separatingStrings = { " " };
            string[] newq = query.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            
            query = newq[0];
            name = name.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries)[0];
            string path = FindPath();
            path += "Downloaded files\\" + item + "\\" + query + "\\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            if (item == "video")
            {
                SaveVideoToDisk(path, url);
            }
            else if (item == "image")
            {
                path += name + ".jpg";
                SaveImages(path, url);
            }
            else
            {
                path += name;
                DateTime date1 = DateTime.Now;
                string s = date1.ToString();
                string[] separatingStrings1 = { ".", ":" };
                string[] news = s.Split(separatingStrings1, System.StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < news.Length-1; i++)
                {
                    path += news[i];
                }
                _ = SaveAudioAsync(path, url);
            }
        }
        private async Task DownloadImageAsync(string directoryPath, string fileName, Uri uri)
        {
            using var httpClient = new HttpClient();

            // Get the file extension
            var uriWithoutQuery = uri.GetLeftPart(UriPartial.Path);
            var fileExtension = Path.GetExtension(uriWithoutQuery);

            // Create file path and ensure directory exists
            var path = Path.Combine(directoryPath, $"{fileName}{fileExtension}");
            Directory.CreateDirectory(directoryPath);

            // Download the image and write to the file
            var imageBytes = await httpClient.GetByteArrayAsync(uri);
            await File.WriteAllBytesAsync(path, imageBytes);
        }
        static void SaveImages(string path, string url)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(url), path);
                
            }
        }
        static void SaveVideoToDisk(string path, string link)
        {
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(link);
            //var audio = youTube.
            File.WriteAllBytes(@path + video.FullName, video.GetBytes());
        }
        static async Task SaveAudioAsync(string path, string url)
        {
            var youtube = new YoutubeClient();
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);
            var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            await youtube.Videos.Streams.DownloadAsync(streamInfo, path + $".{streamInfo.Container}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication_MVC_cursach.Models
{
    public class Result
    {
        public int id { get; set; }
        public string ModelType { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string ShareUrl { get; set; }
        public string Snippet { get; set; }
        public string Img { get; set; }
        public bool selected { get; set; }

    }

}
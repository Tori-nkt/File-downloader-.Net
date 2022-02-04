using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using WebApplication_MVC_cursach.Models;
namespace WebApplication_MVC_cursach
{
    public class Program
    {
        static public List<Result> dbresults;
        static public string QueryString;
        public static void Main(string[] args)
        {
            WorkWithDirectories.Directories.CreateDirTree();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

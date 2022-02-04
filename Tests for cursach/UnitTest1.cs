using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using WebApplication_MVC_cursach.Controllers;
using WebApplication_MVC_cursach.Models;
using WebApplication_MVC_cursach.WorkWithDirectories;

namespace Tests_for_cursach
{
    public class Tests
    {
        private readonly ILogger<HomeController> _logger;
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(_logger);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [Test]
        public void Privacy()
        {
            // Arrange
            HomeController controller = new HomeController(_logger);

            // Act
            ViewResult result = controller.Privacy() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [Test]
        public void TestCreationOfDirectories()
        {
            Directories.CreateDirTree();
            string path = "C:\\Users\\vikyc\\source\\repos\\WebApplication MVC cursach\\Downloaded files";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Assert.IsTrue(dirInfo.Exists);
        }
        [Test]
        public void TestGetPath()
        {
            string path = Directories.FindPath();
            string actual = "C:\\Users\\vikyc\\source\\repos\\WebApplication MVC cursach\\";
            Assert.AreEqual(actual, path);
        }
        [Test]
        public void Test()
        {
            string url = "https://i.ytimg.com/vi/Y2NkuFIlLEo/maxresdefault.jpg";
            Directories.SaveResults("image", "test", "Imagine dragons test", url);
            string actual = "C:\\Users\\vikyc\\source\\repos\\WebApplication MVC cursach\\Downloaded files\\image\\test";
            DirectoryInfo dirInfo = new DirectoryInfo(actual);
            Assert.IsTrue(dirInfo.Exists);
        }

    }
}
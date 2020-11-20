using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        private RemoteWebDriver driver;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Hello");
            var options = new FirefoxOptions();
            driver = new RemoteWebDriver(new Uri("http://192.168.0.105:4444/wd/hub"), options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/index.html";
            Assert.Pass();
        }

        [TearDown]
        public void close()
        {
            Console.WriteLine("Driver closed");
            driver.Close();
        }

    }
}
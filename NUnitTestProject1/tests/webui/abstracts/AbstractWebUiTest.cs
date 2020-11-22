using System;
using NUnit.Framework;
using NUnitTestProject1.heroku.pages;
using NUnitTestProject1.tests.webui.abstracts;
using NUnitTestProject1.tests.webui.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace NUnitTestProject1.abstracts
{
    public abstract class AbstractWebUiTest<T> where T : AbstractPage<T>, new()
    {
        protected WebDriverWrapper driver;
        protected T page;
        
        [SetUp]
        public void setUp()
        {
            driver = new WebDriverProvider().getDriver();
            driver.Url = getUrl();
            page = AbstractPage<T>.of(driver);
        }

        protected abstract String getUrl();

        protected abstract Type getPageType();

        [TearDown]
        public void tearDown()
        {
            driver.Close();
            Console.WriteLine("Driver closed");
        }
    }
}
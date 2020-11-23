using System;
using NUnit.Framework;
using NUnitTestProject1.tests.webui.utils;

namespace NUnitTestProject1.tests.webui.abstracts
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

        [TearDown]
        public void tearDown()
        {
            driver.Close();
            Console.WriteLine("Driver closed");
        }
    }
}
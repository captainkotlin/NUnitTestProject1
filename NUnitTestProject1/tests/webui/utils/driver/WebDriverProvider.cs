using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnitTestProject1.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;

namespace NUnitTestProject1.tests.webui.utils
{
    public class WebDriverProvider
    {
        private String browser;
        
        public WebDriverProvider()
        {
            browser = TestContext.Parameters[CommandLineConstants.browser];
        }

        public RemoteWebDriver getRemoteDriver()
        {
            var driverOptions = new BrowserDependentAction<DriverOptions>()
                .with(BrowserConstants.chrome, () => new ChromeOptions())
                .with(BrowserConstants.firefox, () => new FirefoxOptions())
                .with(BrowserConstants.opera, () => new OperaOptions())
                .get(browser);
            return new RemoteWebDriver(new Uri(RuntimeConfiguration.webDriverRemoteUrl), driverOptions);
        }

        public WebDriverWrapper getDriver()
        {
            var driver = new BrowserDependentAction<IWebDriver>()
                .with(BrowserConstants.chrome, () => new ChromeDriver())
                .with(BrowserConstants.firefox, () => new FirefoxDriver())
                .with(BrowserConstants.opera, () => new OperaDriver())
                .get(browser);
            return WebDriverWrapper.of(driver);
        }
    }
}
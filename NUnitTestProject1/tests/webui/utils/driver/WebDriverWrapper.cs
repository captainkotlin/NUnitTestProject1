using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace NUnitTestProject1.tests.webui.utils
{
    public class WebDriverWrapper : IWebDriver
    {
        private IWebDriver driver;

        public WebDriverWrapper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static WebDriverWrapper of(IWebDriver driver)
        {
            return new WebDriverWrapper(driver);
        }

        public IWebElement FindElement(By @by)
        {
            return driver.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By @by)
        {
            return driver.FindElements(by);
        }

        public void Dispose()
        {
            driver.Dispose();
        }

        public void Close()
        {
            driver.Close();
        }

        public void Quit()
        {
            driver.Quit();
        }

        public IOptions Manage()
        {
            return driver.Manage();
        }

        public INavigation Navigate()
        {
            return driver.Navigate();
        }

        public ITargetLocator SwitchTo()
        {
            return driver.SwitchTo();
        }
        public string Url
        {
            get => driver.Url;
            set => driver.Url = value;
        }

        public string Title => driver.Title;
        public string PageSource => driver.PageSource;
        public string CurrentWindowHandle => driver.CurrentWindowHandle;
        public ReadOnlyCollection<string> WindowHandles => driver.WindowHandles;

        public IJavascriptExecutorWrapper asJS()
        {
            return IJavascriptExecutorWrapper.of((IJavaScriptExecutor) driver);
        }
    }
}
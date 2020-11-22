using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnitTestProject1.heroku.pages.message;
using NUnitTestProject1.tests.webui.utils;
using Org.BouncyCastle.Utilities;
using Selenium.Community.PageObjects;

namespace NUnitTestProject1.tests.webui.abstracts
{
    public class AbstractPage<TPage> where TPage : AbstractPage<TPage>, new()
    {
        protected WebDriverWrapper driver;
        public void init(WebDriverWrapper driver)
        {
            this.driver = driver;
            new PageObjectFactory(driver).InitElements(this);
        }

        public static TPage of(WebDriverWrapper driver)
        {
            TPage page = new TPage();
            page.init(driver);
            return page;
        }

        public TPage sleep(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return (TPage) this;
        }
        
        protected void waitForEquality<T>(Func<T> actualValueSupplier, T expectedValue, int intervalSeconds, int timeoutSeconds)
        {
            int pollDuration = 0;
            while (!expectedValue.Equals(actualValueSupplier.Invoke()))
            {
                sleep(intervalSeconds);
                pollDuration += intervalSeconds;
                throwIf(pollDuration > timeoutSeconds, new Exception("Timeout of " + intervalSeconds + " seconds exceeded"));
            }
        }

        protected void waitForEquality<T>(int intervalSeconds, int timeoutSeconds, params KeyValuePair<Func<T>, T>[] expectedAndActualValues)
        {
            int pollDuration = 0;
            while (!areConditionsMet(expectedAndActualValues))
            {
                sleep(intervalSeconds);
                pollDuration += intervalSeconds;
                throwIf(pollDuration > timeoutSeconds, new Exception("Timeout of " + timeoutSeconds + " seconds exceeded"));
            }
        }
        private bool areConditionsMet<T>(params KeyValuePair<Func<T>, T>[] expectedAndActualValues)
        {
            return expectedAndActualValues.Select(a => a.Value.Equals(a.Key))
                .Aggregate((a, b) => a && b);
        }

        private void throwIf(bool condition, Exception ex)
        {
            if (condition)
            {
                throw ex;
            }
        }
    }
}
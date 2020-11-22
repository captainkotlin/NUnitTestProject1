using System;
using System.Collections.Generic;
using System.Linq;
using NUnitTestProject1.abstracts;
using NUnitTestProject1.heroku.pages.message;
using NUnitTestProject1.tests.webui.abstracts;
using NUnitTestProject1.tests.webui.utils;
using OpenQA.Selenium;
using Selenium.Community.PageObjects;

namespace NUnitTestProject1.heroku.pages
{
    public class XhttpMessagesPage : AbstractPage<XhttpMessagesPage>
    {
        public MessageRecognizer messageRecognizer { get; } = new MessageRecognizer();

        public long getLiveMessages()
        {
            return driver.asJS().ExecuteScript<long>("return liveMessages");
        }

        public long getTotalRequestsMage()
        {
            return driver.asJS().ExecuteScript<long>("return totalRequestsMade");
        }

        public XhttpMessagesPage waitForMessagesCompletion()
        {
            waitForEquality(() => driver.asJS().ExecuteScript("return liveMessages"), 0L, 1, 10);
            sleep(2);
            return this;
        }

        public bool isMakingCallMessage(String message)
        {
            return "making call".Equals(message);
        }

        public bool isProcessingResultsMessage(String message)
        {
            return "processing results".Equals(message);
        }

        public List<String> getMessageLog()
        {
            return driver.FindElements(By.CssSelector("#messageslist > li")).Select(e => e.Text).ToList();
        }
    }
}
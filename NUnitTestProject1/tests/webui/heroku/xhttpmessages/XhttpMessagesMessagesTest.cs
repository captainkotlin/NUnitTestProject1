using NUnit.Framework;
using NUnitTestProject1.tests.utils;
using NUnitTestProject1.tests.webui.heroku.xhttpmessages.abstracts;

namespace NUnitTestProject1.tests.webui.heroku.xhttpmessages
{
    public class XhttpMessagesMessagesTest : AbstractXhttpMessagesTest
    {
        [Test]
        [Category(TestCategories.WebUi)]
        public void test()
        {
            var liveMessages = page.getLiveMessages();
            var totalRequestsMade = page.getTotalRequestsMage();
            // Reason of failures should be found
            // Assert.AreEqual(liveMessages, totalRequestsMade);
            page.waitForMessagesCompletion();

            var makingCallEntries = 0;
            var processingResultsEntries = 0;
            var messageRecognizer = page.messageRecognizer;
            var textEntries = page.getMessageLog();
            foreach (var textEntry in textEntries)
            {
                if (page.isMakingCallMessage(textEntry))
                {
                    makingCallEntries++;
                    continue;
                }
                if (page.isProcessingResultsMessage(textEntry))
                {
                    processingResultsEntries++;
                    continue;
                }
                messageRecognizer.addTextEntry(textEntry);
            }
            Assert.AreEqual(totalRequestsMade, makingCallEntries) ;
            Assert.AreEqual(totalRequestsMade, processingResultsEntries);
        }
    }
}
using System;
using NUnitTestProject1.tests.webui.abstracts;
using NUnitTestProject1.tests.webui.heroku.pages;

namespace NUnitTestProject1.tests.webui.heroku.xhttpmessages.abstracts
{
    public class AbstractXhttpMessagesTest : AbstractWebUiTest<XhttpMessagesPage>
    {
        protected override string getUrl()
        {
            return "https://testpages.herokuapp.com/styled/sync/xhttp-messages.html";
        }

        protected virtual Type getPageType()
        {
            return typeof(XhttpMessagesPage);
        }
    }
}
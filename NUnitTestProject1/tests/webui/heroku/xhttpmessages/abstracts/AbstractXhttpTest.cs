using System;
using NUnitTestProject1.abstracts;
using NUnitTestProject1.heroku.pages;

namespace NUnitTestProject1.tests.webui.heroku.xhttpmessages
{
    public class AbstractXhttpTest : AbstractWebUiTest<XhttpMessagesPage>
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
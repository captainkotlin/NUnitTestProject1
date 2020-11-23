using System.Threading;
using FlaUI.Core.AutomationElements;
using NUnitTestProject1.tests.webui.abstracts;

namespace NUnitTestProject1.tests.ui.abstracts
{
    public class AbstractPage<T> where T : AbstractPage<T>, new()
    {
        protected Window window;
        public void init(Window window)
        {
            this.window = window;
            window.Focus();
            sleep(2);
        }

        public T sleep(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return (T) this;
        }
    }
}
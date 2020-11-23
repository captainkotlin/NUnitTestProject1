using System;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;
using NUnit.Framework;

namespace NUnitTestProject1.tests.ui.abstracts
{
    public abstract class AbstractUiTest<T> where T : AbstractPage<T>, new()
    {
        private Application app;
        private UIA3Automation automation;
        private Window window;
        protected T page;
        
        [SetUp]
        public void setUp()
        {
            app = Application.Launch(getExeFilePath());
            automation = new UIA3Automation();
            window = app.GetMainWindow(automation);
            page = new T();
            page.init(window);
        }
        
        protected abstract String getExeFilePath();

        [TearDown]
        public void tearDown()
        {
            automation.Dispose();
            app.Close();
            app.Dispose();
        }
    }
}
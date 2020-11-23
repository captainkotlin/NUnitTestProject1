using System;
using FlaUI.Core;
using FlaUI.UIA3;

namespace NUnitTestProject1.tests.ui.utils
{
    public class UIUtils
    {
        public void executeUIA3(String exeFilePath, Action<Application, UIA3Automation> func)
        {
            using (var app = Application.Launch(exeFilePath))
            {
                using (var automation = new UIA3Automation())
                {
                    func.Invoke(app, automation);
                }
            }
        }
    }
}
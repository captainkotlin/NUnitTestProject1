using System;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using NUnitTestProject1.tests.ui.abstracts;

namespace NUnitTestProject1.tests.ui.notepad.pages
{
    public class NotepadPage : AbstractPage<NotepadPage>
    {
        public TextBox selectEditField()
        {
            return window.FindFirstDescendant(cf => cf.ByAutomationId("15")).AsTextBox();
        }

        public NotepadPage insertTextInEditField(String text)
        {
            Keyboard.Type(text);
            sleep(2);
            return this;
        }
    }
}
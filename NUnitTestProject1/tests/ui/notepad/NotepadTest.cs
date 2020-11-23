using System;
using FlaUI.Core.Input;
using NUnit.Framework;
using NUnitTestProject1.tests.ui.abstracts;
using NUnitTestProject1.tests.ui.notepad.pages;
using NUnitTestProject1.tests.ui.utils;

namespace NUnitTestProject1.tests.ui.notepad
{
    public class CalculatorTest : AbstractUiTest<NotepadPage>
    {
        [Test]
        public void test()
        {
            var textToType = "Text, typed in notepad";
            var editField = page.selectEditField();
            page.insertTextInEditField(textToType);
            Assert.That(editField.Text, Is.EqualTo(textToType));
        }

        protected override String getExeFilePath()
        {
            return "notepad.exe";
        }
    }
}
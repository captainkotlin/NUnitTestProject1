using System;
using NUnitTestProject1.tests.webui.abstracts;
using OpenQA.Selenium;
using Selenium.Community.PageObjects;

namespace NUnitTestProject1.tests.webui.heroku.fileupload.pages
{
    public class FileProcessorPage : AbstractPage<FileProcessorPage>
    {
        [FindsBy(How.CssSelector, "input[type='file']")]
        private IWebElement input;
        [FindsBy(How.CssSelector, "#itsanimage")]
        private IWebElement imageRadio;
        [FindsBy(How.CssSelector, "#itsafile")]
        private IWebElement fileRadio;
        [FindsBy(How.CssSelector, ".styled-click-button")]
        private IWebElement uploadButton;
        [FindsBy(How.CssSelector, "#uploadedfilename")]
        private IWebElement uploadedFileName;
        [FindsBy(How.CssSelector, "#goback")]
        private IWebElement uploadAnotherButton;
        
        public FileProcessorPage setPathToUploadFile(String path)
        {
            input.SendKeys(path);
            return this;
        }

        public FileProcessorPage selectImageRadio()
        {
            imageRadio.Click();
            return this;
        }

        public FileProcessorPage selectTextRadio()
        {
            fileRadio.Click();
            return this;
        }

        public FileProcessorPage clickUploadButton()
        {
            uploadButton.Click();
            return this;
        }

        public String getUploadedFileName()
        {
            return uploadedFileName.Text;
        }

        public bool goBackButtonExists()
        {
            return uploadAnotherButton.Displayed;
        }
    }
}
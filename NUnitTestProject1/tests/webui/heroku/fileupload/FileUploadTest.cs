using System.IO;
using NUnit.Framework;
using NUnitTestProject1.tests.utils;
using NUnitTestProject1.tests.webui.abstracts;
using NUnitTestProject1.tests.webui.heroku.fileupload.pages;

namespace NUnitTestProject1.tests.webui.heroku.fileupload
{
    public class FileUploadTest : AbstractWebUiTest<FileProcessorPage>
    {
        protected override string getUrl()
        {
            return "https://testpages.herokuapp.com/styled/file-upload-test.html";
        }

        [Test]
        [Category(TestCategories.WebUi)]
        public void uploadTest()
        {
            var fileToUploadName = "appsettings.json";
            var fileToUploadPath = Path.GetFullPath("resources/" + "appsettings.json");
            var uploadedFileName = page.setPathToUploadFile(fileToUploadPath)
                .selectTextRadio()
                .clickUploadButton()
                .sleep(3)
                .getUploadedFileName();
            Assert.That(fileToUploadName, Is.EqualTo(uploadedFileName));
            Assert.That(page.goBackButtonExists(), Is.True);
        }
    }
}
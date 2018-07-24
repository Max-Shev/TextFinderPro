using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFinderPro.Library.TextExtraction.FileProviders;

namespace TextFinderPro.UnitTests.TextExtraction
{
    public class TextFileProviderTest:FileProviderBaseTest
    {
        [OneTimeSetUp]
        public void Init()
        {
            _fileProvider = new TextFileProvider();
            _fileForTest = Path.Combine(TestFilesFolder, "test.txt");
            _extractedFileText = _fileProvider.GetTextFromFile(_fileForTest);
        }

        [Test]
        public void TxtExtractionIsValid()
        {
            var result = _fileProvider.GetTextFromFile(_fileForTest);
            Assert.IsTrue(result.IsValidExtraction);
        }

        [Test]
        public void FileContainsInstall()
        {
            var result = _extractedText.Contains("install");
            Assert.IsTrue(result);
        }

        [Test]
        public void FileNotContainsInstallee()
        {
            var result = _extractedText.Contains("installee");
            Assert.IsFalse(result);
        }
    }
}

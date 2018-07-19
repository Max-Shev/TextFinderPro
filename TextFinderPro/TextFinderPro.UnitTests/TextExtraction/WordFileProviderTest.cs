using NUnit.Framework;
using System.IO;
using TextFinderPro.Library.TextExtraction.FileProviders;

namespace TextFinderPro.UnitTests.TextExtraction
{
    [TestFixture]
    public class WordFileProviderTest:FileProviderBaseTest
    {
        [OneTimeSetUp]
        public void Init()
        {
            _fileProvider = new WordFileProvider();
            _fileForTest = Path.Combine(TestFilesFolder, "test.doc");
            _extractedFileText = _fileProvider.GetTextFromFile(_fileForTest);
        }

        [Test]
        public void WordExtractionIsValid()
        {
            var result = _fileProvider.GetTextFromFile(_fileForTest);
            Assert.IsTrue(result.IsValidExtraction);
        }

        [Test]
        public void FileContainsRecenzia()
        {
            var result = _extractedText.Contains("Рецензия");
            Assert.IsTrue(result);
        }

        [Test]
        public void FileNotContainsBlya()
        {
            var result = _extractedText.Contains("Бля");
            Assert.IsFalse(result);
        }

        [Test]
        public void FileContainsErusalimskiy()
        {
            var result = _extractedText.Contains("Ерусалимский");
            Assert.IsTrue(result);
        }
    }
}

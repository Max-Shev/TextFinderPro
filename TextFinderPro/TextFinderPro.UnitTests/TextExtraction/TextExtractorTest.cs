using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFinderPro.Library.TextExtraction;

namespace TextFinderPro.UnitTests.TextExtraction
{
    [TestFixture]
    public class TextExtractorTest
    {
        private TextExtractor _textExtractor;

        [SetUp]
        public void Init()
        {
            _textExtractor = new TextExtractor();
        }

        [Test]
        public void RtfIncludeExcludeInExtractionSettings()
        {
            _textExtractor.ExtentionsForExtracting.Add(".rtf");
            _textExtractor.ExcludedExtentions.Add(".rtf");
            Assert.IsFalse(_textExtractor.AreSettingsCorrect());
        }

        [Test]
        public void RtfIncludeDocExcludeInExtractionSettings()
        {
            _textExtractor.ExtentionsForExtracting.Add(".rtf");
            _textExtractor.ExcludedExtentions.Add(".doc");
            Assert.IsTrue(_textExtractor.AreSettingsCorrect());
        }

        [Test]
        public void AllFilesWithExtractionExtention()
        {
            _textExtractor.ExtentionsForExtracting.Add(".rtf");
            _textExtractor.AllFilesNeedToExtract = true;
            Assert.IsFalse(_textExtractor.AreSettingsCorrect());
        }

        [Test]
        public void AllFilesWithExcludedExtention()
        {
            _textExtractor.ExcludedExtentions.Add(".rtf");
            _textExtractor.AllFilesNeedToExtract = true;
            Assert.IsFalse(_textExtractor.AreSettingsCorrect());
        }

        [Test]
        public void FileCollectionContainsRegion()
        {
            string TestFilesFolder = @"E:\Проекты\TextFinderPro\TextFinderPro\TextFinderPro.UnitTests\bin\Debug\TestFiles";
            List<string> fileCollection = new List<string> { Path.Combine(TestFilesFolder, "test.pdf"), Path.Combine(TestFilesFolder, "test.doc") };
            _textExtractor.AllFilesNeedToExtract = true;
            var texts = _textExtractor.GetTextFromFiles(fileCollection);

            var result = texts.Any(text => text.FileText.Contains("регион"));
            Assert.IsTrue(result);
        }
    }
}

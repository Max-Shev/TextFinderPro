using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFinderPro.Library.TextExtraction;
using TextFinderPro.Library.TextExtraction.FileProviders;

namespace TextFinderPro.UnitTests.TextExtraction
{
    [TestFixture]
    public class PdfFileProviderTest
    {
        private PdfFileProvider _pdfFileProvider;
        private ExtractedFileText _extractedFileText;
        private string _extractedText => _extractedFileText.FileText;
        private const string TestFilesFolder = @"E:\Проекты\TextFinderPro\TextFinderPro\TextFinderPro.UnitTests\bin\Debug\TestFiles";
        private string _pdfFileForTest;

        [OneTimeSetUp]
        public void Init()
        {
            _pdfFileProvider = new PdfFileProvider();
            _pdfFileForTest = Path.Combine(TestFilesFolder ,  "test.pdf");
            _extractedFileText = _pdfFileProvider.GetTextFromFile(_pdfFileForTest);
        }

        [Test]
        public void ExtractionIsValid()
        {
            var result = _pdfFileProvider.GetTextFromFile(_pdfFileForTest);
            Assert.IsTrue(result.IsValidExtraction);
        }

        [Test]
        public void FileConstainsPolis()
        {
            var result = _extractedText.Contains("полис");
            Assert.IsTrue(result);
        }

        [Test]
        public void FileConstains0045031833()
        {
            var result = _extractedText.Contains("0045031833");
            Assert.IsTrue(result);
        }

        [Test]
        public void FileConstainsValerievich()
        {
            var result = _extractedText.Contains("Валерьевич");
            Assert.IsTrue(result);
        }

        [Test]
        public void FileConstainsZ94CT41CADR242603()
        {
            var result = _extractedText.Contains("Z94CT41CADR242603");
            Assert.IsTrue(result);
        }

        [Test]
        public void FileConstainsData()
        {
            var result = _extractedText.Contains("Дата");
            Assert.IsTrue(result);
        }

        [Test]
        public void FileConstainsSerialNumber()
        {
            var result = _extractedText.Contains("6E27 16E6 F698 87F7 A8B0 0B22 6A14 8C1D C397 A94C");
            Assert.IsTrue(result);
        }

        [Test]
        public void FileConstainsTelephoneNumber()
        {
            var result = _extractedText.Contains("800-333-0-999");
            Assert.IsTrue(result);
        }

        [Test]
        public void FileConstainsPrimechania()
        {
            var result = _extractedText.Contains("ПРИМЕЧАНИЯ");
            Assert.IsTrue(result);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
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
        private const string PdfFileForTest = "TestFiles/test.pdf";

        [OneTimeSetUp]
        public void Init()
        {
            _pdfFileProvider = new PdfFileProvider();
            _extractedFileText = _pdfFileProvider.GetTextFromFile(PdfFileForTest);
        }

        [Test]
        public void ExtractionIsValid()
        {
            var result = _pdfFileProvider.GetTextFromFile(PdfFileForTest);
            Assert.IsTrue(result.IsValidExtraction);
        }
        
        [Test]
        public void FileConstainsPolis()
        {
            var result = _extractedText.Contains("полис");
            Assert.IsTrue(result);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
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

        [OneTimeSetUp]
        public void Init()
        {
            _textExtractor = new TextExtractor();
        }

        [Test]
        public void RtfIncludeExcludeInExtractionSettings()
        {
            _textExtractor.ExtentionsForExtracting.Add(".rtf");
            _textExtractor.ExcludedExtentions.Add(".rtf");
            Assert.IsTrue(_textExtractor.AreSettingsCorrect());
        }
    }
}

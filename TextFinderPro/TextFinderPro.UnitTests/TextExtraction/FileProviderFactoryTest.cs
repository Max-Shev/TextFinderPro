using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFinderPro.Library.TextExtraction.FileProviders;

namespace TextFinderPro.UnitTests.TextExtraction
{
    [TestFixture]
    public class FileProviderFactoryTest
    {
        [Test]
        public void RtfExtentionSelectTextProvider()
        {
            var fileProvider = FileProviderFactory.GetTextProvider("rootfolder//filename.rtf");
            Assert.IsInstanceOf(typeof(TextFileProvider), fileProvider);
        }

        [Test]
        public void RtfExtentionNotSelectWordProvider()
        {
            var fileProvider = FileProviderFactory.GetTextProvider("rootfolder//filename.rtf");
            Assert.IsNotInstanceOf(typeof(WordFileProvider), fileProvider);
        }

        [Test]
        public void WordExtentionSelectWordProvider()
        {
            var fileProvider = FileProviderFactory.GetTextProvider("rootfolder//filename.docx");
            Assert.IsInstanceOf(typeof(WordFileProvider), fileProvider);
        }

        [Test]
        public void IsoExtentionThrowsException()
        {
            Assert.Throws(typeof(InvalidOperationException) , () => FileProviderFactory.GetTextProvider("rootfolder//.iso"));
        }
    }
}

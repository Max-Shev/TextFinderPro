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
    public class FileProviderBaseTest
    {
        protected FileProvider _fileProvider;
        protected ExtractedFileText _extractedFileText;
        protected string _extractedText => _extractedFileText.FileText;
        protected const string TestFilesFolder = @"E:\Проекты\TextFinderPro\TextFinderPro\TextFinderPro.UnitTests\bin\Debug\TestFiles";
        protected string _fileForTest;
    }
}

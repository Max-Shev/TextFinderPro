using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.TextExtraction.FileProviders
{
    public class TextFileProvider : FileProvider
    {
        protected TextFileProvider(FileProviderType fileProviderType) : base(FileProviderType.TextFile)
        {
        }

        protected override string TryGetTextFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}

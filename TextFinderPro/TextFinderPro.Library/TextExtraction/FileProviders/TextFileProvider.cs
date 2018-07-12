using System;
using System.Collections.Generic;
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

        public override IEnumerable<ExtractedFileText> GetTextFromFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<ExtractedFileText> GetTextFromFiles(IEnumerable<string> filePath)
        {
            throw new NotImplementedException();
        }
    }
}

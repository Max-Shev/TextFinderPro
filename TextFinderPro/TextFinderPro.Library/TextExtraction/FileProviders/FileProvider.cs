using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.TextExtraction.FileProviders
{
    abstract class FileProvider
    {
        public FileProviderType FileProviderType { get; }

        protected FileProvider(FileProviderType fileProviderType)
        {
            FileProviderType = fileProviderType;
        }

        public abstract IEnumerable<ExtractedFileText> GetTextFromFile(string filePath);
        public abstract IEnumerable<ExtractedFileText> GetTextFromFiles(IEnumerable<string> filePath);
    }
}

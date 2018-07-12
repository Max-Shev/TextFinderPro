using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.TextExtraction.FileProviders
{
    public abstract class FileProvider
    {
        public FileProviderType FileProviderType { get; }

        protected FileProvider(FileProviderType fileProviderType)
        {
            FileProviderType = fileProviderType;
        }

        
        protected abstract IEnumerable<ExtractedFileText> TryGetTextFromFile(string filePath);
        public virtual IEnumerable<ExtractedFileText> GetTextFromFile(string filePath)
        {
            try
            {
                return TryGetTextFromFile(filePath);
            }
            catch
            {
                return FailFileText.FromFile(filePath);
            }
        }
        public abstract IEnumerable<ExtractedFileText> GetTextFromFiles(IEnumerable<string> filePath);
    }
}

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

        
        protected abstract string TryGetTextFromFile(string filePath);

        public virtual ExtractedFileText GetTextFromFile(string filePath)
        {
            try
            {
                return new ExtractedFileText(TryGetTextFromFile(filePath) , filePath , true);
            }
            catch
            {
                return FailFileText.FromFile(filePath);
            }
        }
        public virtual IEnumerable<ExtractedFileText> GetTextFromFiles(IEnumerable<string> filePathCollection)
        {
            return filePathCollection.AsParallel().Select(GetTextFromFile);
        }
    }
}

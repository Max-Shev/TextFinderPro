using System.IO;

namespace TextFinderPro.Library.TextExtraction.FileProviders
{
    public class TextFileProvider : FileProvider
    {
        public TextFileProvider() : base(FileProviderType.TextFile)
        {
        }

        protected override string TryGetTextFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}

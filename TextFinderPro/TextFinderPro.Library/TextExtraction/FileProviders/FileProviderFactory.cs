using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.TextExtraction.FileProviders
{
    public class FileProviderFactory
    {
        private static readonly Dictionary<string, FileProviderType> _providerTypesRelations;
        private static readonly Dictionary<FileProviderType, FileProvider> _textProviders;

        static FileProviderFactory()
        {
            _providerTypesRelations = new Dictionary<string, FileProviderType>();
            _providerTypesRelations.Add(".txt", FileProviderType.TextFile);
            _providerTypesRelations.Add(".rtf", FileProviderType.TextFile);
            _providerTypesRelations.Add(".doc", FileProviderType.WordFile);
            _providerTypesRelations.Add(".docx", FileProviderType.WordFile);
            _providerTypesRelations.Add(".pdf", FileProviderType.PdfFile);

            _textProviders = new Dictionary<FileProviderType, FileProvider>();
            _textProviders.Add(FileProviderType.TextFile, new TextFileProvider());
            _textProviders.Add(FileProviderType.WordFile, new WordFileProvider());
            _textProviders.Add(FileProviderType.PdfFile, new PdfFileProvider());
        }

        public static List<string> RegisteredExtentions => _providerTypesRelations.Select(e => e.Key).ToList();

        public static FileProvider GetTextProvider(string fileExtention)
        {
            fileExtention = fileExtention.ToLower();
            if (!_providerTypesRelations.ContainsKey(fileExtention))
                throw new InvalidOperationException($"There is no any text providers for this file extention {fileExtention}");
            return _textProviders[_providerTypesRelations[fileExtention]];
        }

        public static FileProvider GetTextProvider(FileProviderType FileProviderType)
        {
            if (!_textProviders.ContainsKey(FileProviderType))
                throw new InvalidOperationException($"There is no any text providers for this provider type {FileProviderType}");
            return _textProviders[FileProviderType];
        }

        public static FileProvider GetTextProvider(FileInfo fileInfo)
        {
            return GetTextProvider(fileInfo.Extension);
        }
    }
}

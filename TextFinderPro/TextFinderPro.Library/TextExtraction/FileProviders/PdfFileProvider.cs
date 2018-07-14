using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.TextExtraction.FileProviders
{
    public class PdfFileProvider : FileProvider
    {
        public PdfFileProvider() : base(FileProviderType.PdfFile)
        {
        }

        protected override string TryGetTextFromFile(string filePath)
        {
            PdfReader pdfReader = new PdfReader(filePath);
            StringBuilder pdfTextBuilder = new StringBuilder();
            for (int pageIndex = 1; pageIndex < pdfReader.NumberOfPages; pageIndex++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                string text = PdfTextExtractor.GetTextFromPage(pdfReader, pageIndex, strategy);
                pdfTextBuilder.Append(text);
            }
            return pdfTextBuilder.ToString();
        }
    }
}

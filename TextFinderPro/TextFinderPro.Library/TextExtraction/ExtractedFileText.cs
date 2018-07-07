using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.TextExtraction
{
    /// <summary>
    /// Result of extraction text from file
    /// </summary>
    public class ExtractedFileText
    {
        /// <summary>
        /// Extracted text
        /// </summary>
        public string FileText { get; set; }

        /// <summary>
        /// File of text
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Mark of succes extraction
        /// </summary>
        public bool IsValidExtraction { get; set; }

        public ExtractedFileText(string fileText, string fileName, bool isValidExtraction)
        {
            FileText = fileText;
            FileName = fileName;
            IsValidExtraction = isValidExtraction;
        }

    }
}

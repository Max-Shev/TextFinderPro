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

        /// <summary>
        /// Message of throwing exceptiob during extraction. Empty string if extraction is successfull
        /// </summary>
        public string ErrorMessage { get; set; }

        public ExtractedFileText(string fileText, string fileName, bool isValidExtraction = true, string errorMessage = "")
        {
            FileText = fileText;
            FileName = fileName;
            IsValidExtraction = isValidExtraction;
            ErrorMessage = errorMessage;
        }

    }
}

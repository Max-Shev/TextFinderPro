using System.Text;
using Microsoft.Office.Interop.Word;

namespace TextFinderPro.Library.TextExtraction.FileProviders
{
    public class WordFileProvider : FileProvider
    {
        public WordFileProvider() : base(FileProviderType.WordFile)
        {
        }

        protected override string TryGetTextFromFile(string filePath)
        {
            Application app = new Application();
            string result = GetTextFromWordDocument(ref app, filePath);
            app.Quit();
            return result;
        }


        /// <summary>
        /// Getting word file and try to extract text from it. It xan throw some exception ms word created
        /// </summary>
        /// <param name="wordApplication">Reference to unmanagement resource of word process</param>
        /// <param name="filePath">.doc or .docx file for extraction</param>
        /// <returns></returns>
        private  string GetTextFromWordDocument(ref Application wordApplication, string filePath)
        {
            Document wordDocument = wordApplication.Documents.Open(filePath);
            wordDocument.Activate();

            Paragraphs paragraphs = wordDocument.Paragraphs;
            StringBuilder wordText = new StringBuilder();
            foreach (Paragraph paragraph in paragraphs)
                wordText.Append(paragraph.Range.Text);

            wordDocument.Close();
            return wordText.ToString();
        }
    }
}

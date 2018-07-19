using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.TextExtraction
{
    /// <summary>
    /// This is subclass of ExtractedFileText, it different by mark of fail extraction
    /// </summary>
    public sealed class FailFileText : ExtractedFileText
    {
        private FailFileText(string fileText, string fileName, bool isValidExtraction , string errorMessage) : base(String.Empty, fileName, false ,errorMessage)
        {
        }

        /// <summary>
        /// Fabric method for fast creeation of fail instance
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static FailFileText FromFile(string fileName , string errorMessage)
        {
            return new FailFileText(string.Empty, fileName, false , errorMessage);
        }
    }
}

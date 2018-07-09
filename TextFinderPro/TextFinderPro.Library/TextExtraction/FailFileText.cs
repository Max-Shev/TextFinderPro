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
        private FailFileText(string fileText, string fileName, bool isValidExtraction) : base(String.Empty, fileName, false)
        {
        }

        /// <summary>
        /// Fabric method for fast creeation of fail instance
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static FailFileText FromFile(string fileName)
        {
            return new FailFileText(string.Empty, fileName, false);
        }
    }
}

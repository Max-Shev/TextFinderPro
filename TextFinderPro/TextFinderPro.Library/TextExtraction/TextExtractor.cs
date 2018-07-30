using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.TextExtraction
{
    public class TextExtractor
    {
        public bool AllFilesNeedToExtract { get; set; }
        public ICollection<string> ExtentionsForExtracting { get; set; }
        public ICollection<string> ExcludedExtentions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.Searching.SearchProviders.SearchResullt
{
    /// <summary>
    /// Result of search in file
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// Searched file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Mark of valid extraction
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Type of search (exact or regex etc.)
        /// </summary>
        public SearchProviderType SearchType { get; set; }

        /// <summary>
        /// Found text incomings
        /// </summary>
        public IEnumerable<FoundText> FoundTexts { get; set; }

        /// <summary>
        /// Return true if there is some search success in file
        /// </summary>
        public bool HsaFounds => FoundTexts.Count() != 0;
    }
}

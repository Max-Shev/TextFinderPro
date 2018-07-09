using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFinderPro.Library.Searching.SearchProviders.SearchResullt;

namespace TextFinderPro.Library.Searching.SearchProviders
{
    public class ExactSearchProvider : SearchProvider
    {
        public ExactSearchProvider(string sourceText) : base(SearchProviderType.ExactSearchProvider, sourceText)
        { }


        public override IEnumerable<FoundText> SearchAll(IEnumerable<string> patterns)
        {
            return patterns.SelectMany(SearchOne);
        }

        public override IEnumerable<FoundText> SearchAny(IEnumerable<string> patterns)
        {
            IEnumerable<FoundText> foundTexts = null;
            foreach (var pattern in patterns)
            {
                foundTexts = SearchOne(pattern);
                if (foundTexts.Count() != 0) return foundTexts;
            }
            return foundTexts;
        }

        public override IEnumerable<FoundText> SearchOne(string pattern)
        {
            int startSearchIndex = _sourceText.IndexOf(pattern);
            while (startSearchIndex != -1)
            {
                yield return (new FoundText(pattern, startSearchIndex));
                startSearchIndex = _sourceText.IndexOf(pattern, startSearchIndex + 1);
            }
        }
    }
}

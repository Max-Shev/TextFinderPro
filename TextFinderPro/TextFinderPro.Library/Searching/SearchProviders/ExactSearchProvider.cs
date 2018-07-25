using System.Collections.Generic;
using TextFinderPro.Library.Searching.SearchProviders.SearchResullt;

namespace TextFinderPro.Library.Searching.SearchProviders
{
    public class ExactSearchProvider : SearchProvider
    {
        public ExactSearchProvider(string sourceText) : base(SearchProviderType.ExactSearchProvider, sourceText)
        { }

        public override IEnumerable<FoundText> SearchOne(string pattern)
        {
            pattern = pattern.ToLower();
            int startSearchIndex = _sourceText.IndexOf(pattern);
            while (startSearchIndex != -1)
            {
                yield return (new FoundText(pattern, startSearchIndex));
                startSearchIndex = _sourceText.IndexOf(pattern, startSearchIndex + 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.Searching.SearchProviders
{
    public static class SearchProviderFactory
    {
        public static SearchProvider GetSearchProvider(SearchProviderType searchProviderType , string sourceText)
        {
            switch (searchProviderType)
            {
                case SearchProviderType.ExactSearchProvider:
                    return new ExactSearchProvider(sourceText);
                case SearchProviderType.RegexSearchProvider:
                    return new RegexSearchProvider(sourceText);
                default:
                    throw new ArgumentException($"SearchProvider with value {searchProviderType} doesn't exist");
            }
        }
    }
}

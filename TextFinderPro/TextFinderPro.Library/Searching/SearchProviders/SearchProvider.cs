using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFinderPro.Library.Searching.SearchProviders
{
    /// <summary>
    /// Provides methods for searching of many types
    /// </summary>
    public abstract class SearchProvider
    {
        private string _sourceText;
        private SearchProviderType _providerType;
        
        protected SearchProvider(SearchProviderType providerType  , string sourceText)
        {
            _providerType = providerType;
            _sourceText = sourceText;
        }

        public abstract IEnumerable<SearchResult> SearchOne(string pattern);
        public abstract IEnumerable<SearchResult> SearchAny(IEnumerable<string> patterns);
        public abstract IEnumerable<SearchResult> SearchAll(IEnumerable<string> patterns);

        public IEnumerable<SearchResult> SearchAny(params string[] patterns) => SearchAny(patterns.AsEnumerable());
        public IEnumerable<SearchResult> SearchAll(params string[] patterns) => SearchAll(patterns.AsEnumerable());
    }
}

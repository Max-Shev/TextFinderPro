using System.Collections.Generic;
using System.Text.RegularExpressions;
using TextFinderPro.Library.Searching.SearchProviders.SearchResullt;

namespace TextFinderPro.Library.Searching.SearchProviders
{
    public class RegexSearchProvider : SearchProvider
    {
        public RegexSearchProvider(string sourceText) : base(SearchProviderType.RegexSearchProvider, sourceText)
        { }

        public override IEnumerable<FoundText> SearchOne(string pattern)
        {
            Regex regex = new Regex(pattern , RegexOptions.IgnoreCase);
            foreach (Match match in regex.Matches(_sourceText))
                yield return new FoundText(match.Value, match.Index);
        }
    }
}

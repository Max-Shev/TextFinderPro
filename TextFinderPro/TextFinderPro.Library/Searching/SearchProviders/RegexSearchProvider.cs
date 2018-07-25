using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextFinderPro.Library.Searching.SearchProviders.SearchResullt;

namespace TextFinderPro.Library.Searching.SearchProviders
{
    public class RegexSearchProvider : SearchProvider
    {
        public RegexSearchProvider(string sourceText) : base(SearchProviderType.RegexSearchProvider, sourceText)
        { }


        public override IEnumerable<FoundText> SearchAll(IEnumerable<string> patterns)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<FoundText> SearchAny(IEnumerable<string> patterns)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<FoundText> SearchOne(string pattern)
        {
            Regex regex = new Regex(pattern);
            foreach (Match match in regex.Matches(_sourceText))
                yield return new FoundText(match.Value, match.Index);
        }
    }
}

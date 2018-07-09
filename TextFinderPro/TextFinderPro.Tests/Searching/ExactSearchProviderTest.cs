using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFinderPro.Library.Searching.SearchProviders;

namespace TextFinderPro.Tests.Searching
{
    [TestFixture]
    public class ExactSearchProviderTest
    {
        private SearchProvider _exactSearchProvider;
        private string _sourceText;
        [SetUp]
        public void Init()
        {
            _sourceText = "Карл у Клары украл кораллы, а Клара у Карла украла кларнет.";
            _exactSearchProvider = SearchProviderFactory.GetSearchProvider(SearchProviderType.ExactSearchProvider , _sourceText);
        }
        #region SearchOne test methods
        public void KarlHasPosition0()
        {
            // arrange
            var searchResult = _exactSearchProvider.SearchOne("Karl").First();

            //assert
            Assert.AreEqual(searchResult.Position, 0);
        }

        public void TextHasTwoIncommings()
        {
            // arrange
            var searchResult = _exactSearchProvider.SearchOne("Karl").Count();

            //assert
            Assert.AreEqual(searchResult, 2);
        }

        public void SearchOfKarlReturnedTextKarl()
        {
            // arrange
            var searchResult = _exactSearchProvider.SearchOne("Karl").First();

            //assert
            Assert.AreEqual(searchResult.Text, "Karl");
        }
        #endregion

        #region SearchAny test methods
        public void TextHasAnyKlarAndNet()
        {
            // arrange
            var searchResult = _exactSearchProvider.SearchAny("Klar" , "Net").Count();

            //assert
            Assert.AreNotEqual(searchResult, 0);
        }

        #endregion

        #region  SearchAll test methods

        #endregion
    }
}

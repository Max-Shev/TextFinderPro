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


        [OneTimeSetUp]
        public void Init()
        {
            _sourceText = "Карл у Клары украл кораллы, а Клара у Карла украла кларнет.";
            _exactSearchProvider = SearchProviderFactory.GetSearchProvider(SearchProviderType.ExactSearchProvider , _sourceText);
        }

        #region SearchOne test methods
        [Test]
        public void KarlHasPosition0()
        {
            // arrange
            var searchResult = _exactSearchProvider.SearchOne("Карл").First();

            //assert
            Assert.AreEqual(searchResult.Position, 0);
        }

        [Test]
        public void TextHasTwoIncommings()
        {
            // arrange
            var searchResult = _exactSearchProvider.SearchOne("Карл").Count();

            //assert
            Assert.AreEqual(searchResult, 2);
        }

        [Test]
        public void SearchOfKarlReturnedTextKarl()
        {
            // arrange
            var searchResult = _exactSearchProvider.SearchOne("Карл").First();

            //assert
            Assert.AreEqual(searchResult.Text, "Карл");
        }
        #endregion

        #region SearchAny test methods
        [Test]
        public void TextHasAnyKlarAndNet()
        {
            // arrange
            var searchResult = _exactSearchProvider.SearchAny("Клар" , "Нет").Count();

            //assert
            Assert.AreNotEqual(searchResult, 0);
        }

        #endregion

        #region  SearchAll test methods

        #endregion
    }
}

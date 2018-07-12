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
            // act
            var searchResult = _exactSearchProvider.SearchOne("Карл").First();

            //assert
            Assert.AreEqual(searchResult.Position, 0);
        }

        [Test]
        public void TextHasTwoIncommings()
        {
            // act
            var searchResult = _exactSearchProvider.SearchOne("Карл").Count();

            //assert
            Assert.AreEqual(searchResult, 2);
        }

        [Test]
        public void SearchOfKarlReturnedTextKarl()
        {
            // act
            var searchResult = _exactSearchProvider.SearchOne("Карл").First();

            //assert
            Assert.AreEqual(searchResult.Text, "Карл".ToLower());
        }
        #endregion

        #region SearchAny test methods
        [Test]
        public void TextHasAnyKlarAndNet()
        {
            // act
            var searchResult = _exactSearchProvider.SearchAny("Клар" , "Нет").Count();

            //assert
            Assert.AreNotEqual(searchResult, 0);
        }


        #endregion

        #region  SearchAll test methods

        [Test]
        public void TextHas4KlarAndNet()
        {
            // act
            var searchResult = _exactSearchProvider.SearchAll("Клар", "Нет").Count();

            //assert
            Assert.AreEqual(searchResult, 4);
        }

        #endregion
    }
}

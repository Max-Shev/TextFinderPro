﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFinderPro.Library.Searching.SearchProviders;

namespace TextFinderPro.UnitTests.Searching
{
    [TestFixture]
    public class RegexSearchProviderTest
    {
        private SearchProvider _regexSearchProvider;
        private string _sourceText;


        [OneTimeSetUp]
        public void Init()
        {
            _sourceText = "Карл у Клары украл кораллы, а Клара у Карла украла кларнет.";
            _regexSearchProvider = SearchProviderFactory.GetSearchProvider(SearchProviderType.RegexSearchProvider, _sourceText);
        }

        [Test]
        public void TextHasKarlIncomming()
        {
            var searchResult = _regexSearchProvider.SearchOne("Карл");
            Assert.IsNotEmpty(searchResult);
        }

        [Test]
        public void TextContains11Words()
        {
            var searchResult = _regexSearchProvider.SearchOne(@"\w+").Count();
            Assert.AreEqual(searchResult, 11);
        }

        [Test]
        public void TextContainsUkralaInWordsBigerThanKral()
        {
            var searchResult = _regexSearchProvider.SearchOne(@"\w*крал\w*").Select(foundItem => foundItem.Text).Contains("украла");
            Assert.True(searchResult);
        }

        [Test]
        public void TextContainsBigerThanKral()
        {
            var searchResult = _regexSearchProvider.SearchOne(@"\w*крал\w*").Count();
            Assert.AreEqual(searchResult, 2);
        }
    }
}

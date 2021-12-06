using System;
using Xunit;
using FluentAssertions;

namespace SearchFunctionality.Tests
{
    public class SearchShould
    {
        [Fact]
        public void ReturnNoResultIfSearchIsFewerThan2Characters()
        {
            Funcionality funcionality = new Funcionality("s");
            funcionality.Search().Should().Be(null);
        }
        
        [Fact]
        public void ReturnAllCountryCityNamesStartingWithTheExactSearch()
        {
            Funcionality funcionality = new Funcionality("Va");
            funcionality.Search().Should().Be("Valencia, Vancouver");
        }
        
        [Fact]
        public void ReturnAllCountryCityNamesStartingWithTheExactSearchEvenIfIsCaseInsensitive()
        {
            Funcionality funcionality = new Funcionality("va");
            funcionality.Search().Should().Be("Valencia, Vancouver");
        }
        
        [Fact]
        public void ReturTheCountryEvenIfTheSearchTextIsJustAPartOfTheCountry()
        {
            Funcionality funcionality = new Funcionality("ape");
            funcionality.Search().Should().Be("Budapest");
        }
        
    }
}
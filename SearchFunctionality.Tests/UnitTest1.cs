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
        
        [Theory]
        [InlineData("Va", "Valencia, Vancouver" )]
        [InlineData("Dub", "Dubai" )]
        [InlineData("Amste", "Amsterdam" )]
        public void ReturnAllCountryCityNamesStartingWithTheExactSearch(string search, string result)
        {
            Funcionality funcionality = new Funcionality(search);
            funcionality.Search().Should().Be(result);
        }
        
        [Theory]
        [InlineData("va", "Valencia, Vancouver" )]
        [InlineData("dub", "Dubai" )]
        [InlineData("amste", "Amsterdam" )]
        public void ReturnAllCountryCityNamesStartingWithTheExactSearchEvenIfIsCaseInsensitive(string search, string result)
        {
            Funcionality funcionality = new Funcionality(search);
            funcionality.Search().Should().Be(result);
        }
        
       
        [Theory]
        [InlineData("couve", "Vancouver" )]
        [InlineData("uba", "Dubai" )]
        [InlineData("terd", "Rotterdam, Amsterdam" )]
        public void ReturTheCountryEvenIfTheSearchTextIsJustAPartOfTheCountry(string search, string result)
        {
            Funcionality funcionality = new Funcionality(search);
            funcionality.Search().Should().Be(result);
        }
        
        [Fact]
        public void ReturnsAllCountriesIfSearchIsAnAstherics()
        {
            Funcionality funcionality = new Funcionality("*");
            funcionality.Search().Should().Be("Paris, Budapest, Skopje, Rotterdam, Valencia, Vancouver, Amsterdam, Vienna, Sydney, New York City, London, Bangkok, Hong Kong, Dubai, Rome, Istanbul");
        }
    }
}
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
            Funcionality funcionality = new Funcionality("ss");
            funcionality.Search().Should().Be(null);
        }
        
        [Fact]
        public void ReturnAllCountryCityNamesStartingWithTheExactSearch()
        {
            Funcionality funcionality = new Funcionality("Va");
            funcionality.Search().Should().Be("Valencia, Vancouver");
        }
        
    }
}
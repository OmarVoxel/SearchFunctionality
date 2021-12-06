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
        
    }
}
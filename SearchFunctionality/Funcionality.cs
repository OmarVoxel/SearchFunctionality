using System;
using System.Collections.Generic;

namespace SearchFunctionality
{
    public class Funcionality
    {
        private readonly string _search;
        private List<string> countryList = new List<string>()
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valencia",
            "Vancouver", "Amsterdam", "Vienna", "Sydney", "New York City",
            "London", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul"
        };

        public Funcionality(string search)
        {
            _search = search;
        }

        public string Search()
        {
            return "";
        }
    }
}

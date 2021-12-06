﻿using System;
using System.Collections.Generic;
using System.Linq;

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
            if (_search.Length > 1)
                return countryList.Where(x => x.ToLower().StartsWith(_search.ToLower())).Aggregate((a, b) => a + ", " + b);
            
            return null;
        }
    }
}

using System;
using System.Collections.Generic;

namespace MovieDatabase
{
    public class Movie
    {
        public string Name { get; }
        public string Genre { get; init; }
        private string[] _validGenres =
        {
            "Comic Book",
            "Comedy",
            "Action",
            "Romance",
            "Drama",
            "Musical"
        };
        public string Publisher { get; init; }
        public DateTime ReleaseDate { get; }
        public bool Watched { get; set; }
        public List<string> Actors;

        public Movie(string name, DateTime releaseDate)
        {
            Name = name;
            ReleaseDate = releaseDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace MovieDatabase
{
    //TODO More Genres
    //TODO Actors, move to a class with firstname, lastname, dateofbirth, more?
    public class Movie
    {
        public string Name { get; }
        public string Synopsis { get; set; }
        private string _genre;
        public string Genre
        {
            get => _genre;
            set
            {
                if (_validGenres.Contains(value)) 
                    _genre = value;
            }
        }
        private readonly string[] _validGenres =
        {
            "Comic Book",
            "Comedy",
            "Action",
            "Romance",
            "Drama",
            "Musical",
            "Animated"
        };
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; }
        public bool Watched { get; set; }
        public List<string> Actors = new();

        public Movie(string name, DateTime releaseDate)
        {
            Name = name;
            ReleaseDate = releaseDate;
        }
    }
}

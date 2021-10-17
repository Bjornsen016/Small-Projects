using System;
using MovieDatabase;
using Xunit;



namespace Tests
{
    public class MovieTests
    {
        private readonly string[] _movieNames = 
            {
                "Avengers: Endgame",
                "Avengers",
                "Avengers: Age of Ultron",
                "Thor: Ragnarok",
                "Iron Man",
                "Black Widow",
                "Avengers: Infinity War"
            };
        [Fact]
        public void Test_CreateMovie()
        {
            Movie movie = new Movie("Avengers: Endgame", new DateTime(2019,04,22));

            Assert.IsType<Movie>(movie);
        }

        [Theory]
        [InlineData("Avengers: Endgame")]
        [InlineData("Avengers")]
        [InlineData("Avengers: Age of Ultron")]
        [InlineData("Thor: Ragnarok")]
        [InlineData("Iron Man")]
        [InlineData("Black Widow")]
        [InlineData("Avengers: Infinity War")]
        public void Test_MovieNameAndReleaseDateCorrect(string name)
        {
            Movie movie = new Movie(name, new DateTime())
            {
                Publisher = "Marvel",
                Genre = "Comic Book"
            };

            Assert.Equal(name, movie.Name);
            Assert.Equal("Marvel", movie.Publisher);
            Assert.Equal("Comic Book", movie.Genre);
        }

        [Fact]
        public void Test_WatchedMovie()
        {
            Movie movie = new Movie(_movieNames[0], new DateTime(2019, 04, 22));

            bool notWatched = movie.Watched;
            movie.Watched = true;
            bool watched = movie.Watched;

            Assert.False(notWatched);
            Assert.True(watched);
        }

        [Fact]
        public void Test_ReleaseDateRegisterCorrect()
        {
            DateTime releaseDate = DateTime.Today;
            Movie movie = new Movie(_movieNames[0], releaseDate);

            Assert.Equal(releaseDate, movie.ReleaseDate);
        }

        [Theory]
        [InlineData("Tom Cruise")]
        [InlineData("Chris Pine")]
        [InlineData("Michael Jackson")]
        [InlineData("Rowan Aktinson")]
        public void Test_Actors(string actor)
        {
            Movie movie = new Movie("Mission Impossible", DateTime.Today);

            Assert.Empty(movie.Actors);

            movie.Actors.Add(actor);
            Assert.Single(movie.Actors);
        }

        [Theory]
        [InlineData("Comedy", true)]
        [InlineData("Action", true)]
        [InlineData("Boost", false)]
        [InlineData("acction", false)]
        [InlineData("Animated", true)]
        public void Test_Genres(string genre, bool valid)
        {
            Movie movie = new Movie("Mission Impossible", DateTime.Today)
            {
                Genre = genre
            };

            if (valid)
            {
                Assert.NotNull(movie.Genre);
            }
            else
            {
                Assert.Null(movie.Genre);
            }
        }
    }
}

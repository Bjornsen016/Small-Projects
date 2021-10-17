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
    }
}

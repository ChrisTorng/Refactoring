using System;
using Xunit;
using MovieRenter;

namespace MovieRenterLibTest
{
    public class MovieTest
    {
        [Fact]
        public void Constructor_Properties_Test()
        {
            var movie = new Movie("movie", Movie.Regular);

            Assert.Equal("movie", movie.Title);
        }
    }
}

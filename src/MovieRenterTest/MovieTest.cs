using System;
using Xunit;
using MovieRenter;

namespace MovieRenterTest
{
    public class MovieTest
    {
        [Fact]
        public void Constructor_Properties_Test()
        {
            var movie = new Movie("movie", Movie.Regular);

            Assert.Equals("movie", movie.Title);
        }
    }
}

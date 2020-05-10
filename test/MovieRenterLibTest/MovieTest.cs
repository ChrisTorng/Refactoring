using System;
using Xunit;
using MovieRenterLib;

namespace MovieRenterLibTest
{
    public class MovieTest
    {
        [Fact]
        public void Constructor_Properties_Test()
        {
            var movie = new Movie("movie", Movie.Regular);

            Assert.Equal("movie", movie.Title);
            Assert.Equal(Movie.Regular, movie.PriceType);
        }

        [Theory]
        [InlineData(null, Movie.Regular, typeof(ArgumentNullException))]
        [InlineData("", Movie.NewRelease, typeof(ArgumentException))]
        [InlineData(" ", Movie.Childrens, typeof(ArgumentException))]
        [InlineData("movie", (Movie.PriceTypeEnum)(-1), typeof(ArgumentOutOfRangeException))]
        public void Constructor_InvalidParameters_Test(
            string title, Movie.PriceTypeEnum priceType, Type exceptionType)
        {
            Assert.Throws(exceptionType, () =>
               new Movie(title, priceType));
        }
    }
}

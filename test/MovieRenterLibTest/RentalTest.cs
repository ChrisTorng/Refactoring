using System;
using Xunit;
using MovieRenterLib;

namespace MovieRenterLibTest
{
    public class RentalTest
    {
        private static Movie defaultMovie = new Movie("movie", Movie.Regular);

        public static TheoryData<Movie, int> validParameters =>
            new TheoryData<Movie, int>
            {
                { defaultMovie, 1 },
                { defaultMovie, 30 },
            };

        [Theory]
        [MemberData(nameof(validParameters))]
        public void Constructor_Properties_Test(
            Movie movie, int daysRented)
        {
            var rental = new Rental(movie, daysRented);

            Assert.Equal(movie, rental.Movie);
            Assert.Equal(daysRented, rental.DaysRented);
        }

        public static TheoryData<Movie, int, Type> invalidParameters =>
            new TheoryData<Movie, int, Type>
            {
                { null, 1, typeof(ArgumentNullException) },
                { defaultMovie, 0, typeof(ArgumentOutOfRangeException) },
                { defaultMovie, 31, typeof(ArgumentOutOfRangeException) },
            };

        [Theory]
        [MemberData(nameof(invalidParameters))]
        public void Constructor_InvalidParameters_Test(
            Movie movie, int daysRented, Type exceptionType)
        {
            Assert.Throws(exceptionType, () =>
               new Rental(movie, daysRented));
        }
    }
}

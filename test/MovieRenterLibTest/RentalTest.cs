using System;
using MovieRenterLib;
using Xunit;

namespace MovieRenterLibTest
{
    public class RentalTest
    {
        private static Movie defaultMovie = new Movie("movie", Movie.Regular);

        public static TheoryData<Movie, int> ValidParameters =>
            new TheoryData<Movie, int>
            {
                { defaultMovie, 1 },
                { defaultMovie, 30 },
            };

        [Theory]
        [MemberData(nameof(ValidParameters))]
        public void Constructor_Properties_Test(
            Movie movie, int daysRented)
        {
            var rental = new Rental(movie, daysRented);

            Assert.Equal(movie, rental.Movie);
            Assert.Equal(daysRented, rental.DaysRented);
        }

        public static TheoryData<Movie, int, Type> InvalidParameters =>
            new TheoryData<Movie, int, Type>
            {
                { null, 1, typeof(ArgumentNullException) },
                { defaultMovie, 0, typeof(ArgumentOutOfRangeException) },
                { defaultMovie, 31, typeof(ArgumentOutOfRangeException) },
            };

        [Theory]
        [MemberData(nameof(InvalidParameters))]
        public void Constructor_InvalidParameters_Test(
            Movie movie, int daysRented, Type exceptionType)
        {
            Assert.Throws(exceptionType, () =>
               new Rental(movie, daysRented));
        }
    }
}

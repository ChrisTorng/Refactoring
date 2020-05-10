using System;

namespace MovieRenterLib
{
    public class Rental
    {
        public Rental(Movie movie, int daysRented)
        {
            if (movie is null)
            {
                throw new ArgumentNullException(nameof(movie));
            }

            if (daysRented < 1 || daysRented > 30)
            {
                throw new ArgumentOutOfRangeException(nameof(daysRented));
            }

            Movie = movie;
            DaysRented = daysRented;
        }

        public Movie Movie { get; }
 
        public int DaysRented { get; }
    }
}
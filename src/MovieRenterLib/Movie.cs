using System;

namespace MovieRenterLib
{
    public class Movie
    {
        public enum PriceType
        {
            Regular,
            NewRelease,
            Childrens,
        }

        public const PriceType Regular = PriceType.Regular;
        public const PriceType NewRelease = PriceType.NewRelease;
        public const PriceType Childrens = PriceType.Childrens;

        public string Title { get; }

        public PriceType CurrentPriceType { get; }

        public Movie(string title, PriceType priceType)
        {
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("title is empty or white space", nameof(title));
            }

            if (!Enum.IsDefined(typeof(PriceType), priceType))
            {
                throw new ArgumentOutOfRangeException(nameof(priceType));
            }

            this.Title = title;
            this.CurrentPriceType = priceType;
        }
    }
}
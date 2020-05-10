using System;

namespace MovieRenterLib
{
    public class Movie
    {
        public enum PriceTypeEnum
        {
            Regular,
            NewRelease,
            Childrens
        }

        public const PriceTypeEnum Regular = PriceTypeEnum.Regular;
        public const PriceTypeEnum NewRelease = PriceTypeEnum.NewRelease;
        public const PriceTypeEnum Childrens = PriceTypeEnum.Childrens;

        public string Title { get; }

        public PriceTypeEnum PriceType { get; }

        public Movie(string title, PriceTypeEnum priceType)
        {
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("title is white space", nameof(title));
            }

            if (!Enum.IsDefined(typeof(PriceTypeEnum), priceType))
            {
                throw new ArgumentOutOfRangeException(nameof(priceType));
            }

            this.Title = title;
            this.PriceType = priceType;
        }
    }
}
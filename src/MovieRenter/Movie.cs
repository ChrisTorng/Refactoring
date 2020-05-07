namespace MovieRenter
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
            this.Title = title;
            this.PriceType = priceType;
        }
    }
}
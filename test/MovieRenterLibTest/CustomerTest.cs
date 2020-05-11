using System;
using Xunit;
using MovieRenterLib;

namespace MovieRenterLibTest
{
    public class CustomerTest
    {
        [Fact]
        public void Constructor_Properties_Test()
        {
            var customer = new Customer("customer");

            Assert.Equal("customer", customer.Name);
        }

        [Theory]
        [InlineData(null, typeof(ArgumentNullException))]
        [InlineData("", typeof(ArgumentException))]
        [InlineData(" ", typeof(ArgumentException))]
        public void Constructor_InvalidParameters_Test(
            string name, Type exceptionType)
        {
            Assert.Throws(exceptionType, () =>
               new Customer(name));
        }

        [Fact]
        public void AddRental_Null_Test()
        {
            var customer = new Customer("customer");

            Assert.Throws<ArgumentNullException>(() =>
                customer.AddRental(null));
        }
    }
}

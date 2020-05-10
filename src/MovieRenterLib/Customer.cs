using System.Collections.Generic;

namespace MovieRenterLib
{
    public class Customer
    {
        private List<Rental> rentals;
        
        public Customer(string name)
        {
            if (name == null)
            {
                throw new System.ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new System.ArgumentException("name is empty or white spaces", nameof(name));
            }
            
            this.Name = name;
            this.rentals = new List<Rental>();
        }

        public string Name { get; }

        public IReadOnlyCollection<Rental> Rentals { get; private set; }

        public void AddRental(Rental rental)
        {
            if (rental is null)
            {
                throw new System.ArgumentNullException(nameof(rental));
            }

            this.rentals.Add(rental);
            this.UpdateRentals();
        }

        private void UpdateRentals()
        {
            this.Rentals = this.rentals.AsReadOnly();
        }
    }
}
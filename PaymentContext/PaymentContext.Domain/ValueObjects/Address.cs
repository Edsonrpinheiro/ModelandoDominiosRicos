using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neigborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neigborhood = neigborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Street, 3, "Address.Street", "A rua deve conter pelo menos 3 caracteres")    
            );
        }

        public string Street { get; set; }
        public string Number { get; set; }
        public string Neigborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
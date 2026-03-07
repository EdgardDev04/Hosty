namespace Hosty.Domain.ValueObjects
{
    public record Address
    {
        public string Street { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public string Country { get; init; }
        public string PostalCode { get; init; }

        private Address(string street, string city, string state, string country, string postalCode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            PostalCode = postalCode;
        }

        public static Address Create(string street, string city, string state, string country, string postalCode)
        {
            if (string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("Address components cannot be empty.");
            }

            return new Address(street, city, state, country, postalCode);
        }
    }
}

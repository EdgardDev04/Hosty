using Hosty.Domain.Base;
using Hosty.Domain.ValueObjects;

namespace Hosty.Domain.Entities
{
    public class Hotel : BaseEntity
    {
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; private set; }
        public int StarRating { get; private set; }

        public Hotel() { }
    }
}

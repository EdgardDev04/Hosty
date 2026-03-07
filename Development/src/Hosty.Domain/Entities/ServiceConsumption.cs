using Hosty.Domain.Base;

namespace Hosty.Domain.Entities
{
    public class ServiceConsumption : BaseEntity
    {
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal TotalPrice { get; private set; }
        public DateTime ConsumedAt { get; private set; }
        public DateTime Date { get; private set; }

        public int StayId { get; private set; }
        public int ServiceId { get; private set; }

        public Stay Stay { get; private set; }
        public Service Service { get; private set; }
        public ServiceConsumption() { }
    }
}

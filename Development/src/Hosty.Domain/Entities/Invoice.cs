using Hosty.Domain.Base;
using Hosty.Domain.Enums;

namespace Hosty.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public decimal RoomCharges { get; private set; }
        public decimal ServiceCharges { get; private set; }
        public decimal Taxes { get; private set; }
        public decimal TotalAmount { get; private set; }
        public DateTime IssuedAt {  get; private set; }
        public InvoiceStatus Status { get; private set; }
        public int StayId { get; private set; }
        public Stay Stay { get; private set; }

        public Invoice() { }    
    }
}

using Hosty.Domain.Base;
using Hosty.Domain.Enums;

namespace Hosty.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; private set; }
        public string TransactionReference { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public PaymentStatus Status { get; private set; }
        public DateTime PaidAt { get; private set; }
        public int InvoiceId { get; private set; }
        public Invoice Invoice { get; private set; }
    }
}

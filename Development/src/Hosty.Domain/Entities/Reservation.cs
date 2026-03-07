using Hosty.Domain.Base;
using Hosty.Domain.Enums;

namespace Hosty.Domain.Entities
{
    public class Reservation : BaseEntity
    {
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }
        public int NumberOfGuests { get; private set; }
        public decimal TotalPrice { get; private set; }
        public string SpecialRequests { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? CancelledAt { get; private set; }
        public ReservationStatus Status {  get; private set; }

        public int GuestId { get; private set; }
        public int RoomId { get; private set; }

        public Guest Guest { get; private set; }
        public Room Room { get; private set; }

        public Reservation() { }
    }
}

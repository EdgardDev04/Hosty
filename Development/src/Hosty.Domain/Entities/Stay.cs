using Hosty.Domain.Base;
using Hosty.Domain.Enums;

namespace Hosty.Domain.Entities
{
    public class Stay : BaseEntity
    {
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate {  get; private set; }
        public StayStatus Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int RoomId { get; private set; }
        public int ReservationId { get; private set; }
        public Room Room { get; private set; }
        public Reservation Reservation { get; private set; }

        public Stay() { }
    }
}

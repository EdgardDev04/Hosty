using Hosty.Domain.Base;
using Hosty.Domain.Enums;

namespace Hosty.Domain.Entities
{
    public class Room : BaseEntity
    {
        public string Number { get; private set; }
        public int Floor { get; private set; }
        public RoomStatus Status { get; private set; }
        public int RoomTypeId { get; private set; }
        public RoomType RoomType { get; private set; }

        public Room() { }
    }
}

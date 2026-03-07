using Hosty.Domain.Base;

namespace Hosty.Domain.Entities
{
    public class RoomType : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Capacity { get; private set; }
        public decimal BasePricePerNight { get; private set; }
        public int Beds { get; private set; }
        public bool HasSeaView { get; private set; }
        public bool HasBalcony { get; private set; }

        public RoomType() { }
    }
}

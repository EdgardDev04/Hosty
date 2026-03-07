using Hosty.Domain.Base;

namespace Hosty.Domain.Entities
{
    public class Service : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Service() { }
    }
}

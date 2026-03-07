using Hosty.Domain.Base;
using Hosty.Domain.Enums;

namespace Hosty.Domain.Entities
{
    public class Guest : BaseEntity
    {
        public string FullName { get; private set; }
        public DocumentType TypeDocument {  get; private set; }
        public string Document {  get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Nationality { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Guest() { }

    }
}

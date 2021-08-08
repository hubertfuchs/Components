using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class Offer
    {
        public Guid Id { get; }
        public Guid AddressId { get; }
        public Guid NoteId { get; }

        public Offer()
            : this(Guid.NewGuid(), Guid.Empty)
        {
        }

        public Offer(Guid id, Guid addressId)
        {
            Id = id;
            AddressId = addressId;
        }
    }
}

using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class Invoice
    {
        public Guid Id { get; }
        public Guid AddressId { get; }

        public Invoice()
            : this(Guid.NewGuid(), Guid.Empty)
        {
        }

        public Invoice(Guid id, Guid addressId)
        {
            Id = id;
            AddressId = addressId;
        }
    }
}

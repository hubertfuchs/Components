using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class SalesOrder
    {
        public Guid Id { get; }
        public Guid AddressId { get; }

        public SalesOrder()
            : this(Guid.NewGuid(), Guid.Empty)
        {
        }

        public SalesOrder(Guid id, Guid addressId)
        {
            Id = id;
            AddressId = addressId;
        }
    }
}

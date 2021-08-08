using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class PurchaseOrder
    {
        public Guid Id { get; }
        public Guid SupplierId { get; }
        public Guid AddressId { get; }

        public PurchaseOrder()
            : this(Guid.NewGuid(), Guid.Empty, Guid.Empty)
        {
        }

        public PurchaseOrder(Guid id, Guid supplierId, Guid addressId)
        {
            Id = id;
            SupplierId = supplierId;
            AddressId = addressId;
        }
    }
}
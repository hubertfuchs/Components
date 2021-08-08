using System;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    [Entity]
    public class Customer
    {
        public Guid Id { get; }
        public Guid AddressId { get; }

        public Customer()
            : this( Guid.NewGuid(), Guid.Empty )
        {
        }

        public Customer( Guid id, Guid addressId )
        {
            Id = id;
            AddressId = addressId;
        }
    }
}

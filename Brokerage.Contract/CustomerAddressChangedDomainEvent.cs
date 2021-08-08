using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract
{
    public sealed class CustomerAddressChangedDomainEvent : IDomainEvent
    {
        public Guid CustomerId { get; private set; }
        public Guid ProjectManagerId { get; private set; }

        public CustomerAddressChangedDomainEvent( Guid customerId, Guid projectManagerId )
        {
            this.CustomerId = customerId;
            this.ProjectManagerId = projectManagerId;
        }
    }
}
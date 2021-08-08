using System;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract
{
    internal sealed class Customer
    {
        private readonly IEventAggregator _eventAggregator;

        public Guid Id { get; private set; }
        public Guid ProjectManagerId { get; private set; }
        //private 

        public Customer(
            IEventAggregator eventAggregator )
        {
            _eventAggregator = eventAggregator;

            GenerateBarcodeCommandMessage commandMessage = new GenerateBarcodeCommandMessage("");
        }
    }
}
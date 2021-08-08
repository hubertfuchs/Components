using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract
{
    public interface IEventAggregator
    {
        IDisposable Subscribe<T>( Action<T> callback ) where T : IDomainEvent;
        void Publish<T>( T args ) where T : IMessage;
    }
}

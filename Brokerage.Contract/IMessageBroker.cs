using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract
{
    public interface IMessageBroker
    {
        void Subscribe<TMessage>( Action<TMessage> callback );
        void Subscribe<TMessage>( Action<TMessage> callback, Func<TMessage, bool> filter );
        void Publish<TMessage>( TMessage message );
    }
}


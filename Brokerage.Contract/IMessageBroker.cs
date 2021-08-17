using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract
{
    public interface IMessageBroker
    {
        void Subscribe<T>(Action<T> callback) where T : IMessage;
        void Subscribe<T>(Action<T> callback, Func<T, bool> filter) where T : IMessage;
        void Publish<T>(T message) where T : IMessage;
    }
}

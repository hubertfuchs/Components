using System;
using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.CrossCutting.Brokerage.MessageBroker
{
    [EventAggregator]
    public class MessageBroker : IMessageBroker
    {
        private readonly Dictionary<Type, List<Delegate>> _subscriptions;

        public MessageBroker()
        {
            _subscriptions = new Dictionary<Type, List<Delegate>>();
        }

        public void Subscribe<TMessage>(Action<TMessage> callback) where TMessage : IMessage
        {
            var messageType = typeof(TMessage);

            if (!_subscriptions.ContainsKey(messageType))
            {
                _subscriptions[messageType] = new List<Delegate>();
            }

            _subscriptions[messageType].Add(callback);
        }

        public void Subscribe<TMessage>(Action<TMessage> callback, Func<TMessage, bool> filter) where TMessage : IMessage
        {
        }

        public void Publish<TMessage>(TMessage message) where TMessage : IMessage
        {
            var messageType = typeof(TMessage);

            var hasHandler = _subscriptions.ContainsKey(messageType) && _subscriptions[messageType].Count > 0;
            if (!hasHandler)
            {
                return;
            }

            foreach (var callback in _subscriptions[messageType])
            {
                callback.DynamicInvoke(message);
            }
        }
    }
}

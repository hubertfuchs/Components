using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.Exceptions
{
    [Serializable]
    public class BrokerageException : Exception
    {
        public BrokerageException()
        {
        }

        public BrokerageException( string message)
            : base(message)
        {
        }

        public BrokerageException( string message, Exception inner)
            : base(message, inner)
        {
        }

        protected BrokerageException( SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

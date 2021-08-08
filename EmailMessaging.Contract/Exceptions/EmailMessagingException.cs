using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.CrossCutting.EmailMessaging.Contract.Exceptions
{
    [Serializable]
    public class EmailMessagingException : Exception
    {
        public EmailMessagingException()
        {
        }

        public EmailMessagingException( string message )
            : base( message )
        {
        }

        public EmailMessagingException( string message, Exception inner )
            : base( message, inner )
        {
        }

        protected EmailMessagingException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }
    }
}

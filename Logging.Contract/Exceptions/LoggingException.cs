using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.CrossCutting.Logging.Contract.Exceptions
{
    [Serializable]
    public class LoggingException : Exception
    {
        public LoggingException()
        {
        }
        
        public LoggingException( string message ) 
            : base( message )
        {
        }

        public LoggingException( string message, Exception inner ) 
            : base( message, inner )
        {
        }

        protected LoggingException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }
    }
}

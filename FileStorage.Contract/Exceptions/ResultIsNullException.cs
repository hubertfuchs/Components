using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Data.FileStorage.Contract.Exceptions
{
    [Serializable]
    public class ResultIsNullException : FileStorageException
    {
        public ResultIsNullException()
        {
        }

        public ResultIsNullException(string message)
            : base(message)
        {
        }

        public ResultIsNullException(string message, Type resultType)
        {
            // TODO: wie und wo resultType verarbeiten?        
        }

        public ResultIsNullException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected ResultIsNullException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

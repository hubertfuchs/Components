using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Data.FileStorage.Contract.Exceptions
{
    [Serializable]
    public class FileStorageException : Exception
    {
        public FileStorageException()
        {
        }

        public FileStorageException( string message )
            : base( message )
        {
        }

        public FileStorageException( string message, Exception inner )
            : base( message, inner )
        {
        }

        protected FileStorageException( SerializationInfo info, StreamingContext context ) 
            : base( info, context )
        {
        }
    }
}

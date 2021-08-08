using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Logic.SalesManagement.Contract.Exceptions
{
    [Serializable]
    public class SalesManagementException : Exception
    {
        public SalesManagementException()
        {
        }

        public SalesManagementException( string message )
            : base( message )
        {
        }

        public SalesManagementException( string message, Exception inner )
            : base( message, inner )
        {
        }

        protected SalesManagementException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }
    }
}

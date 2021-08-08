using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Logic.SecurityManagement.Contract.Exceptions
{
    [Serializable]
    public class UserAccountManagementException : Exception
    {
        public UserAccountManagementException()
        {
        }

        public UserAccountManagementException( string message )
            : base( message )
        {
        }

        public UserAccountManagementException( string message, Exception inner )
            : base( message, inner )
        {
        }

        protected UserAccountManagementException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }
    }
}

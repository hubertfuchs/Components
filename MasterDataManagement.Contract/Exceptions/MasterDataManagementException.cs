using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Logic.MasterDataManagement.Contract.Exceptions
{
    [Serializable]
    public class MasterDataManagementException : Exception
    {
        public MasterDataManagementException()
        {
        }

        public MasterDataManagementException( string message )
            : base( message )
        {
        }

        public MasterDataManagementException( string message, Exception inner )
            : base( message, inner )
        {
        }

        protected MasterDataManagementException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }
    }
}

using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Logic.SecurityWorkflows.Contract.Exceptions
{
    [Serializable]
    public class SecurityWorkflowsException : Exception
    {
        public SecurityWorkflowsException()
        {
        }

        public SecurityWorkflowsException( string message )
            : base( message )
        {
        }

        public SecurityWorkflowsException( string message, Exception inner )
            : base( message, inner )
        {
        }

        protected SecurityWorkflowsException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }
    }
}

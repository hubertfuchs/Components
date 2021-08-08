using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Logic.ProjectManagement.Contract.Exceptions
{
    [Serializable]
    public class ProjectManagementException : Exception
    {
        public ProjectManagementException()
        {
        }

        public ProjectManagementException( string message ) 
            : base( message )
        {
        }

        public ProjectManagementException( string message, Exception inner ) 
            : base( message, inner )
        {
        }

        protected ProjectManagementException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }
    }
}

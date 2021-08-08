using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Logic.ProjectWorkflows.Contract.Exceptions
{
    [Serializable]
    public class ProjectWorkflowsException : Exception
    {
        public ProjectWorkflowsException()
        {
        }

        public ProjectWorkflowsException( string message )
            : base( message )
        {
        }

        public ProjectWorkflowsException( string message, Exception inner )
            : base( message, inner )
        {
        }

        protected ProjectWorkflowsException( SerializationInfo info, StreamingContext context )
            : base( info, context )
        {
        }
    }
}

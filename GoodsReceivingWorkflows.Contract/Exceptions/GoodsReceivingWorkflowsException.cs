using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Logic.GoodsReceivingWorkflows.Contract.Exceptions
{
    [Serializable]
    public class GoodsReceivingWorkflowsException : Exception
    {
        public GoodsReceivingWorkflowsException()
        {
        }

        public GoodsReceivingWorkflowsException(string message) 
            : base(message)
        {
        }

        public GoodsReceivingWorkflowsException(string message, Exception inner) 
            : base(message, inner)
        {
        }

        protected GoodsReceivingWorkflowsException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}

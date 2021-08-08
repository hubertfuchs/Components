using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Logic.GoodsReceivingManagement.Contract.Exceptions
{
    [Serializable]
    public class GoodsReceivingManagementException : Exception
    {
        public GoodsReceivingManagementException()
        {
        }

        public GoodsReceivingManagementException(string message)
            : base(message)
        {
        }

        public GoodsReceivingManagementException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected GoodsReceivingManagementException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

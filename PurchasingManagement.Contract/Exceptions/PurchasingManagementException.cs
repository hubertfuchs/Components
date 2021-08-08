using System;
using System.Runtime.Serialization;

namespace Fuchsbau.Components.Logic.PurchasingManagement.Contract.Exceptions
{
    [Serializable]
    public class PurchasingManagementException : Exception
    {
        public PurchasingManagementException()
        {
        }

        public PurchasingManagementException(string message)
            : base(message)
        {
        }

        public PurchasingManagementException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected PurchasingManagementException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}

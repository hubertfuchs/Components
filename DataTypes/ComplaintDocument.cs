using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class ComplaintDocument : DocumentBase
    {
        public uint PurchaseOrderNumber { get; set; }

        public ComplaintDocument()
        {
        }

        public ComplaintDocument(Guid id)
            : base(id)
        {
        }
    }
}
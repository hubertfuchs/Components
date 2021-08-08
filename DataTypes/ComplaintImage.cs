using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class ComplaintImage : ImageBase
    {
        public uint PurchaseOrderNumber { get; set; }

        public ComplaintImage()
        {
        }

        public ComplaintImage(Guid id)
            : base(id)
        {
        }
    }
}
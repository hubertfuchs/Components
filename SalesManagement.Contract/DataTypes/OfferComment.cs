using System;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.SalesManagement.Contract.DataTypes
{
    public class OfferComment : Comment
    {
        public Guid OfferId { get; set; }

        public OfferComment()
        {
        }
    }
}

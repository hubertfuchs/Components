using System;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.SalesManagement.Contract.DataTypes
{
    public class OfferItemComment : Comment
    {
        public Guid OfferItemId { get; set; }

        public OfferItemComment()
        {
        }
    }
}

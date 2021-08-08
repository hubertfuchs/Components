using System;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    [Entity]
    public class Address
    {
        public Guid Id { get; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        protected Address()
            : this( Guid.NewGuid() )
        {
        }

        protected Address( Guid id )
        {
            Id = id;
        }
    }
}

using System;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    [Entity]
    public class Project
    {
        /// <summary>
        /// Internal identifier.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// External number.
        /// </summary>
        public uint Number { get; set; }

        public string Description { get; set; }

        public Project()
            : this( Guid.NewGuid() )
        {
        }

        public Project( Guid id )
        {
            Id = id;
        }
    }
}

using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class Role
    {
        public Guid Id { get; }
        public string Name { get; }

        public Role( string name )
            : this( Guid.NewGuid(), name )
        {
        }

        public Role( Guid id, string name )
        {
            Id = id;
            Name = name;
        }
    }
}

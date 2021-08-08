using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class Right
    {
        public Guid Id { get; }
        public string Name { get; }

        public Right( string name )
            : this( Guid.NewGuid(), name )
        {
        }

        public Right( Guid id, string name )
        {
            Id = id;
            Name = name;
        }
    }
}

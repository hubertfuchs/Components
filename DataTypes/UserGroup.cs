using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class UserGroup
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public UserGroup()
            : this( Guid.NewGuid() )
        {
        }

        public UserGroup( Guid id )
        {
            Id = id;
        }
    }
}
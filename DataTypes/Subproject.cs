using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class Subproject
    {
        /// <summary>
        /// Internal identifier.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Internal project identifier.
        /// </summary>
        public Guid ProjectId { get; }

        /// <summary>
        /// External number.
        /// </summary>
        public uint Number { get; set; }

        public string Description { get; set; }

        public Subproject()
            : this( Guid.NewGuid(), Guid.Empty )
        {
        }

        public Subproject( Guid id, Guid projectId )
        {
            Id = id;
            ProjectId = projectId;
        }
    }
}

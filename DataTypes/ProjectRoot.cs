using System;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    [AggregateRoot]
    public class ProjectRoot
    {
        public Guid Id { get; }
        public string Timestamp { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;

        public ProjectRoot()
            : this(Guid.NewGuid())
        {
        }

        public ProjectRoot(Guid id)
        {
            Id = id;
        }
    }
}
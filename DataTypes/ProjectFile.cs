using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class ProjectFile
    {
        public Guid Id { get; }
        public string Path { get; set; }
        public string Name { get; set; }

        protected ProjectFile()
            : this(Guid.NewGuid())
        {
        }

        protected ProjectFile(Guid id)
        {
            Id = id;
        }
    }
}
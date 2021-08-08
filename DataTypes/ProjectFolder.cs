using System;
using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    [Entity]
    public class ProjectFolder
    {
        public Guid Id { get; }
        public Guid ParentId { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
        public string HashValue { get; set; } = string.Empty;
        public string Mapping { get; set; } = string.Empty;
        public bool ReadOnly { get; set; }
        public List<ProjectFolder> ProjectFolders { get; set; }

        public ProjectFolder()
            : this(Guid.NewGuid())
        {
        }

        public ProjectFolder(Guid id)
        {
            Id = id;
        }
    }
}
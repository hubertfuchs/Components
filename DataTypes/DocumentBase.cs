using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public abstract class DocumentBase
    {
        public Guid Id { get; }
        public string Path { get; set; }
        public string File { get; set; }

        protected DocumentBase()
            : this(Guid.NewGuid())
        {
        }

        protected DocumentBase(Guid id)
        {
            Id = id;
        }
    }
}
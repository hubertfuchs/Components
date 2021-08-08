using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public abstract class ImageBase
    {
        public Guid Id { get; }
        public string Path { get; set; }
        public string File { get; set; }

        protected ImageBase()
            : this(Guid.NewGuid())
        {
        }

        protected ImageBase(Guid id)
        {
            Id = id;
        }
    }
}
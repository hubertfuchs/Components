using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class Supplier
    {
        public Guid Id { get; }
        public string Name { get; }

        public Supplier()
            : this(Guid.NewGuid(), string.Empty)
        {
        }

        public Supplier(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
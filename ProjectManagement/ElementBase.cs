using System;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.Logic.ProjectManagement
{
    [Component]
    public abstract class ElementBase<T>
    {
        public Guid Id { get; }
        public abstract bool IsComposite { get; }
        public abstract T ParentObject { get; protected set; }

        protected ElementBase()
            : this(Guid.NewGuid())
        {
        }

        protected ElementBase(Guid id)
        {
            Id = id;
        }

        public virtual void Add(T projectElement)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(T projectElement)
        {
            throw new NotImplementedException();
        }

        public abstract string GetPath();
    }
}
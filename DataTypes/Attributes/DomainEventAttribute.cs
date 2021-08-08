using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes.Attributes
{
    [AttributeUsage( AttributeTargets.Class )]
    public class DomainEventAttribute : Attribute
    {
        public DomainEventAttribute()
        {
        }
    }
}

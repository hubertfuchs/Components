using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes.Attributes
{
    [AttributeUsage( AttributeTargets.Class )]
    public class AggregateRootAttribute : Attribute
    {
        public AggregateRootAttribute()
        {
        }
    }
}

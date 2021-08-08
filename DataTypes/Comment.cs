using System;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    [Entity]
    public class Comment : ModelBase
    {
        public Guid Id { get; }
        public string Text { get; set; }

        public Comment()
        {

        }
    }
}

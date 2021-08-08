using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public class Note : ModelBase
    {
        public Guid Id { get; }
        public string Text { get; set; }

        public Note()
        {

        }
    }
}

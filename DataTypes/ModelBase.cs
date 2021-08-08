using System;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public abstract class ModelBase
    {
        public string Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public string Editor { get; set; }
        public DateTime ModificationDate { get; set; }

        protected ModelBase()
        {
        }
    }
}

using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public abstract class MessageBase
    {
        public Guid Id { get; }

        protected MessageBase()
        {
            Id = Guid.NewGuid();
        }
    }
}

using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class NewImageEventMessage : MessageBase, IMessage
    {
        public Guid Id { get; }

        public NewImageEventMessage()
        {
            Id = Guid.NewGuid();
        }
    }
}

using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class NewGroupLabelEventMessage : MessageBase, IMessage
    {
        public Guid Id { get; }

        public NewGroupLabelEventMessage()
        {
            Id = Guid.NewGuid();
        }
    }
}

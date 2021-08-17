using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class ActivateOnlineModeCommandMessage : MessageBase, IMessage
    {
        public Guid Id { get; }

        public ActivateOnlineModeCommandMessage()
        {
            Id = Guid.NewGuid();
        }
    }
}
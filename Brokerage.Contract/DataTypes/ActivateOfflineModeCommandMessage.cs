using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class ActivateOfflineModeCommandMessage : MessageBase, IMessage
    {
        public Guid Id { get; }
        
        public ActivateOfflineModeCommandMessage()
        {
            Id = Guid.NewGuid();
        }
    }
}
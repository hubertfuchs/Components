using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class UserLoginEventMessage : MessageBase, IMessage
    {
        public Guid Id { get; }

        public UserLoginEventMessage()
        {
            Id = Guid.NewGuid();
        }
    }
}

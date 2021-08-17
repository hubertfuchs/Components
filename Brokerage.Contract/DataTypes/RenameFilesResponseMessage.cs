using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class RenameFilesResponseMessage : MessageBase, IMessage
    {
        public Guid Id { get; }

        public RenameFilesResponseMessage()
        {
            Id = Guid.NewGuid();
        }
    }
}
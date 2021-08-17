using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class RenameFilesRequestMessage : MessageBase, IMessage
    {
        public Guid Id { get; }
        public string[] Files { get; }
        public string FileNameFormat { get; }

        public RenameFilesRequestMessage(string[] files, string fileNameFormat)
        {
            Id = Guid.NewGuid();
            Files = files;
            FileNameFormat = fileNameFormat;
        }
    }
}
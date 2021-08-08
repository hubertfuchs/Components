namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class RenameFilesRequestMessage : MessageBase
    {
        public string[] Files { get; }
        public string FileNameFormat { get; }

        public RenameFilesRequestMessage(string[] files, string fileNameFormat)
        {
            Files = files;
            FileNameFormat = fileNameFormat;
        }
    }
}
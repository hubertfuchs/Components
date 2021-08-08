namespace Fuchsbau.Components.Data.FileStorage.FileTransfer
{
    public interface IFileTransferClient
    {
        void Connect();
        void Login();
        void Upload( string localPath, string remoteDirectoryPath );
        void Upload(byte[] data, string remotePath);
        void Upload( string basePath, string includePattern, string excludePattern, string remoteDirectoryPath );
        void Download( string remotePath, string localDirectoryPath );
        void Download( string basePath, string includePattern, string excludePattern, string localDirectoryPath );
    }
}

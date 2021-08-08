namespace Fuchsbau.Components.Data.FileStorage.FileTransfer
{
    public class DataItem
    {
        private readonly string _remoteFilePath;
        private readonly string _localPath;

        public string RemoteFilePath => _remoteFilePath;
        public string LocalPath => _localPath;
        public bool IsReceived { get; set; }

        public DataItem( string remoteFilePath, string localPath)
        {
            _remoteFilePath = remoteFilePath;
            _localPath = localPath;;
        }
    }
}
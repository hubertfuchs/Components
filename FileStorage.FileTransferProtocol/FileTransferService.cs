using System;
using System.Text;

namespace Fuchsbau.Components.Data.FileStorage.FileTransfer
{
    public class FileTransferService  : IService
    {
        private IFileTransferClient _client;
                                                                           

        public FileTransferService( 
            IFileTransferClient fileTransferClient )
        {
            _client = fileTransferClient;
        }

        public void DownloadDataContainer(DataContainer dataContainer)
        {
            _client.Connect();
            _client.Login();

            foreach (var item in dataContainer.Items)
            {
                _client.Download(item.RemoteFilePath, item.LocalPath);
            }
        }
    }
}

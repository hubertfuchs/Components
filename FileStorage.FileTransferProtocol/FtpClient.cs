using System;
using System.IO;
using Rebex.IO;
using Rebex.Net;

namespace Fuchsbau.Components.Data.FileStorage.FileTransfer
{
    public class FtpClient : IFileTransferClient
    {
        private readonly Ftp _ftp;
        private string _serverName;
        private int _serverPort;
        private string _userName;
        private string _password;

        public bool IsConnected => _ftp.IsConnected;
        public bool IsAuthenticated => _ftp.IsAuthenticated;
        public bool IsSecured => _ftp.IsSecured;
        public bool IsBusy => _ftp.IsBusy;

        private FtpClient()
        {
            _ftp = new Ftp();
        }

        public FtpClient( string userName, string password, string serverName = "localhost", int serverPort = 21 ) 
            : this()
        {
            _userName = userName ?? throw new ArgumentNullException(nameof(userName));
            _password = password ?? throw new ArgumentNullException(nameof(password));
            _serverName = serverName ?? throw new ArgumentNullException(nameof(serverName));
            _serverPort = serverPort;
        }

        public void Connect()
        {
            _ftp.Connect( _serverName, _serverPort );
        }

        public void Login()
        {
            _ftp.Login( _userName, _password );
        }

        public bool FileExists( string remotePath )
        {
            return _ftp.FileExists( remotePath );
        }

        public void Upload( string localPath, string remoteDirectoryPath )
        {
            if( string.IsNullOrWhiteSpace( remoteDirectoryPath ) )
            {
                remoteDirectoryPath = @"\";
            }

            _ftp.Upload( localPath, remoteDirectoryPath );
        }

        public void Upload(byte[] data, string remotePath)
        {
            if( string.IsNullOrWhiteSpace( remotePath ) )
            {
                remotePath = @"\";
            }

            using( MemoryStream stream = new MemoryStream( data ) )
            {
                _ftp.PutFile( stream, remotePath );
            }

        }

        public void Upload( string basePath, string includePattern, string excludePattern, string remoteDirectoryPath )
        {
            var fileSet = CreateFileSet( basePath, includePattern, excludePattern );

            _ftp.Upload( fileSet, remoteDirectoryPath );
        }

        public void Download( string remotePath, string localDirectoryPath )
        {
            if( string.IsNullOrWhiteSpace( remotePath ) )
            {
                remotePath = @"\";
            }

            _ftp.Download( remotePath, localDirectoryPath );
        }

        public void Download( string basePath, string includePattern, string excludePattern, string localDirectoryPath )
        {
            var fileSet = CreateFileSet( basePath, includePattern, excludePattern );

            _ftp.Download( fileSet, localDirectoryPath );
        }

        private FileSet CreateFileSet( string basePath, string includePattern, string excludePattern )
        {
            var fileSet = new FileSet( basePath );
            fileSet.Include( includePattern );
            fileSet.Exclude( excludePattern );
            return fileSet;
        }
    }
}

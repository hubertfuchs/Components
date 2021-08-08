using System;
using System.IO;
using Rebex.IO;
using Rebex.Net;

namespace Fuchsbau.Components.Data.FileStorage.FileTransfer
{
    public class SftpClient : IFileTransferClient
    {           
        private readonly Sftp _sftp;
        private readonly string _serverName;
        private readonly int _serverPort;
        private readonly string _userName;
        private readonly string _password;

        public bool IsConnected => _sftp.IsConnected;
        public bool IsAuthenticated => _sftp.IsAuthenticated;

        private SftpClient()
        {
            _sftp = new Sftp();
        }

        public SftpClient( string userName, string password, string serverName = "localhost", int serverPort = 22 )
            : this()
        {
            _userName = userName ?? throw new ArgumentNullException( nameof( userName ) );
            _password = password ?? throw new ArgumentNullException( nameof( password ) );
            _serverName = serverName ?? throw new ArgumentNullException( nameof( serverName ) );
            _serverPort = serverPort;
        }

        public void Connect()
        {
            
            _sftp.Connect( _serverName, _serverPort );

            //_sftp.Login();
            _sftp.DirectoryExists( "/" );
            _sftp.FileExists( "/" );

        }

        public void Login()
        {
            _sftp.Login( _userName, _password );
        }

        public bool FileExists( string remotePath )
        {
            return _sftp.FileExists( remotePath );
        }

        public void Upload( string localPath, string remoteDirectoryPath )
        {
            if( string.IsNullOrWhiteSpace( remoteDirectoryPath ) )
            {
                remoteDirectoryPath = @"\";
            }

            _sftp.Upload( localPath, remoteDirectoryPath );
        }

        public void Upload( byte[] data, string remotePath )
        {
            using( var stream = new MemoryStream( data ) )
            {
                _sftp.PutFile(stream, remotePath);
            }
        }

        public void Upload( string basePath, string includePattern, string excludePattern, string remoteDirectoryPath )
        {
            var fileSet = CreateFileSet( basePath, includePattern, excludePattern );

            _sftp.Upload( fileSet, remoteDirectoryPath );
        }

        public void Download( string remotePath, string localDirectoryPath )
        {
            if( string.IsNullOrWhiteSpace( remotePath ) )
            {
                remotePath = @"\";
            }

            _sftp.Download( remotePath, localDirectoryPath );
        }

        public void Download( string basePath, string includePattern, string excludePattern, string localDirectoryPath )
        {
            var fileSet = CreateFileSet( basePath, includePattern, excludePattern );

            _sftp.Download( fileSet, localDirectoryPath );
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

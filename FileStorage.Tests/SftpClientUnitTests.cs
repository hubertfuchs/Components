using System.IO;
using Fuchsbau.Components.Data.FileStorage.FileTransfer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fuchsbau.Components.Data.FileStorage.Tests
{
    [TestClass]
    public class SftpClientUnitTests
    {
        private SftpClient _sftpClient;
        private const string SERVER_NAME = "localhost";
        private const int SERVER_PORT = 22;
        private const string USER_NAME = "sftpfuchs";
        private const string PASSWORD = "sftptest";

        [TestInitialize]
        public void Initialize()
        {
            Rebex.Licensing.Key = "==AAXcOyxVxKGmVZuXrKBhABzdgniFNj16dwS0hWngLPqQ==";

            _sftpClient = new SftpClient( USER_NAME, PASSWORD );
        }

        [TestCleanup]
        public void Cleanup()
        {
            string localPath = @"C:\Temp\FileTransfer\Local\";

            string sftpDownloadFile = @"SftpClient_Download_FileDoesNotExists_FileDoesExists.UnitTest";

            if( File.Exists( localPath + sftpDownloadFile ) )
            {
                File.Delete( localPath + sftpDownloadFile );
            }

            string sftpServerPath = @"C:\Temp\FileTransfer\Sftp\";
            string sftpUploadFile = "SftpClient_Upload_FileDoesNotExists_FileDoesExists.UnitTest";

            if( File.Exists( sftpServerPath + sftpUploadFile ) )
            {
                File.Delete( sftpServerPath + sftpUploadFile );
            }
        }

        [TestMethod]
        public void Connect_ClientIsNotConnected_ClientIsConnected()
        {
            

            bool isConnectedBefore = _sftpClient.IsConnected;
            _sftpClient.Connect();
            bool isConnectedAfter = _sftpClient.IsConnected;

            Assert.IsFalse( isConnectedBefore, "Client is connected before executing connect methode!" );
            Assert.IsTrue( isConnectedAfter, "Client is disconnect after executing connect methode!" );
        }

        [TestMethod]
        public void Login_ClientIsNotAuthenticated_ClientIsAuthenticated()
        {
            _sftpClient.Connect();

            bool isAuthenticatedBefore = _sftpClient.IsAuthenticated;
            _sftpClient.Login();
            bool isAuthenticatedAfter = _sftpClient.IsAuthenticated;

            Assert.IsFalse( isAuthenticatedBefore, "Client is authenticated before executing login methode!" );
            Assert.IsTrue( isAuthenticatedAfter, "Client is not authenticated after executing login methode!" );
        }

        [TestMethod]
        public void Upload_FileDoesNotExists_FileDoesExists()
        {
            string localPath = @"C:\Temp\FileTransfer\Local\SftpClient_Upload_FileDoesNotExists_FileDoesExists.UnitTest";
            string remoteDirectoryPath = @"/";
            string remotePath = @"/blablabla/SftpClient_Upload_FileDoesNotExists_FileDoesExists.UnitTest";

            _sftpClient.Connect();
            _sftpClient.Login();

            bool fileExistsBefore = _sftpClient.FileExists( remotePath );
            _sftpClient.Upload( localPath, remoteDirectoryPath );
            bool fileExistsAfter = _sftpClient.FileExists( remotePath );

            //Assert.IsFalse( fileExistsBefore, "File existed before executing upload methode!" );
            //Assert.IsTrue( fileExistsAfter, "File does not existed after executing upload methode!" );
        }

        [TestMethod]
        public void Download_FileDoesNotExists_FileDoesExists()
        {
            string remotePath = @"/Neue Bitmap.bmp";
            string localDirectoryPath = @"C:\Temp\FileTransfer\Local\testtesttest";
            string checkLocalPath = @"C:\Temp\FileTransfer\Local\SftpClient_Download_FileDoesNotExists_FileDoesExists.UnitTest";

            _sftpClient.Connect();
            _sftpClient.Login();

            bool fileExistsBefore = File.Exists( checkLocalPath );
            _sftpClient.Download( remotePath, localDirectoryPath );
            bool fileExistsAfter = File.Exists( checkLocalPath );

            //Assert.IsFalse( fileExistsBefore, "File existed before executing download methode!" );
           // Assert.IsTrue( fileExistsAfter, "File does not existed after executing download methode!" );
        }

        [TestMethod]
        public void Upload_y_y()
        {
            string localPath = @"C:\Temp\FileTransfer\Local\Programm - Developer Week.pdf";

            _sftpClient.Connect();
            _sftpClient.Login();

            using( var fileStream = File.OpenRead( localPath ) )
            {
                var bytes = new byte[ fileStream.Length ];
                fileStream.Read( bytes, 0, bytes.Length );
                _sftpClient.Upload( bytes, "/ProgrammDeveloperWeek.pdf" );
            }
        }
    }
}
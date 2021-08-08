using System.IO;
using Fuchsbau.Components.Data.FileStorage.FileTransfer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fuchsbau.Components.Data.FileStorage.Tests
{
    [TestClass]
    public class FtpClientUnitTests
    {
        private FtpClient _ftpClient;
        private const string SERVER_NAME = "localhost";
        private const int SERVER_PORT = 21;
        private const string USER_NAME = "ftpfuchs";
        private const string PASSWORD = "ftptest";

        [TestInitialize]
        public void Initialize()
        {
            Rebex.Licensing.Key = "==AAXcOyxVxKGmVZuXrKBhABzdgniFNj16dwS0hWngLPqQ==";

            _ftpClient = new FtpClient( USER_NAME, PASSWORD );
        }

        [TestCleanup]
        public void Cleanup()
        {
            string localPath = @"C:\Temp\FileTransfer\Local\";

            string ftpDownloadFile = @"FtpClient_Download_FileDoesNotExists_FileDoesExists.UnitTest";

            if( File.Exists( localPath + ftpDownloadFile ) )
            {
                File.Delete( localPath + ftpDownloadFile );
            }

            string ftpServerPath = @"C:\Temp\FileTransfer\Ftp\";
            string ftpUploadFile = "FtpClient_Upload_FileDoesNotExists_FileDoesExists.UnitTest";

            if( File.Exists( ftpServerPath + ftpUploadFile ) )
            {
                File.Delete( ftpServerPath + ftpUploadFile );
            }
        }

        [TestMethod]
        public void Connect_ClientIsNotConnected_ClientIsConnected()
        {
            bool isConnectedBefore = _ftpClient.IsConnected;
            _ftpClient.Connect();
            bool isConnectedAfter = _ftpClient.IsConnected;

            Assert.IsFalse( isConnectedBefore, "Client is connected before connect methode is executed!" );
            Assert.IsTrue( isConnectedAfter, "Clinet is disconnected after connect methode is executed!" );
        }

        [TestMethod]
        public void Login_ClientIsNotAuthenticated_ClientIsAuthenticated()
        {
            _ftpClient.Connect();

            bool isAuthenticatedBefore = _ftpClient.IsAuthenticated;
            _ftpClient.Login();
            bool isAuthenticatedAfter = _ftpClient.IsAuthenticated;

            Assert.IsFalse( isAuthenticatedBefore, "Client is authenticated before executing login methode!" );
            Assert.IsTrue( isAuthenticatedAfter, "Client is not authenticated after executing login methode!" );
        }

        [TestMethod]
        public void Upload_FileDoesNotExists_FileDoesExists()
        {
            string localPath = @"C:\Temp\FileTransfer\Local\FtpClient_Upload_FileDoesNotExists_FileDoesExists.UnitTest";
            string remoteDirectoryPath = string.Empty;
            string checkRemotePath = @"\FtpClient_Upload_FileDoesNotExists_FileDoesExists.UnitTest";

            _ftpClient.Connect();
            _ftpClient.Login();

            bool fileExistsBefore = _ftpClient.FileExists( checkRemotePath );
            _ftpClient.Upload( localPath, remoteDirectoryPath );
            bool fileExistsAfter = _ftpClient.FileExists( checkRemotePath );

            Assert.IsFalse( fileExistsBefore, "File existed before executing upload methode!" );
            Assert.IsTrue( fileExistsAfter, "File does not existed after executing upload methode!" );
        }

        [TestMethod]
        public void Upload_y_y()
        {
            string localPath = @"C:\Temp\FileTransfer\Local\Programm - Developer Week.pdf";

            _ftpClient.Connect();
            _ftpClient.Login();

            using( var fileStream = File.OpenRead( localPath ) )
            {
                var bytes = new byte[ fileStream.Length ];
                fileStream.Read( bytes, 0, bytes.Length );
                _ftpClient.Upload( bytes, "/ProgrammDeveloperWeek.pdf" );
            }
        }

        [TestMethod]
        public void Upload_x_x()
        {
            _ftpClient.Connect();
            _ftpClient.Login();

            _ftpClient.Upload( basePath: @"C:\Temp", includePattern: "*.txt", excludePattern: "*.tmp", remoteDirectoryPath: @"\" );
        }

        [TestMethod]
        public void Download_FileDoesNotExists_FileDoesExists()
        {
            string remotePath = string.Empty;
            string localDirectoryPath = @"C:\Temp\FileTransfer\Local";
            string checkLocalPath = @"C:\Temp\FileTransfer\Local\FtpClient_Download_FileDoesNotExists_FileDoesExists.UnitTest";

            _ftpClient.Connect();
            _ftpClient.Login();

            bool fileExistsBefore = File.Exists( checkLocalPath );
            _ftpClient.Download( remotePath, localDirectoryPath );
            bool fileExistsAfter = File.Exists( checkLocalPath );

            Assert.IsFalse( fileExistsBefore, "File existed before executing download methode!" );
            Assert.IsTrue( fileExistsAfter, "File does not existed after executing download methode!" );
        }

        [TestMethod]
        public void Download_x_x()
        {
            _ftpClient.Connect();
            _ftpClient.Login();

            _ftpClient.Download( basePath: "", includePattern: "A.*", excludePattern: "*.tmp", localDirectoryPath: @"C:\Temp" );
        }
    }
}

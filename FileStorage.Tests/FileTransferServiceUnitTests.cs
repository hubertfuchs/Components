using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuchsbau.Components.Data.FileStorage.FileTransfer;
using Moq;

namespace Fuchsbau.Components.Data.FileStorage.Tests
{
    [TestClass]
    public class FileTransferServiceUnitTests
    {
        [TestMethod]
        public void DownloadDataContainer_ContainerElementMitEinerTextdatei_DownloadTextdateiErfolgreich()
        {
            var fileTransferClientMock = new Mock<IFileTransferClient>(); 
            var dataContainer = new DataContainer();
            var dataItem = new DataItem(remoteFilePath: "/datei.txt", localPath: @"C:\");
            dataContainer.Items.Add(dataItem);
            
            
            
            var sut = new FileTransferService( fileTransferClientMock.Object );



            

            sut.DownloadDataContainer(dataContainer);


            //Assert.IsTrue();

        }
    }
}

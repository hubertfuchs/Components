using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.Logic.GoodsReceivingManagement.Contract;
using Fuchsbau.Components.CrossCutting.Configuration.Contract;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes;

namespace Fuchsbau.Components.Logic.GoodsReceivingWorkflows.Tests
{
    [TestClass]
    public class ComplaintWorkflowUnitTests
    {
        private const uint PURCHASE_ORDER_NUMBER = 1210001;

        [TestMethod]
        public void RenameDocumentFiles_x_y()
        {
        }

        [TestMethod]
        public void SendEmail_x_y()
        {
            var loggerMock = new Mock<ILogger>();
            var eventAggregatorMock = new Mock<IMessageBroker>();
            var configurationMock = new Mock<IConfiguration>();
            var complaintImageManagerMock = new Mock<IComplaintImageManager>();
            var documentGeneratorMock = new Mock<IDocumentGenerator>();
            var complaintDocumentManagerMock = new Mock<IComplaintDocumentManager>();

            string[] logfile = new string[] { };

            loggerMock
                .Setup(x => x.Log(It.IsAny<string>(), It.IsAny<LogLevel>()))
                .Callback((string text, LogLevel level) => { logfile.Append($"{level} {text}"); });

            SendEmailCommandMessage commandMessage = null;

            eventAggregatorMock
                .Setup(x => x.Publish(It.IsAny<SendEmailCommandMessage>()))
                .Callback((SendEmailCommandMessage message) => { commandMessage = message; });

            configurationMock
                .Setup(x => x.Get<string>("Purchasing", "ComplaintEmailAddress"))
                .Returns("mustermann@beispiel.de");

            ComplaintImage image = new ComplaintImage()
            {
                PurchaseOrderNumber = PURCHASE_ORDER_NUMBER,
                Path = @"C:\Temp",
                File = @"beispiel.jpg",
            };

            IQueryable<ComplaintImage> images = (new List<ComplaintImage>() {image}).AsQueryable();

            complaintImageManagerMock
                .Setup(x => x.GetAll())
                .Returns(images);

            ComplaintDocument document = new ComplaintDocument()
            {
                PurchaseOrderNumber = PURCHASE_ORDER_NUMBER,
                Path = @"C:\Temp",
                File = @"beispiel.pdf",
            };

            documentGeneratorMock
                .Setup(x => x.Generate(It.IsAny<ComplaintImage>()))
                .Returns(document);

            IQueryable<ComplaintDocument> documents = (new List<ComplaintDocument>() {document}).AsQueryable();

            complaintDocumentManagerMock
                .Setup(x => x.GetAll())
                .Returns(documents);

            var sut = new ComplaintWorkflow(
                loggerMock.Object,
                eventAggregatorMock.Object,
                configurationMock.Object,
                complaintImageManagerMock.Object,
                documentGeneratorMock.Object,
                complaintDocumentManagerMock.Object);

            sut.MergeUserInputAndTemplate("testX1X2X3");

            _ = sut.SendEmail(PURCHASE_ORDER_NUMBER);

            Thread.Sleep(5000);

            Assert.IsTrue(commandMessage != null, "");
            Assert.IsTrue(commandMessage.EmailAddressTo == "mustermann@beispiel.de", "");
            Assert.IsTrue(commandMessage.EmailSubject != string.Empty, "");
            Assert.IsTrue(commandMessage.EmailBody.Contains("testX1X2X3"), "");
            Assert.IsTrue(commandMessage.EmailAttachments.Count() == 1, "");
        }
    }
}

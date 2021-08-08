using System.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.EmailMessaging.Contract;

namespace Fuchsbau.Components.CrossCutting.EmailMessaging.Tests
{
    [TestClass]
    public class DotNetEmailSenderUnitTests
    {
        private readonly IEmailSender _emailSender;
        private readonly MailMessage _mailMessage;

        public DotNetEmailSenderUnitTests()
        {
            var messageBrokerMock = new Mock<IMessageBroker>();

            _emailSender = new DotNetEmailSender( messageBrokerMock.Object );

            _mailMessage = new MailMessage
            {
                IsBodyHtml = true,
                Subject = "test message",
                Body = "<html><head><title></title></head><body><h1>title</h1>content</body></html>",
                From = new MailAddress( "mustermann@beispiel.de", "Unit Test" ),
            };

            _mailMessage.To.Add( "mustermann@beispiel.de" );
        }

        [TestMethod]
        public void Send_PreCondition1_PostCondition1()
        {
            _emailSender.Send(
                subject: _mailMessage.Subject,
                plainTextBody: "title\n\ncontent",
                fromAddress: _mailMessage.From.Address,
                toAddress: _mailMessage.To[ 0 ].Address );
        }

        [TestMethod]
        public void Send_PreCondition2_PostCondition2()
        {
            _emailSender.Send( _mailMessage );
        }
    }
}

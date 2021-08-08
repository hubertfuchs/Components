using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes;
using Fuchsbau.Components.CrossCutting.EmailMessaging.Contract;

namespace Fuchsbau.Components.CrossCutting.EmailMessaging
{
    public class DotNetEmailSender : EmailSenderBase, IEmailSender
    {
        private readonly IMessageBroker _messageBroker;
        private readonly SmtpClient _smtpClient;

        public DotNetEmailSender(
            IMessageBroker messageBroker )
        {
            _messageBroker = messageBroker ?? throw new ArgumentNullException( nameof( messageBroker ) );

            _messageBroker.Subscribe<NewBarcodeEventMessage>(NewBarcodeCallback);
            _messageBroker.Subscribe<SendEmailCommandMessage>(SendEmailCallback);

            _smtpClient = new SmtpClient
            {
                Port = 587,
                Host = "smtp.beispiel.de",
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential( "mustermann@beispiel.de", "0815" ),
                DeliveryMethod = SmtpDeliveryMethod.Network,
            };
        }

        public void Send( MailMessage mailMessage )
        {
            if( mailMessage == null )
            {
                throw new ArgumentNullException( nameof( mailMessage ) );
            }

            _smtpClient.Send( mailMessage );
        }

        public void Send( string subject, string plainTextBody, string fromAddress, string toAddress )
        {
            #region check parameters for null
            if( subject == null )
            {
                throw new ArgumentNullException( nameof( subject ) );
            }

            if( plainTextBody == null )
            {
                throw new ArgumentNullException( nameof( plainTextBody ) );
            }

            if( fromAddress == null )
            {
                throw new ArgumentNullException( nameof( fromAddress ) );
            }

            if( toAddress == null )
            {
                throw new ArgumentNullException( nameof( toAddress ) );
            }
            #endregion

            var fromMailAddress = new MailAddress( fromAddress );
            var toMailAddresses = new[] { new MailAddress( toAddress ) };

            MailMessage mailMessage = CreateEmailMessage( subject, plainTextBody, fromMailAddress, toMailAddresses );

            _smtpClient.Send( mailMessage );
        }

        private void SendEmailCallback( SendEmailCommandMessage message )
        {
            //_smtpClient.Send(CreateEmailMessage(message.EmailSubject,message.EmailBody,new MailAddress(),new []{}));
        }

        private void NewBarcodeCallback( NewBarcodeEventMessage message )
        {
            if( message == null )
            {
                throw new ArgumentNullException( nameof( message ) );
            }

            Bitmap barcodeImage = message.BarcodeImage;
            string barcodeText = message.BarcodeText;

            base.IsBodyHtml = true;

            string subject = "new barcode";
            string htmlBody = @$"<html><head></head><body><h1>{barcodeText}</h1><br />{barcodeImage}</body></html>";

            var fromMailAddress = new MailAddress( "mustermann@beispiel.de" );
            var toMailAddresses = new[] { new MailAddress( "mustermann@beispiel.de" ) };

            MailMessage mailMessage =
                CreateEmailMessage( subject, htmlBody, fromMailAddress, toMailAddresses, null, null, null );

            var memoryStream = new MemoryStream();
            barcodeImage.Save( memoryStream, ImageFormat.Bmp );

            var attachment = new Attachment( memoryStream, "image/png" );
            mailMessage.Attachments.Add( attachment );

            _smtpClient.Send( mailMessage );
        }
    }
}

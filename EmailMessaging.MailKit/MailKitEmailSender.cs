using System;
using System.Net.Mail;
using Fuchsbau.Components.CrossCutting.EmailMessaging.Contract;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Fuchsbau.Components.CrossCutting.EmailMessaging.MailKit
{
    public class MailKitEmailSender : EmailSenderBase, IEmailSender
    {
        private readonly SmtpClient _smtpClient;

        public void Send(MailMessage mailMessage)
        {
            throw new NotImplementedException();
        }

        public void Send(string subject, string plainTextBody, string fromAddress, string toAddress)
        {
            throw new NotImplementedException();
        }
    }
}

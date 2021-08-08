using System.Net.Mail;

namespace Fuchsbau.Components.CrossCutting.EmailMessaging.Contract
{
    public interface IEmailSender
    {
        void Send( MailMessage mailMessage );
        void Send( string subject, string plainTextBody, string fromAddress, string toAddress );
    }
}

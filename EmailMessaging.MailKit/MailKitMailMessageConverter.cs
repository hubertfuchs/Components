using System.Net.Mail;
using MimeKit;
using Fuchsbau.Components.CrossCutting.EmailMessaging.Contract;

namespace Fuchsbau.Components.CrossCutting.EmailMessaging.MailKit
{
    public class MailKitMailMessageConverter : IMailMessageConverter<MimeMessage>
    {
        public MimeMessage Convert( MailMessage emailMessage )
        {
            MimeMessage mimeMessage = new MimeMessage()
            {
                Subject = emailMessage.Subject,
            };

            return mimeMessage;
        }

        public MailMessage Convert( MimeMessage emailMessage )
        {
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress( "" ),
                Subject = emailMessage.Subject,
                Body = "",
            };

            mailMessage.To.Add( new MailAddress( "" ) );

            return mailMessage;
        }
    }
}

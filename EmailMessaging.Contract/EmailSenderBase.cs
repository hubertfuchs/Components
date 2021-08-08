using System;
using System.Net.Mail;

namespace Fuchsbau.Components.CrossCutting.EmailMessaging.Contract
{
    public abstract class EmailSenderBase
    {
        protected bool IsBodyHtml { get; set; } = false;

        protected MailMessage CreateEmailMessage( string subject, string body, MailAddress fromMailAddress, MailAddress[] toMailAddresses,
            MailAddress[] ccMailAddresses = null, MailAddress[] bccMailAddresses = null, Attachment[] attachments = null )
        {
            #region check parameters for null
            if( subject == null )
            {
                throw new ArgumentNullException( nameof( subject ) );
            }

            if( body == null )
            {
                throw new ArgumentNullException( nameof( body ) );
            }

            if( fromMailAddress == null )
            {
                throw new ArgumentNullException( nameof( fromMailAddress ) );
            }

            if( toMailAddresses == null )
            {
                throw new ArgumentNullException( nameof( toMailAddresses ) );
            }
            #endregion

            var mailMessage = new MailMessage
            {
                Subject = subject,
                Body = body,
                From = fromMailAddress,
                IsBodyHtml = this.IsBodyHtml,
            };

            foreach( var toMailAddress in toMailAddresses )
            {
                mailMessage.To.Add( toMailAddress );
            }

            if( ccMailAddresses != null )
            {
                foreach( var ccMailAddress in ccMailAddresses )
                {
                    mailMessage.CC.Add( ccMailAddress );
                }
            }

            if( bccMailAddresses != null )
            {
                foreach( var bccMailAddress in bccMailAddresses )
                {
                    mailMessage.Bcc.Add( bccMailAddress );
                }
            }

            if( attachments != null )
            {
                foreach( var attachment in attachments )
                {
                    mailMessage.Attachments.Add( attachment );
                }
            }

            return mailMessage;
        }
    }
}

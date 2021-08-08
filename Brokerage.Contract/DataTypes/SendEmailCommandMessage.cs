using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class SendEmailCommandMessage : MessageBase
    {
        public string EmailAddressTo { get; }
        public string EmailBody { get; }
        public string EmailSubject { get; }
        public string[] EmailAttachments { get; }

        public SendEmailCommandMessage(string emailAddressTo, string emailSubject, string emailBody, string[] emailAttachments)
        {
            EmailAddressTo = emailAddressTo ?? throw new ArgumentNullException(nameof(emailAddressTo));
            EmailSubject = emailSubject ?? throw new ArgumentNullException(nameof(emailSubject));
            EmailBody = emailBody ?? throw new ArgumentNullException(nameof(emailBody));
            EmailAttachments = emailAttachments ?? throw new ArgumentNullException(nameof(emailAttachments));
        }
    }
}
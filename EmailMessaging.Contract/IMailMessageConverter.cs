using System.Net.Mail;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.CrossCutting.EmailMessaging.Contract
{
    public interface IMailMessageConverter<TExternalMessage> : IConverter<MailMessage, TExternalMessage>
    {
        MailMessage Convert( TExternalMessage emailMessage );
    }
}

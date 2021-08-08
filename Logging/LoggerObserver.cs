using System;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Logging
{
    [Observer]
    public class LoggerObserver : IObserver
    {
        private readonly IMessageBroker _messageBroker;

        public LoggerObserver(
            IMessageBroker messageBroker )
        {
            _messageBroker = messageBroker ?? throw new ArgumentNullException( nameof( messageBroker ) );
        }

        public void Update<T>( T param )
        {
            if( param is LogLine logLine )
            {
                switch( logLine.Level )
                {
                    case LogLevel.Critical:
                        // TODO: send email to IT by IEmailSender
                        break;

                    case LogLevel.Warning:
                        // TODO: 
                        break;

                    case LogLevel.None:
                        // TODO: "LogLevel.None darf nicht zum Schreiben von Protokollmeldungen verwendet werden!"
                        break;

                    default:

                        break;
                }
            }
        }
    }
}

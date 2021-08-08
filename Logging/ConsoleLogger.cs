using System;
using System.Threading.Tasks;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Logging
{
    public class ConsoleLogger : SubjectBase, ILogger
    {
        private readonly LogLevel _minLevel;

        public ConsoleLogger( LogLevel minLevel = LogLevel.Information )
        {
            _minLevel = minLevel;
        }

        public void Log( string text, LogLevel level = LogLevel.Information )
        {
            if( level < _minLevel )
            {
                return;
            }

            var logLine = new LogLine( DateTime.Now, level, text );

            Console.WriteLine( logLine );

            Publish( logLine );
        }

        public async Task LogAsync( string text, LogLevel level = LogLevel.Information )
        {
            await Task.Run( () => Log( text, level ) ).ConfigureAwait( false );
        }
    }
}

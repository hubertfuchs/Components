using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Logging
{
    public class DebugLogger : SubjectBase, ILogger
    {
        private readonly LogLevel _minLevel;

        public DebugLogger( LogLevel minLevel = LogLevel.Trace )
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

            Debug.WriteLine( logLine.ToString() );

            Publish( logLine );
        }

        public async Task LogAsync( string text, LogLevel logLevel = LogLevel.Information )
        {
            await Task.Run( () => Log( text, logLevel ) ).ConfigureAwait( false );
        }
    }
}
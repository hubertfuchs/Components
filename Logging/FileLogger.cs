using System;
using System.IO;
using System.Threading.Tasks;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Logging
{
    public class FileLogger : SubjectBase, ILogger
    {
        private readonly string _fileWithPath;
        private readonly LogLevel _minLevel;

        public FileLogger( string fileWithPath, LogLevel minLevel = LogLevel.Information )
        {
            _fileWithPath = fileWithPath ?? throw new ArgumentNullException( nameof( fileWithPath ) );
            _minLevel = minLevel;
        }

        public void Log( string text, LogLevel level = LogLevel.Information )
        {
            if( level < _minLevel )
            {
                return;
            }

            var logLine = new LogLine( DateTime.Now, level, text );

            File.WriteAllText( _fileWithPath, logLine.ToString() );

            Publish( logLine );
        }

        public async Task LogAsync( string text, LogLevel level = LogLevel.Information )
        {
            if( level < _minLevel )
            {
                return;
            }

            var logLine = new LogLine( DateTime.Now, level, text );

            await File.WriteAllTextAsync( _fileWithPath, logLine.ToString() ).ConfigureAwait( false );

            Publish( logLine );
        }
    }
}

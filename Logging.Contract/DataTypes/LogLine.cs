using System;

namespace Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes
{
    public class LogLine
    {
        public DateTime DateTime { get; }
        public LogLevel Level { get; }
        public string Text { get; }

        public LogLine( DateTime dateTime, LogLevel level, string text )
        {
            DateTime = dateTime;
            Level = level;
            Text = text ?? throw new ArgumentNullException( nameof( text ) );
        }

        public override string ToString()
        {
            string level = $"[{Level.ToString().ToUpper()}]";

            return $"{DateTime} {level,-13}| {Text}";
        }
    }
}
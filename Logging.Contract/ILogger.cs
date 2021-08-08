using System.Threading.Tasks;
using Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Logging.Contract
{
    public interface ILogger
    {
        void Log( string text, LogLevel level = LogLevel.Information );
        Task LogAsync( string text, LogLevel level = LogLevel.Information );
    }
}

using Fuchsbau.Components.CrossCutting.Brokerage.MessageBroker;
using Fuchsbau.Components.CrossCutting.Logging.Contract.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fuchsbau.Components.CrossCutting.Logging.Tests
{
    [TestClass]
    public class TestedClassUnitTests
    {
        [TestMethod]
        public void TestedMethod_ExpectedResult()
        {
            var messageBroker = new MessageBroker();
            var loggerObserver = new LoggerObserver( messageBroker );
            var debugLogger = new DebugLogger( LogLevel.Trace );
            var consoleLogger = new ConsoleLogger( LogLevel.Trace );

            debugLogger.Subscribe( loggerObserver );
            consoleLogger.Subscribe( loggerObserver );

            debugLogger.Log( "DL Test 1" );
            debugLogger.Log( "DL Test 2", LogLevel.Trace );
            debugLogger.Log( "DL Test 3", LogLevel.Critical );
            debugLogger.Log( "DL Test 4", LogLevel.None );

            consoleLogger.Log( "CL Test 1" );
            consoleLogger.Log( "CL Test 2", LogLevel.Warning );
            consoleLogger.Log( "CL Test 3", LogLevel.Critical );
            consoleLogger.Log( "CL Test 4", LogLevel.None );
        }

        [TestMethod]
        public void TestedMethod_blabla()
        {

        }
    }
}

using Fuchsbau.Components.CrossCutting.Core.Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fuchsbau.Components.CrossCutting.Core.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod()
        {
            var userInterfaceFactory = new ConsoleUserInterfaceFactory();

            var executionMain = new UserLoginFormExecutionMain( userInterfaceFactory );

            executionMain.Run();
        }
    }
}

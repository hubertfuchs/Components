using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuchsbau.Components.CrossCutting.Brokerage.MessageBroker;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.Logging;

namespace Fuchsbau.Components.Logic.ProjectManagement.Tests
{
    [TestClass]
    public class QrCodeBarcodeGeneratorUnitTests
    {
        [TestMethod]
        public void Generate_xxx_yyy()
        {
            var logger = new ConsoleLogger();
            var messageBroker = new MessageBroker();
            string text = "http://www.beispiel.de";

            var sut = new QrCodeBarcodeGenerator(logger, messageBroker);

            Barcode barcode = sut.Generate(text);

            Assert.IsTrue(barcode.Text == text, "...");
        }
    }
}

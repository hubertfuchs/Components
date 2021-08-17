using System;
using System.Drawing;
using Net.Codecrete.QrCodeGenerator;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;
using Fuchsbau.Components.CrossCutting.Logging.Contract;
using Fuchsbau.Components.Logic.ProjectManagement.Contract;

namespace Fuchsbau.Components.Logic.ProjectManagement
{
    [Adapter]
    public class QrCodeBarcodeGenerator : IBarcodeGenerator
    {
        private readonly ILogger _logger;
        private readonly IMessageBroker _eventAggregator;
        private QrCode _qrCode;

        private const int BITMAP_SCALE = 4;
        private const int BITMAP_BORDER = 5;

        public QrCodeBarcodeGenerator(
            ILogger logger,
            IMessageBroker eventAggregator)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _eventAggregator = eventAggregator ?? throw new ArgumentNullException(nameof(eventAggregator));

            _eventAggregator.Subscribe<GenerateBarcodeCommandMessage>(GenerateBarcodeCallback);
        }

        public Barcode Generate(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            _qrCode = QrCode.EncodeText(text, QrCode.Ecc.High);

            Bitmap image = _qrCode.ToBitmap(BITMAP_SCALE, BITMAP_BORDER);
            Barcode barcode = new Barcode(text, image);

            return barcode;
        }

        private void GenerateBarcodeCallback(GenerateBarcodeCommandMessage message)
        {
            Barcode barcode = Generate(message.DataContent);
            NewBarcodeEventMessage eventMessage = new NewBarcodeEventMessage(barcode);
            _eventAggregator.Publish(eventMessage);
        }
    }
}

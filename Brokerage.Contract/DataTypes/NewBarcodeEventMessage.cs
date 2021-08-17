using System;
using System.Drawing;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class NewBarcodeEventMessage : MessageBase, IMessage
    {
        private readonly Barcode _barcode;

        public Guid Id { get; }
        public Bitmap BarcodeImage => _barcode.Image;
        public string BarcodeText => _barcode.Text;

        public NewBarcodeEventMessage(Barcode barcode)
        {
            Id = Guid.NewGuid();

            _barcode = barcode ?? throw new ArgumentNullException(nameof(barcode));
        }
    }
}

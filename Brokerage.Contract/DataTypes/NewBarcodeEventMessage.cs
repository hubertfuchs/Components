using System;
using System.Drawing;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class NewBarcodeEventMessage : MessageBase
    {
        private readonly Barcode _barcode;

        public Bitmap BarcodeImage => _barcode.Image;
        public string BarcodeText => _barcode.Text;

        public NewBarcodeEventMessage( Barcode barcode )
        {
            _barcode = barcode ?? throw new ArgumentNullException( nameof( barcode ) );
        }
    }
}

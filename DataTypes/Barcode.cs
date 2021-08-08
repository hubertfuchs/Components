using System;
using System.Drawing;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    [ValueObject]
    public class Barcode
    {
        /// <summary>
        /// Data content of the barcode.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Bitmap image of the barcode.
        /// </summary>
        public Bitmap Image { get; }

        public Barcode(string text, Bitmap image)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            Image = image ?? throw new ArgumentNullException(nameof(image));
        }
    }
}

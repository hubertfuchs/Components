using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class GenerateBarcodeCommandMessage : MessageBase
    {
        private readonly string _dataContent;

        public string DataContent => _dataContent;

        public GenerateBarcodeCommandMessage( string dataContent )
        {
            _dataContent = dataContent ?? throw new ArgumentNullException( nameof( dataContent ) );
        }
    }
}

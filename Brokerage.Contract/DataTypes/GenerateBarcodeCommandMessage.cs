using System;

namespace Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes
{
    public class GenerateBarcodeCommandMessage : MessageBase, IMessage
    {
        private readonly string _dataContent;

        public Guid Id { get; }
        public string DataContent => _dataContent;

        public GenerateBarcodeCommandMessage(string dataContent)
        {
            Id = Guid.NewGuid();

            _dataContent = dataContent ?? throw new ArgumentNullException(nameof(dataContent));
        }
    }
}

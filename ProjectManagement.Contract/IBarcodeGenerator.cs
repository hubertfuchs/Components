using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.ProjectManagement.Contract
{
    public interface IBarcodeGenerator
    {
        Barcode Generate( string text );
    }
}

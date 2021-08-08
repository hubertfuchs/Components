using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.GoodsReceivingManagement.Contract
{
    public interface IDocumentGenerator
    {
        DocumentBase Generate(ImageBase image);
    }
}
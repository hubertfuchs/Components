using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.PurchasingManagement.Contract
{
    public interface IPurchaseOrderManager : IManager<PurchaseOrder>
    {
        PurchaseOrder Get(uint purchaseOrderNumber);
    }
}

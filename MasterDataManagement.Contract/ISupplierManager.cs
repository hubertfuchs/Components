using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.MasterDataManagement.Contract
{
    public interface ISupplierManager : IManager<Supplier>
    {
        Supplier Get( uint supplierNumber );
    }
}
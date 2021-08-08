using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Logic.MasterDataManagement.Contract;

namespace Fuchsbau.Components.Logic.MasterDataManagement
{
    public class SupplierManager : ISupplierManager
    {
        public SupplierManager()
        {
                
        }

        public void Add(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Supplier> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public void Update(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(uint supplierNumber)
        {
            throw new NotImplementedException();
        }
    }
}
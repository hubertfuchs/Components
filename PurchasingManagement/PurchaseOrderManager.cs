using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Logic.PurchasingManagement.Contract;

namespace Fuchsbau.Components.Logic.PurchasingManagement
{
    public class PurchaseOrderManager : IPurchaseOrderManager
    {
        public PurchaseOrderManager()
        {
            
        }

        public void Add(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public PurchaseOrder Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PurchaseOrder> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public void Update(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public PurchaseOrder Get(uint purchaseOrderNumber)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private readonly SalesContext _context;

        public SalesOrderRepository(
            SalesContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(SalesOrder salesOrder)
        {
            _context.SalesOrders.Remove(salesOrder);
        }

        public void Insert(SalesOrder salesOrder)
        {
            _context.SalesOrders.Add(salesOrder);
        }

        public IQueryable<SalesOrder> Query()
        {
            return _context.SalesOrders.AsQueryable();
        }

        public void Update(SalesOrder salesOrder)
        {
            _context.SalesOrders.Update(salesOrder);
        }
    }
}

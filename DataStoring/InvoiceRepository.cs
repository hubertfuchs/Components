using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly SalesContext _context;

        public InvoiceRepository(
            SalesContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(Invoice invoice)
        {
            _context.Invoices.Remove(invoice);
        }

        public void Insert(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
        }

        public IQueryable<Invoice> Query()
        {
            return _context.Invoices.AsQueryable();
        }

        public void Update(Invoice invoice)
        {
            _context.Update(invoice);
        }
    }
}

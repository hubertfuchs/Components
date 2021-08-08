using Microsoft.EntityFrameworkCore;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.Data.DataStoring.EF.Contexts
{
    [UnitOfWork]
    public class SalesContext : DbContext, IUnitOfWork
    {
        public DbSet<Offer> Offers { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}

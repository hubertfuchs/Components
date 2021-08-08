using Microsoft.EntityFrameworkCore;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.Data.DataStoring.EF.Contexts
{
    [UnitOfWork]
    public class GoodsReceivingContext : DbContext, IUnitOfWork
    {
        public DbSet<ComplaintImage> ComplaintImages { get; set; }
    }
}
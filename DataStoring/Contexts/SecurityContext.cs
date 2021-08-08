using Microsoft.EntityFrameworkCore;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.Data.DataStoring.EF.Contexts
{
    [UnitOfWork]
    public class SecurityContext : DbContext, IUnitOfWork
    {
        public DbSet<User> Users { get; set; } 
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Right> Rights { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
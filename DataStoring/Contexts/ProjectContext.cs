using Microsoft.EntityFrameworkCore;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;

namespace Fuchsbau.Components.Data.DataStoring.EF.Contexts
{
    [UnitOfWork]
    public class ProjectContext : DbContext, IUnitOfWork
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Subproject> Subprojects { get; set; }
        public DbSet<ProjectFile> ProjectFiles { get; set; }
    }
}
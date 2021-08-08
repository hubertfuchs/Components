using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ProjectContext _context;

        public ProjectRepository(
            ProjectContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(Project project)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public void Insert(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public IQueryable<Project> Query()
        {
            return _context.Projects.AsQueryable();
        }

        public void Update(Project project)
        {
            _context.Update(project);
            _context.SaveChanges();
        }
    }
}

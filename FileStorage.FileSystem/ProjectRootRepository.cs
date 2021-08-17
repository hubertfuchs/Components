using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contexts;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    public class ProjectRootRepository : IProjectRootRepository
    {
        private readonly ProjectContext _context;

        public ProjectRootRepository(
            ProjectContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(ProjectRoot projectRoot)
        {
            _context.ProjectRoots.Remove(projectRoot);
            _context.SaveChanges();
        }

        public void Insert(ProjectRoot projectRoot)
        {
            _context.ProjectRoots.Add(projectRoot);
            _context.SaveChanges();
        }

        public IQueryable<ProjectRoot> Query()
        {
            return _context.ProjectRoots.AsQueryable();
        }

        public void Update(ProjectRoot projectRoot)
        {
            _context.ProjectRoots.Update(projectRoot);
            _context.SaveChanges();
        }
    }
}
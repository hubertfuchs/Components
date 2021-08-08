using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contexts;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    public class ProjectRootDirectoryRepository : IProjectRootDirectoryRepository
    {
        private readonly ProjectContext _context;

        public ProjectRootDirectoryRepository(
            ProjectContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(ProjectRoot projectRootDirectory)
        {
            _context.ProjectRoots.Remove(projectRootDirectory);
            _context.SaveChanges();
        }

        public void Insert(ProjectRoot projectRootDirectory)
        {
            _context.ProjectRoots.Add(projectRootDirectory);
            _context.SaveChanges();
        }

        public IQueryable<ProjectRoot> Query()
        {
            _context.LoadData();

            return _context.ProjectRoots.AsQueryable();
        }

        public void Update(ProjectRoot projectRootDirectory)
        {
            _context.Update(projectRootDirectory);
            _context.SaveChanges();
        }
    }
}
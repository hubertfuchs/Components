using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contexts;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    internal class ProjectFolderRepository : IProjectFolderRepository
    {
        private readonly ProjectContext _context;

        public ProjectFolderRepository( 
            ProjectContext context )
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(ProjectFolder projectFolder)
        {
            _context.ProjectFolders.Remove(projectFolder);
            _context.SaveChanges();
        }

        public void Insert(ProjectFolder projectFolder)
        {
            _context.ProjectFolders.Add(projectFolder);
            _context.SaveChanges();
        }

        public IQueryable<ProjectFolder> Query()
        {
            _context.LoadData();

            return _context.ProjectFolders.AsQueryable();
        }

        public void Update(ProjectFolder projectFolder)
        {
            _context.Update(projectFolder);
            _context.SaveChanges();
        }
    }
}
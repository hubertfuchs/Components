using System;
using System.Linq;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class ProjectFileRepository //: IProjectFileRepository
    {
        private readonly ProjectContext _context;

        public ProjectFileRepository(
            ProjectContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // public void Delete( ProjectFile projectFile )
        // {
        //     _context.ProjectImages.Remove(projectFile);
        // }
        // 
        // public void Insert( ProjectFile projectFile )
        // {
        //     _context.ProjectImages.Add(projectFile);
        // }
        // 
        // public IQueryable<ProjectFile> Query()
        // {
        //     return _context.ProjectImages.AsQueryable();
        // }
        // 
        // public void Update( ProjectFile projectFile )
        // {
        //     _context.Update(projectFile);
        // }
    }
}

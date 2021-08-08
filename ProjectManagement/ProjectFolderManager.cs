using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contract;
using Fuchsbau.Components.Logic.ProjectManagement.Contract;

namespace Fuchsbau.Components.Logic.ProjectManagement
{
    public class ProjectFolderManager : IProjectFolderManager
    {
        private IProjectFolderRepository _projectFolderRepository;

        public ProjectFolderManager(
            IProjectFolderRepository projectFolderRepository)
        {
            _projectFolderRepository = projectFolderRepository ?? throw new ArgumentNullException(nameof(projectFolderRepository));
        }

        public void Add(ProjectFolder projectFolder)
        {
            _projectFolderRepository.Insert(projectFolder);
        }

        public ProjectFolder Get(Guid id)
        {
            return _projectFolderRepository.Query().Single(x => x.Id == id);
        }

        public IQueryable<ProjectFolder> GetAll()
        {
            return _projectFolderRepository.Query();
        }

        public void Remove(ProjectFolder projectFolder)
        {
            _projectFolderRepository.Delete(projectFolder);
        }

        public void Update(ProjectFolder projectFolder)
        {
            _projectFolderRepository.Update(projectFolder);
        }

        public IQueryable<ProjectFolder> GetAllByRootDirectoryId(Guid rootDirectoryId)
        {
            return _projectFolderRepository.Query().Where(x => x.ParentId == rootDirectoryId);
        }
    }
}
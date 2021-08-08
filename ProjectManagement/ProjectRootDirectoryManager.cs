using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contract;
using Fuchsbau.Components.Logic.ProjectManagement.Contract;

namespace Fuchsbau.Components.Logic.ProjectManagement
{
    public class ProjectRootDirectoryManager : IProjectRootDirectoryManager
    {
        private IProjectRootDirectoryRepository _projectRootDirectoryRepository;

        public ProjectRootDirectoryManager(
            IProjectRootDirectoryRepository projectRootDirectoryRepository)
        {
            _projectRootDirectoryRepository = projectRootDirectoryRepository ?? throw new ArgumentNullException(nameof(projectRootDirectoryRepository));
        }

        public void Add(ProjectRoot projectRootDirectory)
        {
            _projectRootDirectoryRepository.Insert(projectRootDirectory);
        }

        public ProjectRoot Get(Guid id)
        {
            return _projectRootDirectoryRepository.Query().Single(x => x.Id == id);
        }

        public IQueryable<ProjectRoot> GetAll()
        {
            return _projectRootDirectoryRepository.Query();
        }

        public void Remove(ProjectRoot projectRootDirectory)
        {
            _projectRootDirectoryRepository.Delete(projectRootDirectory);
        }

        public void Update(ProjectRoot projectRootDirectory)
        {
            _projectRootDirectoryRepository.Update(projectRootDirectory);
        }
    }
}
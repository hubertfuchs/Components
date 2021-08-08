using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Logic.ProjectManagement.Contract;
using Fuchsbau.Components.Data.DataStoring.Contract;

namespace Fuchsbau.Components.Logic.ProjectManagement
{
    public class ProjectManager : IProjectManager
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectManager(
            IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
        }

        public void Add(Project project)
        {
            _projectRepository.Insert(project);
        }

        public Project Get(Guid id)
        {
            return _projectRepository.Query().Single(x => x.Id == id);
        }

        public IQueryable<Project> GetAll()
        {
            return _projectRepository.Query();
        }

        public void Remove(Project project)
        {
            _projectRepository.Delete(project);
        }

        public void Update(Project project)
        {
            _projectRepository.Update(project);
        }

        public Project Get(uint projectNumber)
        {
            return _projectRepository.Query().Single(x => x.Number == projectNumber);
        }
    }
}

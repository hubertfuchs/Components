using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Logic.ProjectManagement.Contract;

namespace Fuchsbau.Components.Logic.ProjectManagement
{
    public class ProjectFileManager : IProjectFileManager
    {
        private readonly IProjectFileRepository _imageRepository;

        public ProjectFileManager(
            IProjectFileRepository imageRepository)
        {
            _imageRepository = imageRepository ?? throw new ArgumentNullException(nameof(imageRepository));
        }

        public void Add(ProjectFile image)
        {
            _imageRepository.Insert( image );
        }

        public ProjectFile Get(Guid id)
        {
            return _imageRepository.Query().Single(x => x.Id == id);
        }

        public IQueryable<ProjectFile> GetAll()
        {
            return _imageRepository.Query();
        }

        public void Remove(ProjectFile image)
        {
            _imageRepository.Delete(image);
        }

        public void Update(ProjectFile image)
        {
            _imageRepository.Update(image);
        }
    }
}

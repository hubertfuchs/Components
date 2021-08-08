using System.Collections.Generic;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage.Contexts
{
    [UnitOfWork]
    public class ProjectContext : IUnitOfWork
    {
        public IList<ProjectRoot> ProjectRoots { get; set; }
        public IList<ProjectFolder> ProjectFolders { get; set; }
        public IList<ProjectSubfolder> ProjectSubfolders { get; set; }

        private readonly IProjectRootReader _projectRootReader;
        private readonly IProjectRootWriter _projectRootWriter;

        private readonly IProjectFolderReader _projectFolderReader;
        private readonly IProjectFolderWriter _projectFolderWriter;

        private readonly IProjectSubfolderReader _projectSubfolderReader;
        private readonly IProjectSubfolderWriter _projectSubfolderWriter;

        public ProjectContext()
        {
            var directory = new LocalDirectory(@"F:\hubert\Softwareentwicklung\Projekte\ImageHandlerSystem.Testdaten\Fuchsbau");

            var projectRootsFile = new LocalFile(directory.Path, "ProjectRoots.json");
            var projectFoldersFile = new LocalFile(directory.Path, "ProjectFolders.json");
            var projectSubfoldersFile = new LocalFile(directory.Path, "ProjectSubfolders.json");

            _projectRootReader = new ProjectRootReader(directory, projectRootsFile);
            _projectRootWriter = new ProjectRootWriter(directory, projectRootsFile);

            _projectFolderReader = new ProjectFolderReader(directory, projectFoldersFile);
            _projectFolderWriter = new ProjectFolderWriter(directory, projectFoldersFile);

            _projectSubfolderReader = new ProjectSubfolderReader(directory, projectSubfoldersFile);
            _projectSubfolderWriter = new ProjectSubfolderWriter(directory, projectSubfoldersFile);
        }

        internal void LoadData()
        {
            if (ProjectRoots == null)
            {
                ProjectRoots = _projectRootReader.Read();
            }

            if (ProjectFolders == null)
            {
                ProjectFolders = _projectFolderReader.Read();
            }

            if (ProjectSubfolders == null)
            {
                ProjectSubfolders = _projectSubfolderReader.Read();
            }
        }

        public int SaveChanges()
        {
            int result;

            _projectRootWriter.Write(ProjectRoots);
            ProjectRoots = null;
            result = ProjectRoots.Count

            _projectFolderWriter.Write(ProjectFolders);
            ProjectFolders = null;
            result = ProjectFolders.Count;

            return result;
        }

        internal void Update(ProjectRoot projectRoot)
        {
            var currentProjectRoot = ProjectRoots.Single(x => x.Id == projectRoot.Id);
            int index = ProjectRoots.IndexOf(currentProjectRoot);
            ProjectRoots[index] = projectRoot;
        }

        internal void Update(ProjectFolder projectFolder)
        {
            var currentProjectFolder = ProjectFolders.Single(x => x.Id == projectFolder.Id);
            int index = ProjectFolders.IndexOf(currentProjectFolder);
            ProjectFolders[index] = projectFolder;
        }
    }
}
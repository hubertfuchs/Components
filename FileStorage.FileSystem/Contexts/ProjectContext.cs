using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes.Attributes;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage.Contexts
{
    [UnitOfWork]
    public class ProjectContext : IUnitOfWork 
    {
        private IList<ProjectRoot> _projectRoots;                        
        private IList<ProjectFolder> _projectFolders;
        private IList<ProjectSubfolder> _projectSubfolders;

        private readonly IProjectRootReader _projectRootReader;
        private readonly IProjectFolderReader _projectFolderReader;
        private readonly IProjectSubfolderReader _projectSubfolderReader;

        private readonly IProjectRootWriter _projectRootWriter;
        private readonly IProjectFolderWriter _projectFolderWriter;
        private readonly IProjectSubfolderWriter _projectSubfolderWriter;

        public IList<ProjectRoot> ProjectRoots
        {
            get
            {
                if (_projectRoots == null)
                {
                    _projectRoots = _projectRootReader.Read();
                }

                return _projectRoots;
            }
        }

        public IList<ProjectFolder> ProjectFolders
        {
            get
            {
                if( _projectFolders == null )
                {
                    _projectFolders = _projectFolderReader.Read();
                }

                return _projectFolders;
            }
        }

        public IList<ProjectSubfolder> ProjectSubfolders
        {
            get
            {
                if (_projectSubfolders == null)
                {
                    _projectSubfolders = _projectSubfolderReader.Read();
                }

                return _projectSubfolders;
            }
        }

        public ProjectContext()
        {
            var directory =
                new LocalDirectory(@"F:\hubert\Softwareentwicklung\Projekte\ImageHandlerSystem.Testdaten\Fuchsbau");

            var projectRootsFile = new LocalFile(directory.Path, "ProjectRoots.json");
            var projectFoldersFile = new LocalFile(directory.Path, "ProjectFolders.json");
            var projectSubfoldersFile = new LocalFile(directory.Path, "ProjectSubfolders.json");

            _projectRootReader = new ProjectRootReader(directory, projectRootsFile);
            _projectFolderReader = new ProjectFolderReader(directory, projectFoldersFile);
            _projectSubfolderReader = new ProjectSubfolderReader(directory, projectSubfoldersFile);
            
            _projectRootWriter = new ProjectRootWriter(directory, projectRootsFile);
            _projectFolderWriter = new ProjectFolderWriter(directory, projectFoldersFile);
            _projectSubfolderWriter = new ProjectSubfolderWriter(directory, projectSubfoldersFile);
        }

        public int SaveChanges()
        {
            int result = 0;

            _projectRootWriter.Write(_projectRoots);
            _projectFolderWriter.Write(_projectFolders);
            _projectSubfolderWriter.Write(_projectSubfolders);
            
            result += _projectRoots.Count;
            result += _projectFolders.Count;
            result += _projectSubfolders.Count;
            
            _projectRoots = null;
            _projectFolders = null;
            _projectSubfolders = null;

            return result;
        }
    }
}
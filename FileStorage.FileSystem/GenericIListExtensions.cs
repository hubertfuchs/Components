using System.Collections.Generic;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Data.FileStorage
{
    public static class GenericIListExtensions
    {
        public static void Update(this IList<ProjectRoot> projectRoots, ProjectRoot projectRoot)
        {
            var currentProjectRoot = projectRoots.Single(x => x.Id == projectRoot.Id);
            int index = projectRoots.IndexOf(currentProjectRoot);
            projectRoots[index] = projectRoot;
        }

        public static void Update(this IList<ProjectFolder> projectFolders, ProjectFolder projectFolder)
        {
            var currentProjectFolder = projectFolders.Single(x => x.Id == projectFolder.Id);
            int index = projectFolders.IndexOf(currentProjectFolder);
            projectFolders[index] = projectFolder;
        }

        public static void Update(this IList<ProjectSubfolder> projectSubfolders, ProjectSubfolder projectSubfolder)
        {
            var currentProjectSubfolder = projectSubfolders.Single(x => x.Id == projectSubfolder.Id);
            int index = projectSubfolders.IndexOf(currentProjectSubfolder);
            projectSubfolders[index] = projectSubfolder;
        }
    }
}
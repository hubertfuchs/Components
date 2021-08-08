using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    internal class ProjectFolderWriter : IProjectFolderWriter
    {
        private readonly IDirectory _directory;
        private readonly IFile _file;

        public ProjectFolderWriter(
            IDirectory directory, 
            IFile file)
        {
            _directory = directory ?? throw new ArgumentNullException(nameof(directory));
            _file = file ?? throw new ArgumentNullException(nameof(file));
        }

        public void Write(IList<ProjectFolder> projectFolders)
        {
            string json = JsonConvert.SerializeObject(projectFolders);

            string path = Path.Combine(_directory.Path, _file.Name);

            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(json);
            }
        }

        public void WriteAsync(IList<ProjectFolder> list)
        {
            throw new NotImplementedException();
        }
    }
}
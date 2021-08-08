using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    internal class ProjectRootWriter : IProjectRootWriter
    {
        private readonly IDirectory _directory;
        private readonly IFile _file;

        public ProjectRootWriter(
            IDirectory directory, 
            IFile file)
        {
            _directory = directory ?? throw new ArgumentNullException(nameof(directory));
            _file = file ?? throw new ArgumentNullException(nameof(file));
        }

        public void Write(IList<ProjectRoot> projectRootDirectories)
        {
            string json = JsonConvert.SerializeObject(projectRootDirectories);

            string path = Path.Combine(_directory.Path, _file.Name);

            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(json);
            }
        }

        public void WriteAsync(IList<ProjectRoot> projectRootDirectories)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    internal class ProjectImageWriter : IProjectImageWriter
    {
        private readonly IDirectory _directory;
        private readonly IFile _file;

        public ProjectImageWriter(
            IDirectory directory,
            IFile file)
        {
            _directory = directory ?? throw new ArgumentNullException(nameof(directory));
            _file = file ?? throw new ArgumentNullException(nameof(file));
        }

        public void Write(IList<ProjectFile> images)
        {
            string json = JsonConvert.SerializeObject(images);

            string path = Path.Combine(_directory.Path, _file.Name);

            using (var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(json);
            }
        }

        public void WriteAsync(IList<ProjectFile> images)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contract;
using Fuchsbau.Components.Data.FileStorage.Contract.Exceptions;

namespace Fuchsbau.Components.Data.FileStorage
{
    internal class ProjectImageReader : IProjectImageReader
    {
        private readonly IDirectory _directory;
        private readonly IFile _file;

        public ProjectImageReader(
            IDirectory directory,
            IFile file)
        {
            _directory = directory ?? throw new ArgumentNullException(nameof(directory));
            _file = file ?? throw new ArgumentNullException(nameof(file));
        }

        public IList<ProjectFile> Read()
        {
            if (!_directory.Exists())
            {
                throw new DirectoryNotFoundException($"Directory({_directory.Path}) not found!");
            }

            if (!_file.Exists())
            {
                throw new FileNotFoundException("File not found!", _file.Name);
            }

            string path = Path.Combine(_directory.Path, _file.Name);

            IList<ProjectFile> result = null;

            using (var streamReader = new StreamReader(path, Encoding.GetEncoding("iso-8859-1")))
            {
                result = JsonConvert.DeserializeObject<IList<ProjectFile>>(streamReader.ReadToEnd());
            }

            if (result == null)
            {
                throw new ResultIsNullException("Result is null!", typeof(IList<ProjectFile>));
            }

            return result;
        }

        public IList<ProjectFile> ReadAsync()
        {
            throw new NotImplementedException();
        }
    }
}
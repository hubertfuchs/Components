using System;
using System.IO;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    public class LocalFile : IFile
    {
        private readonly string _localDirectoryPath;
        private readonly string _localFileName;

        public string PathFileName => Path.Combine(_localDirectoryPath, _localFileName);
        public string Name => _localFileName;

        public LocalFile(
            string localDirectoryPath,
            string localFileName)
        {
            _localDirectoryPath = localDirectoryPath ?? throw new ArgumentNullException(nameof(localDirectoryPath));
            _localFileName = localFileName ?? throw new ArgumentNullException(nameof(localFileName));
        }

        public bool Exists()
        {
            return File.Exists(Path.Combine(_localDirectoryPath, _localFileName));
        }
    }
}
using System;
using System.IO;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    public class LocalDirectory : IDirectory
    {
        private readonly string _localPath;

        public string Path => _localPath;

        public LocalDirectory(
            string localPath)
        {
            _localPath = localPath ?? throw new ArgumentNullException(nameof(localPath));
        }

        public bool Exists()
        {
            return Directory.Exists(_localPath);
        }
    }
}

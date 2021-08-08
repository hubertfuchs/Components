using Fuchsbau.Components.Data.FileStorage.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fuchsbau.Components.Data.FileStorage.OneDrive
{
    public class OneDriveWriteFile : IFile
    {
        public bool Exists(string path)
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
        public bool Exists()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    internal class ProjectSubfolderWriter : IProjectSubfolderWriter
    {
        private readonly IDirectory _directory;
        private readonly IFile _file;

        public ProjectSubfolderWriter(
            IDirectory directory,
            IFile file )
        {
            _directory = directory ?? throw new ArgumentNullException( nameof( directory ) );
            _file = file ?? throw new ArgumentNullException( nameof( file ) );
        }

        public void Write(IList<ProjectSubfolder> list)
        {
            throw new NotImplementedException();
        }

        public void WriteAsync(IList<ProjectSubfolder> list)
        {
            throw new NotImplementedException();
        }
    }
}
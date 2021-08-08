using System;
using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage
{
    internal class ProjectSubfolderReader : IProjectSubfolderReader
    {
        private readonly IDirectory _directory;
        private readonly IFile _file;

        public ProjectSubfolderReader(
            IDirectory directory,
            IFile file )
        {
            _directory = directory ?? throw new ArgumentNullException( nameof( directory ) );
            _file = file ?? throw new ArgumentNullException( nameof( file ) );
        }

        public IList<ProjectSubfolder> Read()
        {
            throw new NotImplementedException();
        }

        public IList<ProjectSubfolder> ReadAsync()
        {
            throw new NotImplementedException();
        }
    }
}
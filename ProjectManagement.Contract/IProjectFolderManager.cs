using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.ProjectManagement.Contract
{
    public interface IProjectFolderManager : IManager<ProjectFolder>
    {
        IQueryable<ProjectFolder> GetAllByRootDirectoryId(Guid rootDirectoryId);
    }
}
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.ProjectManagement.Contract
{
    public interface IProjectManager : IManager<Project>
    {
        Project Get(uint projectNumber);
    }
}

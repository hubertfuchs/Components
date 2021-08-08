using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.ProjectManagement.Contract
{
    public interface ISubprojectManager : IManager<Subproject>
    {
        Subproject Get(uint subprojectNumber);
    }
}
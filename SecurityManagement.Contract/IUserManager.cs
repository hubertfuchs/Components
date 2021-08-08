using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.SecurityManagement.Contract
{
    public interface IUserManager : IManager<User>
    {
        IQueryable<User> GetAllSortedByLastName();
    }
}

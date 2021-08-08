using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class RoleRepository : IRoleRepository
    {
        private readonly SecurityContext _context;

        public RoleRepository(
            SecurityContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(Role role)
        {
            _context.Roles.Remove(role);
        }

        public void Insert(Role role)
        {
            _context.Roles.Add(role);
        }

        public IQueryable<Role> Query()
        {
            return _context.Roles.AsQueryable();
        }

        public void Update(Role role)
        {
            _context.Roles.Update(role);
        }
    }
}

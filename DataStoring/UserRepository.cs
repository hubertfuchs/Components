using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class UserRepository : IUserRepository
    {
        private readonly SecurityContext _context;

        public UserRepository(
            SecurityContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
        }

        public void Insert(User user)
        {
            _context.Add(user);
        }

        public IQueryable<User> Query()
        {
            return _context.Users.AsQueryable();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
        }
    }
}

using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class RightRepository : IRightRepository
    {
        private readonly SecurityContext _context;

        public RightRepository(
            SecurityContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(Right right)
        {
            _context.Rights.Remove(right);
        }

        public void Insert(Right right)
        {
            _context.Add(right);
        }

        public IQueryable<Right> Query()
        {
            return _context.Rights.AsQueryable();
        }

        public void Update(Right right)
        {
            _context.Rights.Update(right);
        }
    }
}

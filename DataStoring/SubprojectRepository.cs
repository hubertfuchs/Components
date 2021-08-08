using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;

namespace Fuchsbau.Components.Data.DataStoring.EF
{
    public class SubprojectRepository : ISubprojectRepository
    {
        private readonly ProjectContext _context;

        public SubprojectRepository(
            ProjectContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Delete(Subproject subproject)
        {
            _context.Subprojects.Remove(subproject);
        }

        public void Insert(Subproject subproject)
        {
            _context.Subprojects.Add(subproject);
        }

        public IQueryable<Subproject> Query()
        {
            return _context.Subprojects.AsQueryable();
        }

        public void Update(Subproject subproject)
        {
            _context.Subprojects.Update(subproject);
        }
    }
}

using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Plugin
{
    public class TestRepository : IRepository<string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestRepository(
            IUnitOfWork unitOfWork )
        {
            _unitOfWork = unitOfWork ?? throw new System.ArgumentNullException( nameof( unitOfWork ) );
        }

        public void Delete( string entity )
        {
            
        }

        public void Insert( string entity )
        {
            
        }

        public IQueryable<string> Query()
        {
            return null;
        }

        public void Update( string entity )
        {
            throw new System.NotImplementedException();
        }
    }
}

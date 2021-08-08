using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Data.DataStoring.Contract;
using Fuchsbau.Components.Logic.ProjectManagement.Contract;

namespace Fuchsbau.Components.Logic.ProjectManagement
{
    public class SubprojectManager : ISubprojectManager
    {
        private readonly ISubprojectRepository _subprojectRepository;

        public SubprojectManager(
            ISubprojectRepository subprojectRepository )
        {
            _subprojectRepository = subprojectRepository ?? throw new ArgumentNullException( nameof( subprojectRepository ) );
        }

        public void Add( Subproject subproject )
        {
            _subprojectRepository.Insert( subproject );
        }

        public Subproject Get( Guid id )
        {
            return _subprojectRepository.Query().Single( x => x.Id == id );
        }
        
        public IQueryable<Subproject> GetAll()
        {
            return _subprojectRepository.Query();
        }

        public void Remove( Subproject subproject )
        {
            _subprojectRepository.Delete( subproject );
        }

        public void Update( Subproject subproject )
        {
            _subprojectRepository.Update( subproject );
        }

        public Subproject Get( uint subprojectNumber )
        {
            return _subprojectRepository.Query().Single( x => x.Number == subprojectNumber );
        }
    }
}
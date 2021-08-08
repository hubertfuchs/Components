using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Plugin
{
    public class TestManager : IManager<string>
    {
        private readonly IRepository<string> _repository;

        public TestManager(
            IRepository<string> repository )
        {
            _repository = repository ?? throw new ArgumentNullException( nameof( repository ) );
        }

        public void Add( string entity )
        {
            _repository.Insert( entity );
        }

        public string Get( Guid id )
        {
            throw new NotImplementedException();
        }

        public IQueryable<string> GetAll()
        {
            return _repository.Query();
        }

        public void Remove( string entity )
        {
            throw new NotImplementedException();
        }

        public void Update( string entity )
        {
            throw new NotImplementedException();
        }
    }
}

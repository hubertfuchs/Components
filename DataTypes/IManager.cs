using System;
using System.Linq;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public interface IManager<T>
    {
        void Add( T entity );
        T Get( Guid id );
        IQueryable<T> GetAll();
        void Remove( T entity );
        void Update( T entity );
    }
}

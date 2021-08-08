using System.Linq;

namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public interface IRepository<T>
    {
        void Delete( T entity );
        void Insert( T entity );
        IQueryable<T> Query();
        void Update( T entity );
    }
}

using System.Collections.Generic;
using System.Linq;
using Fuchsbau.Components.CrossCutting.Configuration.Contract;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Configuration
{
    public class Configuration : IConfiguration
    {
        private readonly IDictionary<string, object> _items;

        public IQueryable Items => _items.AsQueryable();

        public Configuration()
        {
            _items = new Dictionary<string, object>();
        }

        public void Set( string category, string key, object value )
        {
            _items[ ComposeKey( category, key ) ] = value;
        }

        public T Get<T>( string category, string key )
        {
            return ( T ) _items[ ComposeKey( category, key ) ];
        }

        private string ComposeKey( string category, string key )
        {
            return $"{category}.{key}";
        }
    }
}

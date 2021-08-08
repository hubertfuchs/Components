using System;
using System.Linq;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Logic.MasterDataManagement.Contract;

namespace Fuchsbau.Components.Logic.MasterDataManagement
{
    public class CustomerManager : ICustomerManager
    {
        public void Add( Customer customer )
        {
            throw new NotImplementedException();
        }

        public Customer Get( Guid id )
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove( Customer customer )
        {
            throw new NotImplementedException();
        }

        public void Update( Customer customer )
        {
            throw new NotImplementedException();
        }
    }
}

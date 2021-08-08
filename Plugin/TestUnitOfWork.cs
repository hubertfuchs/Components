using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Plugin
{
    public class TestUnitOfWork : IUnitOfWork
    {
        public List<object> Data { get; set; }

        public TestUnitOfWork()
        {
            Data = new List<object>();
        }

        public int SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}

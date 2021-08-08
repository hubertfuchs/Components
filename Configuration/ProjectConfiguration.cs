using System;
using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.Configuration.Contract;

namespace Fuchsbau.Components.CrossCutting.Configuration
{
    public class ProjectConfiguration : IProjectConfiguration
    {
        public void Set(string category, string key, object value)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string category, string key)
        {
            throw new NotImplementedException();
        }
        
        public ProjectConfiguration()
        {
        }
    }
}
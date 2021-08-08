using System;
using System.Collections.Generic;
using System.Text;

namespace Fuchsbau.Components.CrossCutting.Core.Contract
{
    public interface IBootstrapper
    {
        void ActivatingAll();
        void ActivatedAll();
        void DeactivatingAll();
        void DeactivatedAll();
        //void RegisterAllMappings(ICoCoKernel kernel);
        //void AddAllMessageSubscriptions(IEventBroker broker);
    }
}

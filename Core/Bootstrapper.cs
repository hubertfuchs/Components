using System;
using System.Collections.Generic;
using Fuchsbau.Components.CrossCutting.Core.Contract;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.CrossCutting.Core
{
    public class Bootstrapper : IBootstrapper
    {
        private readonly List<IActivator> _activators;

        public Bootstrapper(
            List<IActivator> activators)
        {
            _activators = activators ?? throw new ArgumentNullException(nameof(activators));
        }

        public void ActivatingAll()
        {
            _activators.ForEach(x => x.Activating());
        }

        public void ActivatedAll()
        {
            _activators.ForEach(x => x.Activated());
        }

        public void DeactivatingAll()
        {
            _activators.ForEach(x => x.Deactivating());
        }

        public void DeactivatedAll()
        {
            _activators.ForEach(x => x.Deactivated());
        }

        // RegisterAllMappings(ICoCoKernel kernel): _activators.ForEach(x => x.RegisterMappings(kernel));

        // AddAllMessageSubscriptions(IEventBroker broker): _activators.ForEach(x => x.AddMessageSubscriptions(broker));

        // ConfigureAll(IConfigurator config): _activators.ForEach(x => x.Configure(config));
    }
}
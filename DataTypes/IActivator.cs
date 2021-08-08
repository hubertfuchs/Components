namespace Fuchsbau.Components.CrossCutting.DataTypes
{
    public interface IActivator
    {
        void Activating();
        void Activated();
        void Deactivating();
        void Deactivated();
        //void RegisterMapping(IKernel kernel);
        //void AddMessageSubscriptions(IEventBroker broker);
        //void Configure(IConfigurator config);
    }
}
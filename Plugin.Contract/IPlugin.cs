namespace Fuchsbau.Components.CrossCutting.Plugin.Contract
{
    internal interface IPlugin
    {
        IPluginHost PluginHost { get; set; }
        string PluginName { get; protected set; }
        string PluginDescription { get; protected set; }

        void Execute();
    }
}

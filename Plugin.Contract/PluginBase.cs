namespace Fuchsbau.Components.CrossCutting.Plugin.Contract
{
    //public abstract class PluginBasex : IPlugin
    //{
    //}
    //
    //public abstract class PluginBase //: IPlugin
    //{
    //    private IPluginHost _pluginHost;
    //
    //    public IPluginHost PluginHost
    //    {
    //        get => _pluginHost;
    //        set
    //        {
    //            _pluginHost = value;
    //            _pluginHost.Register( this );
    //        }
    //    }
    //    public string PluginName { get; protected set; } = $"{PluginCounter}. Plugin";
    //    public string PluginDescription { get; protected set; } = "---";
    //    public static byte PluginCounter { get; }
    //
    //    static PluginBase()
    //    {
    //        PluginCounter++;
    //    }
    //
    //    public abstract void Execute();
    //}
    //
    //public class XXX : PluginBase
    //{
    //}
    //
    //public class PluginTest : PluginBase
    //{
    //    private readonly IPluginHost _pluginHost;
    //    private readonly string _pluginName;
    //    private readonly string _pluginDescription;
    //
    //    public override IPluginHost PluginHost => _pluginHost;
    //    public override string PluginName => _pluginName;
    //    public override string PluginDescription => _pluginDescription;
    //
    //    public PluginTest(
    //        IPluginHost pluginHost, string pluginName, string pluginDescription )
    //    {
    //        _pluginHost = pluginHost ?? throw new ArgumentNullException( nameof( pluginHost ) );
    //        _pluginName = pluginName ?? throw new ArgumentNullException( nameof( pluginName ) );
    //        _pluginDescription = pluginDescription ?? throw new ArgumentNullException( nameof( pluginDescription ) );
    //    }
    //
    //    public override void Execute()
    //    {
    //        var test = PluginTest.PluginCounter;
    //        throw new NotImplementedException();
    //    }
    //}
}

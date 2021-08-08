namespace Fuchsbau.Components.CrossCutting.Plugin
{
    /*
Post-build event commands:
XCOPY /Y $(TargetDir)*.dll $(SolutionDir)_PluginSource\
XCOPY /Y $(TargetDir)*.pdb $(SolutionDir)_PluginSource\    
     */

    //public class TestPlugin : PluginBase
    //{
    //    public IPluginHost PluginHost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //    public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //
    //    public void Execute()
    //    {
    //        var logger = new DebugLogger();
    //
    //        logger.Log( "Hier ist alles nur ein Test und sollte nicht ernst genommen werden" );
    //
    //        var persistenceService = new TestPersistenceService();
    //        var repository = new TestRepository( persistenceService );
    //        var manager = new TestManager( repository );
    //
    //        var executionMain = new TestExecutionMain(
    //            logger,
    //            manager,
    //            repository,
    //            persistenceService );
    //
    //        executionMain.Run();
    //    }
    //
    //}
    //
    //public class Txxx : PluginBase
    //{
    //    public override IPluginHost PluginHost => throw new NotImplementedException();
    //
    //    public override string Name => throw new NotImplementedException();
    //
    //    public override string Description => throw new NotImplementedException();
    //
    //    public override void Execute()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

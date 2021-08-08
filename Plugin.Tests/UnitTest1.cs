namespace Fuchsbau.Components.CrossCutting.Plugin.Tests
{
    //[TestClass]
    //public class UnitTest1 : IPluginHost
    //{
    //    [TestMethod]
    //    public void TestMethod1()
    //    {
    //       
    //        var pluginPaths = new string[]
    //        {
    //            @"F:\hubert\Softwareentwicklung\Projekte\Components\_PluginSource\Plugin.dll",
    //        };
    //
    //        var plugins = pluginPaths.SelectMany( pluginPath =>
    //        {
    //            Assembly pluginAssembly = LoadPlugin( pluginPath );
    //            IEnumerable<IPlugin> plugins1 = CreatePlugins( pluginAssembly );
    //            return plugins1;
    //        } 
    //        ).ToList();
    //
    //        foreach( var plugin in plugins )
    //        {
    //            //Debug.WriteLine( $"{plugin.Name}\t - {plugin.Description}" );
    //            
    //            plugin.Execute();
    //        }
    //    }
    //
    //    public Assembly LoadPlugin( string relativePath )
    //    {
    //        string path = AppContext.BaseDirectory;
    //        string[] files = Directory.GetFiles( path, "*.DLL" );
    //
    //
    //        // Navigate up to the solution root
    //        string root = Path.GetFullPath( Path.Combine(
    //            Path.GetDirectoryName(
    //                Path.GetDirectoryName(
    //                    Path.GetDirectoryName(
    //                        Path.GetDirectoryName(
    //                            Path.GetDirectoryName( typeof( UnitTest1 ).Assembly.Location ) ) ) ) ) ) );
    //
    //        string pluginLocation = Path.GetFullPath( Path.Combine( root, relativePath.Replace( '\\', Path.DirectorySeparatorChar ) ) );
    //
    //        Debug.WriteLine( $"Loading plug-ins from: {pluginLocation}" );
    //
    //        PluginAssemblyLoadContext loadContext = new PluginAssemblyLoadContext( pluginLocation );
    //        return loadContext.LoadFromAssemblyName( new AssemblyName( Path.GetFileNameWithoutExtension( pluginLocation ) ) );
    //    }
    //    // XCOPY /Y $(TargetDir)$(TargetFileName) $(SolutionDir)_PluginSource\
    //    public IEnumerable<IPlugin> CreatePlugins( Assembly assembly )
    //    {
    //        int count = 0;
    //    
    //        foreach( Type type in assembly.GetTypes() )
    //        {
    //            if( typeof( IPlugin ).IsAssignableFrom( type ) )
    //            {
    //                var result = Activator.CreateInstance( type, this, "", "" ) as IPlugin;
    //                if( result != null )
    //                {
    //                    count++;
    //                    yield return result;
    //                }
    //            }
    //        }
    //    
    //        if( count == 0 )
    //        {
    //            string availableTypes = string.Join( ",", assembly.GetTypes().Select( t => t.FullName ) );
    //            throw new ApplicationException(
    //                $"Can't find any type which implements IPlugin in {assembly} from {assembly.Location}.\n" +
    //                $"Available types: {availableTypes}" );
    //        }
    //    }
    //}
    //
    //public class PluginAssemblyLoadContext : AssemblyLoadContext
    //{
    //    private AssemblyDependencyResolver _resolver;
    //
    //    public PluginAssemblyLoadContext( string pluginPath )
    //    {
    //        _resolver = new AssemblyDependencyResolver( pluginPath );
    //    }
    //
    //    protected override Assembly Load( AssemblyName assemblyName )
    //    {
    //        string assemblyPath = _resolver.ResolveAssemblyToPath( assemblyName );
    //        if( assemblyPath != null )
    //        {
    //            return LoadFromAssemblyPath( assemblyPath );
    //        }
    //
    //        return null;
    //    }
    //
    //    protected override IntPtr LoadUnmanagedDll( string unmanagedDllName )
    //    {
    //        string libraryPath = _resolver.ResolveUnmanagedDllToPath( unmanagedDllName );
    //        if( libraryPath != null )
    //        {
    //            return LoadUnmanagedDllFromPath( libraryPath );
    //        }
    //
    //        return IntPtr.Zero;
    //    }
    //}
}

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuchsbau.Components.CrossCutting.Brokerage.MessageBroker;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.CrossCutting.Logging;

namespace Fuchsbau.Components.Logic.ProjectManagement.Tests
{
    [TestClass]
    public class ProjectDirectoryUnitTests
    {
        //private QrCodeBarcodeGenerator _barcodeGenerator;
        //
        //private void FillProjectDirectory( ProjectRootDirectory projectRootDirectory, string path)
        //{
        //    foreach (var directory in Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly))
        //    {
        //        string text = directory.Replace(path, string.Empty);
        //        string name = text.Replace(@"\", string.Empty);
        //
        //        var newProjectDirectory = new ProjectFolderStructure(name);
        //        projectRootDirectory.Folders.Add(newProjectDirectory);
        //
        //        FillProjectDirectory(newProjectDirectory, directory);
        //    }
        //}
        //
        //[TestMethod]
        //public void x()
        //{
        //    _barcodeGenerator = new QrCodeBarcodeGenerator( new ConsoleLogger(), new MessageBroker() );
        //
        //    string rootPath = @"F:\hubert\Softwareentwicklung\Projekte\ImageHandlerSystem.Testdaten\trend-INTERIOR\Ordnerstruktur";
        //
        //    var projectRootDirectory = new ProjectRootDirectory();
        //    FillProjectDirectory(projectRootDirectory, rootPath );
        //
        //
        //
        //    var projectDirectoryElement =
        //        new ProjectDirectoryElement(projectRootDirectory.Name, projectRootDirectory.ReadOnly);
        //
        //    projectDirectoryElement.AddRange(projectRootDirectory.Folders);
        //
        //    string result = projectDirectoryElement.GetPath();
        //}
    }
}
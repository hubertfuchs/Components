using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Fuchsbau.Components.Logic.ProjectManagement.Contract;
using Fuchsbau.Components.Logic.ProjectWorkflows.Contract;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.Configuration.Contract;

namespace Fuchsbau.Components.Logic.ProjectWorkflows
{
    public class ProjectFileWorkflow : IProjectFileWorkflow
    {
        //private readonly IProjectFileGroupsConfiguration _projectFileGroupsConfiguration;
        private readonly IProjectFileManager _projectFileManager;
        private readonly IBarcodeGenerator _barcodeGenerator;
        private readonly IMessageBroker _eventAggregator;

        public ProjectFileWorkflow(
            //IProjectFileGroupsConfiguration projectFileGroupsConfiguration,
            IProjectFileManager projectFileManager,
            IBarcodeGenerator barcodeGenerator,
            IMessageBroker eventAggregator)
        {
            //_projectFileGroupsConfiguration = projectFileGroupsConfiguration ?? throw new ArgumentNullException(nameof(projectFileGroupsConfiguration));
            _projectFileManager = projectFileManager ?? throw new ArgumentNullException(nameof(projectFileManager));
            _barcodeGenerator = barcodeGenerator ?? throw new ArgumentNullException(nameof(barcodeGenerator));
            _eventAggregator = eventAggregator ?? throw new ArgumentNullException(nameof(eventAggregator));
        }

        // public ProjectFileWorkflow()
        // {                                         
        // 
        //     foreach( var directory in _projectFileGroupsConfiguration.Directories )
        //     {
        //         Debug.WriteLine( directory.Name );
        // 
        //         Test( directory );
        //     }
        // 
        // }
        // 
        // public void Test(ProjectDirectory directory)
        // {
        //     Debug.WriteLine(directory.Name);
        // 
        //     foreach (var projectFileDirectory in directory.Directories)
        //     {
        //         Debug.WriteLine(projectFileDirectory.Name);
        // 
        //         Test(projectFileDirectory);
        //     }
        // }

        // public void CreateImageGroup( ImageGroup imageGroup )
        // {
        // 
        // 
        // 
        //     int numberOfIdenticalLabels = _imageGroupManager.GetAll().Count(x => x.Label == imageGroup.Label);
        //     if( numberOfIdenticalLabels >= 1 )
        //     {
        //         imageGroup.Label = $"{imageGroup.Label} ({numberOfIdenticalLabels})";
        //     }
        // 
        //     string barcodeText = $"https://wwww.beispiel.de/{imageGroup.Label}";
        //     Barcode barcode = _barcodeGenerator.Generate(barcodeText);
        //     
        //     _imageGroupManager.Add( imageGroup );
        // }
        // 
        // public void DeleteImageGroup( Guid id )
        // {
        //     var imageGroup = _imageGroupManager.Get( id );
        // 
        //     _imageGroupManager.Remove( imageGroup );
        // }
        // 
        // public void ChangeImageGroupLabel( Guid id, string newLabel )
        // {
        //     var imageGroup = _imageGroupManager.Get( id );
        // 
        //     imageGroup.Label = newLabel;
        // 
        //     _imageGroupManager.Update( imageGroup );
        // }
        // 
        // public void CreateImage(ProjectFile image)
        // {
        //     _imageManager.Add(image);
        // }
        // 
        // public void DeleteImage(Guid imageId)
        // {
        //     var image = _imageManager.Get(imageId);
        // 
        //     _imageManager.Remove(image);
        // }
    }
}

using System.IO;
using System.Security;
using Microsoft.Graph;
using Fuchsbau.Components.Data.FileStorage.Contract;

namespace Fuchsbau.Components.Data.FileStorage.OneDrive
{
    public class OneDriveReadFile : IFile
    {
        public bool Exists( string path )
        {
            var userName = "mustermann@beispiel.de";
            var userPassword = new SecureString();
            var pwd = "0815";
            foreach( var c in pwd )
            {
                userPassword.AppendChar( c );
            }

            var authenticationProvider = new GraphServiceClientAuthenticationProvider( userName, userPassword );

            GraphServiceClient graphServiceClient = new GraphServiceClient( authenticationProvider.Get() );

            var request = graphServiceClient.Me.Drive.Root.Children.Request();

            var results = request.GetAsync().Result;

            foreach( var result in results )
            {
                var test = $"{result.Name} {result.Id}";
            }


            var fileStream = graphServiceClient.Me.Drive.Items[ "id" ].Content.Request().GetAsync().Result;
            var driveItemPath = Path.Combine( System.IO.Directory.GetCurrentDirectory(), "proposal.docx" );
            var driveItemFile = System.IO.File.Create( driveItemPath );
            fileStream.Seek( 0, SeekOrigin.Begin );
            fileStream.CopyTo( driveItemFile );



            return true;
        }

        public string Name { get; }
        public bool Exists()
        {
            throw new System.NotImplementedException();
        }
    }
}

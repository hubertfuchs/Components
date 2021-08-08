using System;
using System.Collections.Generic;
using System.Security;
using Microsoft.Graph;
using Microsoft.Identity.Client;

namespace Fuchsbau.Components.Data.FileStorage.OneDrive
{
    public class GraphServiceClientAuthenticationProvider
    {
        const string APPLICATION_CLIENT_ID = "b437c21a-da73-4d73-b235-67a470927e7b";
        const string DIRECTORY_TENANT_ID = "633bae69-a0d2-4a25-bbe1-5d5306d31e94";

        private readonly string _authority = $"https://login.microsoftonline.com/{DIRECTORY_TENANT_ID}/v2.0";
        private readonly string _userName;
        private readonly SecureString _userPassword;

        public GraphServiceClientAuthenticationProvider(
            string userName,
            SecureString userPassword )
        {
            _userName = userName ?? throw new ArgumentNullException( nameof( userName ) );
            _userPassword = userPassword ?? throw new ArgumentNullException( nameof( userPassword ) );
        }

        public IAuthenticationProvider Get()
        {
            var scopes = new List<string>();
            scopes.Add( "User.Read" );
            scopes.Add( "Files.Read" );

            var cca = PublicClientApplicationBuilder.Create( APPLICATION_CLIENT_ID )
                .WithAuthority( _authority )
                .Build();


            return MsalAuthenticationProvider.GetInstance( cca, scopes.ToArray(), _userName, _userPassword );
        }
    }
}
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;
using System.Threading.Tasks;
using Microsoft.Graph;
using Microsoft.Identity.Client;

namespace Fuchsbau.Components.Data.FileStorage.OneDrive
{
    public class MsalAuthenticationProvider : IAuthenticationProvider
    {
        private static MsalAuthenticationProvider _singleton;
        private IPublicClientApplication _clientApplication;
        private string[] _scopes;
        private string _userName;
        private SecureString _userPassword;
        private string _userId;

        private MsalAuthenticationProvider(
            IPublicClientApplication clientApplication,
            string[] scopes,
            string userName,
            SecureString userPassword )
        {
            _clientApplication = clientApplication;
            _scopes = scopes;
            _userName = userName;
            _userPassword = userPassword;
            _userId = null;
        }

        public static MsalAuthenticationProvider GetInstance( IPublicClientApplication clientApplication, string[] scopes, string userName, SecureString userPassword )
        {
            if( _singleton == null )
            {
                _singleton = new MsalAuthenticationProvider( clientApplication, scopes, userName, userPassword );
            }

            return _singleton;
        }

        public async Task AuthenticateRequestAsync( HttpRequestMessage request )
        {
            var accessToken = await GetTokenAsync();

            request.Headers.Authorization = new AuthenticationHeaderValue( "bearer", accessToken );
        }

        public async Task<string> GetTokenAsync()
        {
            if( !string.IsNullOrEmpty( _userId ) )
            {
                try
                {
                    IAccount account = ( IAccount ) await _clientApplication.GetAccountsAsync( _userId );

                    if( account != null )
                    {
                        var silentResult = await _clientApplication.AcquireTokenSilent( _scopes, account ).ExecuteAsync();
                        return silentResult.AccessToken;
                    }
                }
                catch( Exception ex )
                {
                }
            }

            var result = await _clientApplication.AcquireTokenByUsernamePassword( _scopes, _userName, _userPassword ).ExecuteAsync();

            return result.AccessToken;
        }
    }
}
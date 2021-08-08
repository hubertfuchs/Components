using System.Security;
using Fuchsbau.Components.CrossCutting.DataTypes;

namespace Fuchsbau.Components.Logic.SecurityWorkflows.Contract
{
    public interface IUserWorkflow
    {
        void SignUpNewUser( User userAccount );
        bool SignIn( string userName, SecureString userPassword );
        void ForgotUserPassword( string email );
    }
}

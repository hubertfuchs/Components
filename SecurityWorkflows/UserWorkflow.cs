using System;
using System.Security;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract;
using Fuchsbau.Components.CrossCutting.Brokerage.Contract.DataTypes;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Logic.SecurityManagement.Contract;
using Fuchsbau.Components.Logic.SecurityWorkflows.Contract;

namespace Fuchsbau.Components.Logic.SecurityWorkflows
{
    public class UserWorkflow : IUserWorkflow
    {
        private readonly IUserManager _userManager;
        private readonly IMessageBroker _messageBroker;

        public UserWorkflow(
            IUserManager userManager,
            IMessageBroker messageBroker )
        {
            _userManager = userManager ?? throw new ArgumentNullException( nameof( userManager ) );
            _messageBroker = messageBroker ?? throw new ArgumentNullException( nameof( messageBroker ) );
        }

        public void SignUpNewUser( User account )
        {

        }

        public bool SignIn( string userName, SecureString userPassword )
        {
            //...

            var message = new UserLoginEventMessage();
            _messageBroker.Publish( message );

            return true;
        }

        public void ForgotUserPassword( string email )
        {

        }
    }
}

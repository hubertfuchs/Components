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
        private readonly IMessageBroker _eventAggregator;

        public UserWorkflow(
            IUserManager userManager,
            IMessageBroker eventAggregator)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _eventAggregator = eventAggregator ?? throw new ArgumentNullException(nameof(eventAggregator));
        }

        public void SignUpNewUser(User account)
        {

        }

        public bool SignIn(string userName, SecureString userPassword)
        {
            //...

            var message = new UserLoginEventMessage();
            _eventAggregator.Publish(message);

            return true;
        }

        public void ForgotUserPassword(string email)
        {

        }
    }
}

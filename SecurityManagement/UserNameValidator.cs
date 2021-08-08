using System;
using Fuchsbau.Components.CrossCutting.Configuration.Contract;
using Fuchsbau.Components.CrossCutting.DataTypes;
using Fuchsbau.Components.Logic.SecurityManagement.Contract;

namespace Fuchsbau.Components.Logic.SecurityManagement
{
    public class UserNameValidator : IUserNameValidator
    {
        private readonly IConfiguration _configuration;

        public UserNameValidator(
            IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }                                       

        public void Validate(string input)
        {
            
        }
    }
}

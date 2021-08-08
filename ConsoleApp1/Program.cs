using System;
using System.Security;
using System.IO;
using System.Text;
using Ninject;
using Fuchsbau.Components.CrossCutting.Brokerage.MessageBroker;
using Fuchsbau.Components.CrossCutting.Configuration;
using Fuchsbau.Components.Data.DataStoring.EF;
using Fuchsbau.Components.Data.DataStoring.EF.Contexts;
using Fuchsbau.Components.Data.FileStorage;
using Fuchsbau.Components.Logic.ProjectManagement.Contract;
using Fuchsbau.Components.Logic.SecurityManagement;
using Fuchsbau.Components.Logic.SecurityWorkflows;
using Fuchsbau.Components.Mappings.Mapping.Ninject;
//using Microsoft.Graph;

namespace Fuchsbau.Components.UI.ConsoleApp1
{
    class Program
    {
        static void Main( string[] args )
        {
            var kernel = new StandardKernel();
            new KernelInitializer().Initialize(kernel);

            var manager = kernel.Get<IProjectFileManager>();

            var messageBroker = new MessageBroker();
            var securityConfiguration = new Configuration();

            var file = new LocalFile("", "securityConfig.json");

            if (file.Exists())
            {
                string x = File.ReadAllText("", Encoding.UTF8);
            }                                           

            securityConfiguration.Set( "UserRules", "MinimumLength",3);
            securityConfiguration.Set( "UserRules", "MaximumLength", 20 );
            securityConfiguration.Set( "UserRules", "MinimumLetters", 0 );
            securityConfiguration.Set( "UserRules", "MinimumDigits", 0 );
            securityConfiguration.Set( "UserRules", "MinimumSpecialChars", 0 );
                
            securityConfiguration.Set( "UserGroupRules", "MinimumLength", 3 );
            securityConfiguration.Set( "UserGroupRules", "MaximumLength", 20 );
            securityConfiguration.Set( "UserGroupRules", "MinimumLetters", 0 );
            securityConfiguration.Set( "UserGroupRules", "MinimumDigits", 0 );
            securityConfiguration.Set( "UserGroupRules", "MinimumSpecialChars", 0 );
                                                              
            securityConfiguration.Set( "PasswordRules", "MinimumLength", 8 );
            securityConfiguration.Set( "PasswordRules", "MaximumLength", 20 );
            securityConfiguration.Set( "PasswordRules", "MinimumLetters", 1 );
            securityConfiguration.Set( "PasswordRules", "MinimumDigits", 1 );
            securityConfiguration.Set( "PasswordRules", "MinimumSpecialChars", 1 );
            securityConfiguration.Set( "PasswordRules", "WillExpireAfterDays",365);
            securityConfiguration.Set( "PasswordRules", "ExpirationWarningDays", 365 );
            securityConfiguration.Set( "PasswordRules", "HistoryLength", 10 );
            securityConfiguration.Set( "PasswordRules", "ProhibitedPasswords", new[] {"1", "12", "123", "1234", "12345"});

            securityConfiguration.Set("LoginRules", "MaximumLoginAttempts", 3);
            securityConfiguration.Set("LoginRules", "ActionOnFailedLogin", new[] {"lock user", "lock system"});

            var securityPersistenceService = new SecurityContext();
            var userRepository = new UserRepository(securityPersistenceService);
            var userManager = new UserManager(userRepository);
            var userWorkflow = new UserWorkflow(userManager, messageBroker);

            string userName = "";
            var userPassword = new SecureString();

            var userNameValidator = new UserNameValidator( securityConfiguration );
            var userPasswordValidator = new UserPasswordValidator();

            userNameValidator.Validate(userName);
            userPasswordValidator.Validate(userPassword.ToString());

            bool isAuthenticated = userWorkflow.SignIn(userName, userPassword);
                   

            //   // TODO: ValueObject
            //
            //   // TODO: OneDrive Dateiablage
            //   var test = new OneDriveReadFile();
            //
            //   var result = test.Exists( "" );

            Console.WriteLine();
        }
    }

}

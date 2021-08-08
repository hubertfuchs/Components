using System;
using Fuchsbau.Components.CrossCutting.Core.Contract;

namespace Fuchsbau.Components.CrossCutting.Core
{
    public class UserLoginFormExecutionMain : IExecutionMain
    {
        private readonly UserInterfaceFactory _userInterfaceFactory;
        private readonly Label _labelUserName;
        private readonly TextBox _textBoxUserName;
        private readonly Label _labelPassword;
        private readonly TextBox _textBoxPassword;

        public UserLoginFormExecutionMain(
            UserInterfaceFactory userInterfaceFactory )
        {
            _userInterfaceFactory = userInterfaceFactory ?? throw new ArgumentNullException( nameof( userInterfaceFactory ) );
            _labelUserName = _userInterfaceFactory.CreateLabel();
            _textBoxUserName = _userInterfaceFactory.CreateTextBox();
            _labelPassword = _userInterfaceFactory.CreateLabel();
            _textBoxPassword = _userInterfaceFactory.CreateTextBox();
        }

        public void Run()
        {
            // windows
            _labelUserName.Text = "Bitte geben Sie den Benutzernamen ein:";
            var userName = _textBoxUserName.Text;

            _labelPassword.Text = "Bitte das Passwort eingeben:";
            var password = _textBoxPassword.Text;

            // windows.controls.add()

            // windows.show();
        }
    }
}

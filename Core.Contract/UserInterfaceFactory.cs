namespace Fuchsbau.Components.CrossCutting.Core.Contract
{
    public abstract class UserInterfaceFactory
    {
        public UserInterfaceFactory()
        {
        }

        public abstract TextBox CreateTextBox();
        public abstract Label CreateLabel();
    }
}

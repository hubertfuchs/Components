namespace Fuchsbau.Components.CrossCutting.Core.Contract
{
    public class ConsoleUserInterfaceFactory : UserInterfaceFactory
    {
        public ConsoleUserInterfaceFactory()
        {
        }

        public override Label CreateLabel()
        {
            return new ConsoleLabel();
        }

        public override TextBox CreateTextBox()
        {
            return new ConsoleTextBox();
        }


    }
}

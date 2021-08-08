using System;

namespace Fuchsbau.Components.CrossCutting.Core.Contract
{
    public class ConsoleTextBox : TextBox
    {
        public ConsoleTextBox()
        {
        }

        public override string Text
        {
            get
            {
                if( base.Text == string.Empty )
                    base.Text = Console.ReadLine();
                return base.Text;
            }
            set
            {
                base.Text = value;
                Console.WriteLine( base.Text );
            }
        }
    }
}

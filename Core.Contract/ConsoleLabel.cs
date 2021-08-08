using System;

namespace Fuchsbau.Components.CrossCutting.Core.Contract
{
    public class ConsoleLabel : Label
    {
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

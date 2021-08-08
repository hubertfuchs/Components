using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Class1
    {
        public Class1()
        {
            string x = AppResources.String1;

            var cultureInfo = new CultureInfo("de-DE");
            string today = DateTime.Now.ToString("d", cultureInfo);

        }
    }
}

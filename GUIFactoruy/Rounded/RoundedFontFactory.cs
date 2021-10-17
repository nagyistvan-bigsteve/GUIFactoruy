using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIFactoruy.Rounded
{
    public class RoundedFontFactory : IThemeFactory
    {
        public Theme CreateButtons()
        {
            throw new NotImplementedException();
        }

        public Theme CreateWindows()
        {
            return new RoundedWindow();
        }
    }
}

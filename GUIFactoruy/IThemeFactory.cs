using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIFactoruy
{
    public interface IThemeFactory
    {
        Theme CreateButtons();
        Theme CreateWindows();
    }
}

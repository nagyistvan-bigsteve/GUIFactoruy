using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIFactoruy
{
    public interface ITheme
    {
        void CreateTheme();
        string No { get; }
    }
}

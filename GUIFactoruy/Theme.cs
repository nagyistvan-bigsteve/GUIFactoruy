using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIFactoruy
{
    public abstract class Theme
    {
        public string No { get; private set; }

        public double Radius { get; private set; }

        public TextStyle TextStyle { get; private set; }


        protected Theme(TextStyle style, double rad)
        {
            TextStyle = style;
            Radius = rad;
            CreateTheme();
        }

        private void CreateTheme()
        {
            No = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{GetType()} with No: {No} is with {TextStyle}. \r and have {Radius} radius.";
        }
    }
}

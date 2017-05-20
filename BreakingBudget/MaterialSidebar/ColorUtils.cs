using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MaterialSidebar
{
    public class ColorUtils
    {
        public static HSLColor Darken(HSLColor color, int percentage)
        {
            color.Luminosity -= percentage * 2.55;  // percentage to a 0xFF value
            return color;
        }

        public static HSLColor Lighten(HSLColor color, int percentage)
        {
            color.Saturation += percentage * 2.55;
            return color;
        }
    }
}

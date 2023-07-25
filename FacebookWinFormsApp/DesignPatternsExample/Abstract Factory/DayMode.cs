using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class DayMode : IStyleFactory
    {
        public Color BackgroundColor()
        {
            return Color.LightBlue;
        }

        public Color ButtonColor()
        {
            return Color.White;
        }

        public Color TextColor()
        {
            return Color.Black;
        }
    }
}

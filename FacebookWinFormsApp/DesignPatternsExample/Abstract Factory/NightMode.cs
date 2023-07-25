using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class NightMode : IStyleFactory
    {
        public Color BackgroundColor()
        {
            return Color.DimGray;
        }

        public Color ButtonColor()
        {
            return Color.DarkGray;
        }

        public Color TextColor()
        {
            return Color.White;
        }
    }
}

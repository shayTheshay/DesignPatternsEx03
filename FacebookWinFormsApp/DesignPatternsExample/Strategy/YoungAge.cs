using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    internal class YoungAge:IAgeStrategy
    {
        public object AgeDecidingMethod()
        {
            List<string> FontList = new List<string>()
            {
                "Gill Sans Ultra Bold",
                "Gill Sans MT",
                "Guttman",
                "Gigi",
                "Guttman",
                "Gisha"

            };

            Random rnd = new Random();
            int num = rnd.Next(10, 12);
            int RandomFontNumber = rnd.Next(0, 5);

            string RandomFont = FontList[RandomFontNumber];
            List<object> FontAndSize = new List<object>()
            {
                num,
                RandomFont
            };

            return FontAndSize;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    internal class AdultAge:IAgeStrategy
    {
        public object AgeDecidingMethod()
        {
            
            
            List<string> FontList = new List<string>()
            {
                "Chiller",
                "Calibri",
                "Cambria",
                "Vivaldi",
                "Rage Italic",
                "Pristina"

            };

            Random rnd = new Random();
            int num = rnd.Next(13, 15);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    internal class SeniorAge:IAgeStrategy
    {
        public object AgeDecidingMethod()
        {
            List<string> FontList = new List<string>()
            {
                "Fraklin Gothic Medium",
                "Fraklin Gothic Book",
                "Fraklin Gothic Demi",
                "Century Schoolbook",
                "Magneto",
                "Garamond"

            };

            Random rnd = new Random();
            int num = rnd.Next(16, 20);
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

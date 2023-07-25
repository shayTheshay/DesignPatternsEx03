using BasicFacebookFeatures.Subforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.Structs;
using static BasicFacebookFeatures.Subforms.FormAgeRangeCheck;

namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    internal class AgeFactory
    {
        private Context _context;
        public static object MakeAge(FormAgeRangeCheck.eAgeRange i_AgeType)
        {
            var contextV = new Context();

            object values = null;
            switch (i_AgeType)
            {
                case eAgeRange.Young:
                    contextV.SetStrategy(new YoungAge());
                    break;
                case eAgeRange.Adult:
                    contextV.SetStrategy(new AdultAge());
                    break;
                case eAgeRange.Senior:
                    contextV.SetStrategy(new SeniorAge());
                    break;
            }

            values = contextV.strategy.AgeDecidingMethod();
            return values;
        }
    }


}

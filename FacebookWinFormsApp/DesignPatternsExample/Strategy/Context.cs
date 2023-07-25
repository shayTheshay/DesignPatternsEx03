using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    public class Context
    {
        public IAgeStrategy strategy;


        public Context(IAgeStrategy strategy)
        {

            this.strategy = strategy;
        }

        public Context()
        {
            
        }

        public void SetStrategy(IAgeStrategy strategy)
        {
            this.strategy = strategy;
        }
        

        public object AgeGetter(object data)
        {
            return strategy.AgeDecidingMethod();
        }

    }
}

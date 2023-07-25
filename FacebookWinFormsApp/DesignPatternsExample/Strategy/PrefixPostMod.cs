using System.Runtime.Remoting.Messaging;

namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    public class PrefixPostMod : IPostModStrategy
    {
        public string ModifyText(string i_Text, string i_Context)
        {
            return i_Context + i_Text;
        }
    }
}
using System.Runtime.Remoting.Messaging;

namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    public class SuffixPostMod : IPostModStrategy
    {
        public string ModifyText(string i_Text, string i_Context)
        {
            return i_Text + i_Context;
        }
    }
}
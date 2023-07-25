using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.DesignPatternsExample.Strategy
{
    public enum PostModTypes
    {
        Prefix,
        Suffix,
        LeetSpeak
    }
    public class PostModFactory
    {
        public static IPostModStrategy CreatePostMod(PostModTypes i_PostModType)
        {
            IPostModStrategy postModStrategy = null;
            switch(i_PostModType)
            {
                case PostModTypes.Prefix:
                    postModStrategy = new PrefixPostMod();
                    break;
                case PostModTypes.Suffix:
                    postModStrategy = new SuffixPostMod();
                    break;
                case PostModTypes.LeetSpeak:
                    postModStrategy = new LeetSpeakPostMod();
                    break;
            }
            
            return postModStrategy;
        }

    }
}

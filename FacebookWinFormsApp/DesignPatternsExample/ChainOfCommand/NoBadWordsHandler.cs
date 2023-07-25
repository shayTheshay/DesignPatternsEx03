using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class NoBadWordsHandler : GroupBaseHandler
    {
        private List<String> r_BadWords = new List<string>() {"C++"};

        public NoBadWordsHandler(List<string> i_BadWords)
        {
            this.r_BadWords = i_BadWords;
        }

        public override Boolean handle(User i_User, Group i_Group, String i_PostMessage)
        {
            if (this.PhraseIsClean(i_PostMessage) == false)
            {
                return false;
            }
            return handleNext(i_User, i_Group, i_PostMessage);
        }


        private bool PhraseIsClean(String i_PostMessage)
        {
            string lowerPhrase = i_PostMessage.ToLower();
            bool returnValue = true;

            foreach (string word in this.r_BadWords)
            {
                if (returnValue == true && lowerPhrase.Contains(word.ToLower()))
                {
                    returnValue = false;
                }
            }

            return returnValue; 
        }

    }
}

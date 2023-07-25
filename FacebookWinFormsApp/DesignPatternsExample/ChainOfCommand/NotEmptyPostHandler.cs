using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class NotEmptyPostHandler : GroupBaseHandler
    {
        public override Boolean handle(User i_User, Group i_Group, String i_PostMessage)
        {
            if (i_PostMessage == "")
            {
                return false;
            }
            return handleNext(i_User, i_Group, i_PostMessage);
        }
    }
}

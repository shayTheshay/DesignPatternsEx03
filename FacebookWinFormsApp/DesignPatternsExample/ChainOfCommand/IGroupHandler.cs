using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IGroupHandler
    {
        IGroupHandler setNextHandler(IGroupHandler i_Next);
        Boolean handle(User i_User, Group i_Group, String i_PostMessage);
    }
}

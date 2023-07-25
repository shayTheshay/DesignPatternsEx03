using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public abstract class GroupBaseHandler : IGroupHandler
    {
        private IGroupHandler next;

        public IGroupHandler setNextHandler (IGroupHandler i_Next)
        {
            this.next = i_Next;
            return next;
        }

        public abstract Boolean handle(User i_User, Group i_Group, String i_PostMessage);
        
        protected Boolean handleNext (User i_User, Group i_Group, String i_PostMessage)
        {
            if (next == null)
            {
                return true;
            }
            return next.handle(i_User, i_Group, i_PostMessage);
        }
    }
}

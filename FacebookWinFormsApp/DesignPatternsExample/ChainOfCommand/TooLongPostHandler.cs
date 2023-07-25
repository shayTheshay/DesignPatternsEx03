﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class TooLongPostHandler : GroupBaseHandler
    {
        private int r_MaxCharacterLength = 200;

        public TooLongPostHandler(int i_MaxCharacterLength)
        {
            r_MaxCharacterLength=i_MaxCharacterLength;
        }

        public override Boolean handle(User i_User, Group i_Group, String i_PostMessage)
        {
            if (i_PostMessage.Length > r_MaxCharacterLength)
            {
                return false;
            }
            return handleNext(i_User, i_Group, i_PostMessage);
        }
    }
}

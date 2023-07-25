using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Subforms;

namespace BasicFacebookFeatures
{
    public enum eFormType
    {
        album_cross_post,
        album_view,
        group_cross_post,
        group_view,
        liked_pages,
        user_details
    }
    public class FormFactory
    {
        public static Form MakeForm(eFormType i_FormType)
        {
            Form form = null;
            switch (i_FormType)
            {
                case eFormType.album_cross_post:
                    form = new FormAlbumCrosspost();
                    break;
                case eFormType.album_view:
                    form = new FormAlbumView();
                    break;
                case eFormType.group_cross_post:
                    form = new FormGroupCrossPost();
                    break;
                case eFormType.group_view:
                    form = new FormGroupView();
                    break;
                case eFormType.liked_pages:
                    form = new FormLikedPages();
                    break;
                case eFormType.user_details:
                    form = new FormUserDetails();
                    break;
            }
            return form;
        }
    }
}

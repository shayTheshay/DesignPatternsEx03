using BasicFacebookFeatures.Subforms;
using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : FormWithSettingsProxy
    {
        private UserSession m_Session = UserSession.getInstance();
        private readonly string r_AppID = "888590382221810";

        public FormMain()
        {
            m_Session.LoginSuccess += enableAllButtons;
            m_Session.LoginFailure += () => MessageBox.Show(m_Session.LoginResult.ErrorMessage, "Login Failed");
            InitializeComponent();
            disableAllButtons();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_Session.InitializeSession(r_AppID);
        }

         
         private void buttonLogout_Click(object sender, EventArgs e)
         { 
            FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
            m_Session.LogOut();
            disableAllButtons();
         }

         private void disableAllButtons()
         {
             foreach(Object obj in this.Controls)
             {
                 if(obj.GetType() == typeof(Button))
                 {
                     ((Button)obj).Enabled = false;
                 }

                 buttonLogin.Enabled = true;
                 switchStyle.Enabled = true;
             }
         }

         private void enableAllButtons()
        {
            foreach (Object obj in this.Controls)
            {
                if (obj.GetType() == typeof(Button))
                {
                    ((Button)obj).Enabled = true;
                }
            }

            buttonLogin.Enabled = false;
        }

        private void buttonUserDetails_Click(object sender, EventArgs e)
        {   
            FormFactory.MakeForm(eFormType.user_details).ShowDialog();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            FormFactory.MakeForm(eFormType.group_view).ShowDialog();
        }

        private void buttonCrossPost_Click(object sender, EventArgs e)
        {
            FormFactory.MakeForm(eFormType.group_cross_post).ShowDialog();
        }

        private void AlbumsButtonView_Click(object sender, EventArgs e)
        {
           FormFactory.MakeForm(eFormType.album_view).ShowDialog();
        }
        
        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            FormFactory.MakeForm(eFormType.liked_pages).ShowDialog();
        }
        
        private void buttonSwapAlbumPictures_Click(object sender, EventArgs e)
        {
            FormFactory.MakeForm(eFormType.album_cross_post).ShowDialog();
        }

        private void switchStyle_Click(object sender, EventArgs e)
        {
            AppSettings.getInstance().SwitchStyleFactory();

        }
    }
}

using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Subforms
{
    public partial class FormUserDetails : FormWithSettingsProxy
    {
        private readonly UserSession r_Session = UserSession.getInstance() ;

        public FormUserDetails()
        {
            InitializeComponent();
            this.Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            fetchAndDisplayUserInfo();
        }

        private void fetchAndDisplayUserInfo()
        {
            labelAge.Text = getAge().ToString();
            labelGender.Text = r_Session.User.Gender.ToString();
            labelFriendCount.Text = r_Session.User.Friends.Count.ToString();
            labelRelashionship.Text = r_Session.User.RelationshipStatus.ToString();

            userBindingSource.DataSource =  r_Session.User;
            cityBindingSource.DataSource = r_Session.User.Location;
        }

        private int getAge()
        {
            int agecurr = 0;
            if (r_Session.User.Birthday != null)
            {
                DateTime birthday = new DateTime();
                try
                {
                    birthday = DateTime.ParseExact(r_Session.User.Birthday, "dd/MM/yyyy", null);
                }
                catch
                {
                    birthday = DateTime.ParseExact(r_Session.User.Birthday, "MM/dd/yyyy", null);
                }

                DateTime today = DateTime.Today;
                agecurr = today.Year - birthday.Year;
                if (birthday > today.AddYears(-agecurr))
                    agecurr--;

            }
            return agecurr;
        }
    }
}

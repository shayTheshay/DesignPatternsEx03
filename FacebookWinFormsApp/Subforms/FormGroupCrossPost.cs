using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Subforms
{
    public partial class FormGroupCrossPost : FormWithSettingsProxy
    {
        private readonly UserSession r_Session = UserSession.getInstance();
        private Group m_SelectedGroupFrom;
        private Group m_SelectedGroupTo;
        private String m_SelectedPost;
        private readonly GroupManager r_GroupManager;
        public FormGroupCrossPost()
        {
            r_GroupManager = new GroupManager(r_Session.User);
            r_GroupManager.ErrorCallbacks += notAdminError;
            InitializeComponent(); 
            this.Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            new Thread(() => r_GroupManager.FetchUserGroupsToListBox(listBoxGroupsFrom)).Start();
            //listBoxGroupsFrom.Invoke(new Action(() => r_GroupManager.FetchUserGroupsToListBox(listBoxGroupsFrom)));
            new Thread(() =>r_GroupManager.FetchUserGroupsToListBox(listBoxGroupsTo)).Start();

            listBoxGroupsTo.Items.AddRange(listBoxGroupsFrom.Items);
        }

        private void listBoxGroupsFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedPost = null;
            m_SelectedGroupFrom = (Group)listBoxGroupsFrom.SelectedItem;
            r_GroupManager.FetchUserStatusesInGroupToListBox(m_SelectedGroupFrom,listBoxStatuses);

        }
        private void listBoxGroupsTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonCrossPost.Enabled = true;
            m_SelectedGroupTo = (Group)listBoxGroupsTo.SelectedItem;
        }
        private void listBoxStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedPost = listBoxStatuses.SelectedItem.ToString();
        }
        private void buttonCrossPost_Click(object sender, EventArgs e)
        {
           r_GroupManager.PostToGroup(m_SelectedGroupTo,m_SelectedPost);
           r_GroupManager.FetchUserStatusesInGroupToListBox(m_SelectedGroupFrom, listBoxStatuses);
        }
        private void notAdminError()
        {
            MessageBox.Show("Cannot get information from group without admin permissions");
            buttonCrossPost.Enabled = false;
        }
    }
}

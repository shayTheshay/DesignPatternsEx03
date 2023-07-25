using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.DesignPatternsExample.Strategy;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures.Subforms
{
    public partial class FormGroupView : FormWithSettingsProxy
    {
        private readonly UserSession r_Session = UserSession.getInstance();
        private Group m_SelectedGroup;
        private readonly GroupManager r_GroupManager;
        private IPostModStrategy m_Strategy = null;
        private string m_StrategyContext = null;

        public FormGroupView()
        {
            r_GroupManager = new GroupManager(r_Session.User);
            r_GroupManager.ErrorCallbacks += notAdminError;
            r_GroupManager.GroupHandler = new NotEmptyPostHandler();
            r_GroupManager.GroupHandler.setNextHandler(new TooLongPostHandler(50)).
                                       setNextHandler(new NoBadWordsHandler(new List<string>() { "fuck","shit","tits" }));

            InitializeComponent();
            this.Shown += OnShown;
        }
        private void OnShown(object sender, EventArgs e)
        {
            new Thread(() => r_GroupManager.FetchUserGroupsToListBox(listBoxGroups)).Start();
        }
        
        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedGroup = (Group)listBoxGroups.SelectedItem;
            buttonPost.Enabled = true;
            r_GroupManager.FetchUserStatusesInGroupToListBox(m_SelectedGroup, listBoxStatuses);
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            string post = textBoxStatus.Text;
            if(m_Strategy != null)
                post = m_Strategy.ModifyText(post, m_StrategyContext);
            r_GroupManager.PostToGroup(m_SelectedGroup, post);
            r_GroupManager.FetchUserStatusesInGroupToListBox(m_SelectedGroup, listBoxStatuses);
        }
        private void notAdminError()
        {
            MessageBox.Show("Cannot get information from group without admin permissions");
            buttonPost.Enabled = false;
        }

        private void leetButton_CheckedChanged(object sender, EventArgs e)
        {
            if(leetButton.Checked)
            {
                m_Strategy = PostModFactory.CreatePostMod(PostModTypes.LeetSpeak);
            }
        }

        private void noStrategy_CheckedChanged(object sender, EventArgs e)
        {
            if(noStrategy.Checked)
            {
                m_Strategy = null;
            }
        }

        private void prefixButton_CheckedChanged(object sender, EventArgs e)
        {
            if(prefixButton.Checked)
            {
                m_Strategy = PostModFactory.CreatePostMod(PostModTypes.Prefix);
            }

            prefixTextBox.Enabled = prefixButton.Checked;
            m_StrategyContext = prefixTextBox.Text;
        }

        private void suffixButton_CheckedChanged(object sender, EventArgs e)
        {
            if (suffixButton.Checked)
            {
                m_Strategy = PostModFactory.CreatePostMod(PostModTypes.Suffix);
            }

            suffixTextBox.Enabled = suffixButton.Checked;
            m_StrategyContext = suffixTextBox.Text;
        }

        private void suffixTextBox_TextChanged(object sender, EventArgs e)
        {
            m_StrategyContext = suffixTextBox.Text;
        }

        private void prefixTextBox_TextChanged(object sender, EventArgs e)
        {
            m_StrategyContext = prefixTextBox.Text;
        }
    }
}

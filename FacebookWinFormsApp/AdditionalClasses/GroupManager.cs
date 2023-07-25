using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public delegate void OnAuthErrorEventHandler();

    class GroupManager
    {
        private readonly User r_User;

        private IGroupHandler m_GroupHandler = null;
        public IGroupHandler GroupHandler { 
            get { return m_GroupHandler;}
            set { m_GroupHandler = value; }
        }
        public event OnAuthErrorEventHandler ErrorCallbacks;

        public GroupManager(User i_User)
        {
            r_User = i_User;
        }


        public void FetchUserGroupsToListBox(ListBox i_ListBox)
        {
            i_ListBox.Invoke(new Action(() => i_ListBox.Items.Clear()));
            i_ListBox.Invoke(new Action(() => i_ListBox.DisplayMember = "Name"));

            try
            {
                foreach (Group group in r_User.Groups)
                {
                    i_ListBox.Invoke(new Action(() => i_ListBox.Items.Add(group)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if ((int)i_ListBox.Invoke(new Func<int>(() => i_ListBox.Items.Count)) == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }


        public void FetchUserStatusesInGroupToListBox(Group i_Group, ListBox i_ListBoxStatuses)
        {
            i_ListBoxStatuses.Items.Clear();

            try
            {
                foreach(Post post in i_Group.WallPosts)
                {
                    string currPost = "";
                    if(post.From.Id == r_User.Id)
                    {
                        if(post.Message != null)
                        {
                            currPost = post.Message;
                        }
                        else if(post.Caption != null)
                        {
                            currPost = post.Caption;
                        }
                        else
                        {
                            currPost = string.Format("[{0}]", post.Type);
                        }

                        if(GroupHandler == null || GroupHandler.handle(r_User, i_Group, currPost) == true)
                            i_ListBoxStatuses.Items.Add(currPost);
                    }
                }
            }
            catch(FacebookOAuthException ex)
            {
                OnAuthError();
            }
        }


        public void PostToGroup(Group i_Group,String i_PostMessage)
        {
            try
            {
                if (GroupHandler == null || GroupHandler.handle(r_User,i_Group,i_PostMessage) == true)
                {
                    Post postedStatus = i_Group.PostToWall(i_PostMessage);
                    i_Group.ReFetch();
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                }
                else
                {
                   MessageBox.Show("Failed to handle post");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! Status posted unsuccssefuly! Probable cause:"
                                + "Tried to post to group you have no admin permissions to");
            }
        }

        protected virtual void OnAuthError()
        {
            if (ErrorCallbacks != null)
                ErrorCallbacks.Invoke();
        }
    }
}

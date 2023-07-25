using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Subforms
{
    public partial class FormAlbumCrosspost : FormWithSettingsProxy
    {
        private readonly UserSession r_UserSession = UserSession.getInstance();
        private readonly AlbumManager r_AlbumManager;

        public FormAlbumCrosspost()
        {
            this.r_AlbumManager = new AlbumManager(r_UserSession.User);
            InitializeComponent();
            this.Shown += OnShown;

        }

        public void OnShown(Object sender, EventArgs e)
        {
           new Thread(() =>r_AlbumManager.fetchAlbums(listBoxSelectedFromAlbum)).Start();
           new Thread(() =>r_AlbumManager.fetchAlbums(ListBoxSelectedToAlbum)).Start();

        }

        private void listBoxFromAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(() =>r_AlbumManager.fetchPictures(listBoxSelectedPicture, listBoxSelectedFromAlbum)).Start();
            pictureBoxShowAlbumPictureAdd.Image = null;
            buttonAddPictureTo.Enabled = false;
        }
        private void listBoxSelectedPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSelectedPicture.DisplayMember = "Name";
            r_AlbumManager.presentPicturesInsdieAlbum(listBoxSelectedPicture, pictureBoxShowAlbumPictureAdd);
            ListBoxSelectedToAlbum.Enabled = true;
            if (ListBoxSelectedToAlbum.Items.Count >= 1)
            {
                ListBoxSelectedToAlbum_SelectedIndexChanged(sender, e);
            }

        }

       private void ListBoxSelectedToAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxSelectedPicture.SelectedItems.Count == 1)
                buttonAddPictureTo.Enabled = true;
        }

        private void buttonAddPictureTo_Click(object sender, EventArgs e)
        {
            // Upload Photo currently disabled: Enable if permissions in the future will allow again
            //var selectedPhoto = listBoxSelectedPicture.SelectedItem;
            //m_toAlbum.UploadPhoto(selectedPhoto.ToString());
            MessageBox.Show("The permission relevant for the posting of a picture into album (post_actions) is depricated thus making the action unavailable \n what I would have done is take the format specified.\nThen adjust to the format and upload");
        }

 
    }
}


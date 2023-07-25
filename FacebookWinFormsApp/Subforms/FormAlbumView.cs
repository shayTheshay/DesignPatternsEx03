using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Subforms
{
    public partial class FormAlbumView : FormWithSettingsProxy
    {
        private readonly UserSession r_UserSession = UserSession.getInstance();
        private readonly AlbumManager r_AlbumManager;

        public FormAlbumView()
        {
            this.r_AlbumManager = new AlbumManager(r_UserSession.User);
            InitializeComponent();
            this.Shown += OnShown;
        }

        private void OnShown(Object sender, EventArgs e)
        {
            new Thread(() => r_AlbumManager.fetchAlbums(listBoxAlbumsShow)).Start();
        }

        private void listBoxAlbumsShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_AlbumManager.presentAlbumImages(listBoxAlbumsShow, pictureBoxAlbum);

            new Thread(() => { r_AlbumManager.fetchPictures(listBoxImageAlbum, listBoxAlbumsShow); }).Start();
            pictureBoxPicture.Image = null;
         
        }

        private void listBoxImageAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_AlbumManager.presentPicturesInsdieAlbum(listBoxImageAlbum, pictureBoxPicture);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{

    public class AlbumManager
    {
        private readonly User r_User;

        public AlbumManager(User i_User)
        {
            this.r_User = i_User;

        }


        public void fetchAlbums(ListBox listBoxAlbumShow)
        {
            listBoxAlbumShow.Invoke(new Action(() => listBoxAlbumShow.Items.Clear()));
            listBoxAlbumShow.Invoke(new Action(() => listBoxAlbumShow.DisplayMember = "Name"));
            foreach (Album album in r_User.Albums)
            {
                listBoxAlbumShow.Invoke(new Action(() => listBoxAlbumShow.Items.Add(album)));
                album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (listBoxAlbumShow.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve");
            }
        }
        public void presentAlbumImages(ListBox listBoxAlbumsShow, PictureBox pictureBoxAlbum)
        {
            if (listBoxAlbumsShow.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbumsShow.SelectedItem as Album;
                if (selectedAlbum != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureSmallURL);
                }
                else
                {
                    pictureBoxAlbum.Image = pictureBoxAlbum.ErrorImage;
                }

            }

        }


        public void fetchPictures(ListBox i_ListBoxPicturesShow, ListBox i_ListBoxAlbumsShow)
        {
            try
            {   
                i_ListBoxPicturesShow.Invoke(new Action(() => i_ListBoxPicturesShow.Items.Clear()));
                i_ListBoxPicturesShow.Invoke(new Action(() => i_ListBoxPicturesShow.DisplayMember = "Name"));
                Album selectedAlbum = (Album)i_ListBoxAlbumsShow.Invoke(new Func<Album>(() => (Album)i_ListBoxAlbumsShow.SelectedItem));
                if (selectedAlbum != null) {
                    FacebookObjectCollection<Photo> selectedAlbumPictures = selectedAlbum?.Photos;
                    foreach (Photo picture in selectedAlbumPictures)
                    {
                        i_ListBoxPicturesShow.Invoke(new Action(() => i_ListBoxPicturesShow.Items.Add(picture.PictureAlbumURL)));

                    }
                }
                int check = (int)i_ListBoxPicturesShow.Invoke(new Func<int>(() => i_ListBoxPicturesShow.Items.Count));
                if(check == 0)
                {
                    MessageBox.Show("No Pictures to retrieve");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An Error accured");
            }
        }

        public void presentPicturesInsdieAlbum(ListBox i_ListBoxPicturesShow, PictureBox pictureBoxPictures)
        {
            if (i_ListBoxPicturesShow.SelectedItems.Count == 1)
            {
                var selectedPhoto = i_ListBoxPicturesShow.SelectedItem;
                if (selectedPhoto != null)
                {
                    pictureBoxPictures.LoadAsync(selectedPhoto.ToString());
                }
                else
                {
                    pictureBoxPictures.Image = pictureBoxPictures.ErrorImage;
                }
            }
        }


    }
}
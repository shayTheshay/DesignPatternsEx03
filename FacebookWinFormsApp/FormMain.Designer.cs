namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonUserDetails = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonCrossPost = new System.Windows.Forms.Button();
            this.buttonAlbumPhotos = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.buttonSwapAlbumPictures = new System.Windows.Forms.Button();
            this.switchStyle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(12, 14);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 35);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.Location = new System.Drawing.Point(309, 14);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonUserDetails
            // 
            this.buttonUserDetails.BackColor = System.Drawing.Color.White;
            this.buttonUserDetails.Enabled = false;
            this.buttonUserDetails.ForeColor = System.Drawing.Color.Black;
            this.buttonUserDetails.Location = new System.Drawing.Point(12, 99);
            this.buttonUserDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserDetails.Name = "buttonUserDetails";
            this.buttonUserDetails.Size = new System.Drawing.Size(268, 35);
            this.buttonUserDetails.TabIndex = 59;
            this.buttonUserDetails.Text = "User Details";
            this.buttonUserDetails.UseVisualStyleBackColor = false;
            this.buttonUserDetails.Click += new System.EventHandler(this.buttonUserDetails_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.White;
            this.buttonGroups.Enabled = false;
            this.buttonGroups.ForeColor = System.Drawing.Color.Black;
            this.buttonGroups.Location = new System.Drawing.Point(12, 159);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(268, 35);
            this.buttonGroups.TabIndex = 60;
            this.buttonGroups.Text = "View Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonCrossPost
            // 
            this.buttonCrossPost.BackColor = System.Drawing.Color.White;
            this.buttonCrossPost.Enabled = false;
            this.buttonCrossPost.ForeColor = System.Drawing.Color.Black;
            this.buttonCrossPost.Location = new System.Drawing.Point(309, 159);
            this.buttonCrossPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCrossPost.Name = "buttonCrossPost";
            this.buttonCrossPost.Size = new System.Drawing.Size(268, 35);
            this.buttonCrossPost.TabIndex = 61;
            this.buttonCrossPost.Text = "Cross Post Between Groups";
            this.buttonCrossPost.UseVisualStyleBackColor = false;
            this.buttonCrossPost.Click += new System.EventHandler(this.buttonCrossPost_Click);
            // 
            // buttonAlbumPhotos
            // 
            this.buttonAlbumPhotos.BackColor = System.Drawing.Color.White;
            this.buttonAlbumPhotos.Enabled = false;
            this.buttonAlbumPhotos.ForeColor = System.Drawing.Color.Black;
            this.buttonAlbumPhotos.Location = new System.Drawing.Point(13, 222);
            this.buttonAlbumPhotos.Name = "buttonAlbumPhotos";
            this.buttonAlbumPhotos.Size = new System.Drawing.Size(268, 35);
            this.buttonAlbumPhotos.TabIndex = 63;
            this.buttonAlbumPhotos.Text = "View Albums";
            this.buttonAlbumPhotos.UseVisualStyleBackColor = false;
            this.buttonAlbumPhotos.Click += new System.EventHandler(this.AlbumsButtonView_Click);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.BackColor = System.Drawing.Color.White;
            this.buttonLikedPages.Enabled = false;
            this.buttonLikedPages.ForeColor = System.Drawing.Color.Black;
            this.buttonLikedPages.Location = new System.Drawing.Point(309, 99);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(268, 35);
            this.buttonLikedPages.TabIndex = 64;
            this.buttonLikedPages.Text = "Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = false;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // buttonSwapAlbumPictures
            // 
            this.buttonSwapAlbumPictures.BackColor = System.Drawing.Color.White;
            this.buttonSwapAlbumPictures.Enabled = false;
            this.buttonSwapAlbumPictures.ForeColor = System.Drawing.Color.Black;
            this.buttonSwapAlbumPictures.Location = new System.Drawing.Point(309, 222);
            this.buttonSwapAlbumPictures.Name = "buttonSwapAlbumPictures";
            this.buttonSwapAlbumPictures.Size = new System.Drawing.Size(268, 35);
            this.buttonSwapAlbumPictures.TabIndex = 65;
            this.buttonSwapAlbumPictures.Text = "Cross Post Between Albums";
            this.buttonSwapAlbumPictures.UseVisualStyleBackColor = false;
            this.buttonSwapAlbumPictures.Click += new System.EventHandler(this.buttonSwapAlbumPictures_Click);
            // 
            // switchStyle
            // 
            this.switchStyle.BackColor = System.Drawing.Color.White;
            this.switchStyle.Enabled = false;
            this.switchStyle.ForeColor = System.Drawing.Color.Black;
            this.switchStyle.Location = new System.Drawing.Point(161, 301);
            this.switchStyle.Name = "switchStyle";
            this.switchStyle.Size = new System.Drawing.Size(268, 35);
            this.switchStyle.TabIndex = 66;
            this.switchStyle.Text = "Switch Day/Night mode";
            this.switchStyle.UseVisualStyleBackColor = false;
            this.switchStyle.Click += new System.EventHandler(this.switchStyle_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 392);
            this.Controls.Add(this.switchStyle);
            this.Controls.Add(this.buttonSwapAlbumPictures);
            this.Controls.Add(this.buttonLikedPages);
            this.Controls.Add(this.buttonAlbumPhotos);
            this.Controls.Add(this.buttonCrossPost);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.buttonUserDetails);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook - MainMenu";
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonUserDetails;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonCrossPost;
        private System.Windows.Forms.Button buttonAlbumPhotos;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonSwapAlbumPictures;
        private System.Windows.Forms.Button switchStyle;
    }
}


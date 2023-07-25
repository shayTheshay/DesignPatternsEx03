using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FormWithSettingsProxy : Form
    {
        public AppSettings r_AppSettings = AppSettings.getInstance();

        public FormWithSettingsProxy() : base()
        {
            r_AppSettings.OnStyleChanged += updateVisuals;
            this.Shown += OnShow;
        }

        private void OnShow(object sender, EventArgs e)
        {
            updateVisuals();
        }

        private void updateVisuals()
        {
            this.BackColor = r_AppSettings.StyleFactory.BackgroundColor();
            foreach (Control obj in this.Controls)
            {

                    (obj).BackColor = r_AppSettings.StyleFactory.ButtonColor();
                    (obj).ForeColor = r_AppSettings.StyleFactory.TextColor();

            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormWithSettingsProxy
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "FormWithSettingsProxy";
            this.ResumeLayout(false);

        }
    }
}

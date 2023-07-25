using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Subforms
{
    public partial class FormAgeRangeCheck : FormWithSettingsProxy
    {

        public eAgeRange Age { get; set; }

        public FormAgeRangeCheck()
        {
            InitializeComponent();
        }




        public enum eAgeRange
        {
            Young,
            Adult,
            Senior
        }

        private void ButtonChooseAge_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rBtn in this.Controls.OfType<RadioButton>())
            {
                if (rBtn.Checked)
                {
                    switch (rBtn.Text.ToString())
                    {
                        case "0 - 14":
                            this.Age = eAgeRange.Young;
                            break;
                        case "15 - 64":
                            this.Age = eAgeRange.Adult;
                            break;
                        case "65+":
                            this.Age = eAgeRange.Senior;
                            break;
                        default:
                            MessageBox.Show("Failed, Default value entered");
                            this.Age = eAgeRange.Young;
                            break;
                    }

                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }


  


}

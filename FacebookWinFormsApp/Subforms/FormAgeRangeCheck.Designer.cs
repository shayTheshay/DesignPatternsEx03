namespace BasicFacebookFeatures.Subforms
{
    partial class FormAgeRangeCheck
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.radioButtonYoung = new System.Windows.Forms.RadioButton();
            this.radioButtonAdult = new System.Windows.Forms.RadioButton();
            this.radioButtonOld = new System.Windows.Forms.RadioButton();
            this.ButtonChooseAge = new System.Windows.Forms.Button();
            this.labelAgeExplainText = new System.Windows.Forms.Label();
            this.labelPressOkAfterSelectingAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // radioButtonYoung
            // 
            this.radioButtonYoung.AutoSize = true;
            this.radioButtonYoung.BackColor = System.Drawing.Color.White;
            this.radioButtonYoung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonYoung.ForeColor = System.Drawing.Color.Black;
            this.radioButtonYoung.Location = new System.Drawing.Point(17, 130);
            this.radioButtonYoung.Name = "radioButtonYoung";
            this.radioButtonYoung.Size = new System.Drawing.Size(83, 29);
            this.radioButtonYoung.TabIndex = 0;
            this.radioButtonYoung.TabStop = true;
            this.radioButtonYoung.Text = "0 - 14";
            this.radioButtonYoung.UseVisualStyleBackColor = false;
            // 
            // radioButtonAdult
            // 
            this.radioButtonAdult.AutoSize = true;
            this.radioButtonAdult.BackColor = System.Drawing.Color.White;
            this.radioButtonAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonAdult.ForeColor = System.Drawing.Color.Black;
            this.radioButtonAdult.Location = new System.Drawing.Point(194, 130);
            this.radioButtonAdult.Name = "radioButtonAdult";
            this.radioButtonAdult.Size = new System.Drawing.Size(94, 29);
            this.radioButtonAdult.TabIndex = 1;
            this.radioButtonAdult.TabStop = true;
            this.radioButtonAdult.Text = "15 - 64";
            this.radioButtonAdult.UseVisualStyleBackColor = false;
            // 
            // radioButtonOld
            // 
            this.radioButtonOld.AutoSize = true;
            this.radioButtonOld.BackColor = System.Drawing.Color.White;
            this.radioButtonOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonOld.ForeColor = System.Drawing.Color.Black;
            this.radioButtonOld.Location = new System.Drawing.Point(386, 130);
            this.radioButtonOld.Name = "radioButtonOld";
            this.radioButtonOld.Size = new System.Drawing.Size(67, 29);
            this.radioButtonOld.TabIndex = 2;
            this.radioButtonOld.TabStop = true;
            this.radioButtonOld.Text = "65+";
            this.radioButtonOld.UseVisualStyleBackColor = false;
            // 
            // ButtonChooseAge
            // 
            this.ButtonChooseAge.BackColor = System.Drawing.Color.White;
            this.ButtonChooseAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ButtonChooseAge.ForeColor = System.Drawing.Color.Black;
            this.ButtonChooseAge.Location = new System.Drawing.Point(392, 303);
            this.ButtonChooseAge.Name = "ButtonChooseAge";
            this.ButtonChooseAge.Size = new System.Drawing.Size(87, 37);
            this.ButtonChooseAge.TabIndex = 3;
            this.ButtonChooseAge.Text = "OK";
            this.ButtonChooseAge.UseVisualStyleBackColor = false;
            this.ButtonChooseAge.Click += new System.EventHandler(this.ButtonChooseAge_Click);
            // 
            // labelAgeExplainText
            // 
            this.labelAgeExplainText.AutoSize = true;
            this.labelAgeExplainText.BackColor = System.Drawing.Color.White;
            this.labelAgeExplainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeExplainText.ForeColor = System.Drawing.Color.Black;
            this.labelAgeExplainText.Location = new System.Drawing.Point(12, 50);
            this.labelAgeExplainText.Name = "labelAgeExplainText";
            this.labelAgeExplainText.Size = new System.Drawing.Size(441, 29);
            this.labelAgeExplainText.TabIndex = 4;
            this.labelAgeExplainText.Text = "Please select your group age accordinly";
            // 
            // labelPressOkAfterSelectingAge
            // 
            this.labelPressOkAfterSelectingAge.AutoSize = true;
            this.labelPressOkAfterSelectingAge.BackColor = System.Drawing.Color.White;
            this.labelPressOkAfterSelectingAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPressOkAfterSelectingAge.ForeColor = System.Drawing.Color.Black;
            this.labelPressOkAfterSelectingAge.Location = new System.Drawing.Point(43, 220);
            this.labelPressOkAfterSelectingAge.Name = "labelPressOkAfterSelectingAge";
            this.labelPressOkAfterSelectingAge.Size = new System.Drawing.Size(436, 25);
            this.labelPressOkAfterSelectingAge.TabIndex = 5;
            this.labelPressOkAfterSelectingAge.Text = "After selecting your group age please press \"OK\"";
            // 
            // FormAgeRangeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 362);
            this.Controls.Add(this.labelPressOkAfterSelectingAge);
            this.Controls.Add(this.labelAgeExplainText);
            this.Controls.Add(this.ButtonChooseAge);
            this.Controls.Add(this.radioButtonOld);
            this.Controls.Add(this.radioButtonAdult);
            this.Controls.Add(this.radioButtonYoung);
            this.Name = "FormAgeRangeCheck";
            this.Text = "FormAgeRangeCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.RadioButton radioButtonYoung;
        private System.Windows.Forms.RadioButton radioButtonAdult;
        private System.Windows.Forms.RadioButton radioButtonOld;
        private System.Windows.Forms.Button ButtonChooseAge;
        private System.Windows.Forms.Label labelAgeExplainText;
        private System.Windows.Forms.Label labelPressOkAfterSelectingAge;
    }
}
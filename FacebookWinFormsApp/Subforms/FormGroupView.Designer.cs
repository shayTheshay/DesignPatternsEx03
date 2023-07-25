namespace BasicFacebookFeatures.Subforms
{
    partial class FormGroupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupView));
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.listBoxStatuses = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noStrategy = new System.Windows.Forms.RadioButton();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.leetButton = new System.Windows.Forms.RadioButton();
            this.suffixButton = new System.Windows.Forms.RadioButton();
            this.prefixButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.BackColor = System.Drawing.Color.White;
            this.listBoxGroups.ForeColor = System.Drawing.Color.Black;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(21, 22);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(203, 224);
            this.listBoxGroups.TabIndex = 0;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.White;
            this.textBoxStatus.ForeColor = System.Drawing.Color.Black;
            this.textBoxStatus.Location = new System.Drawing.Point(241, 22);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(221, 26);
            this.textBoxStatus.TabIndex = 1;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.White;
            this.buttonPost.ForeColor = System.Drawing.Color.Black;
            this.buttonPost.Location = new System.Drawing.Point(256, 54);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(179, 35);
            this.buttonPost.TabIndex = 2;
            this.buttonPost.Text = "Post to selected group";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // listBoxStatuses
            // 
            this.listBoxStatuses.BackColor = System.Drawing.Color.White;
            this.listBoxStatuses.ForeColor = System.Drawing.Color.Black;
            this.listBoxStatuses.FormattingEnabled = true;
            this.listBoxStatuses.ItemHeight = 20;
            this.listBoxStatuses.Location = new System.Drawing.Point(241, 102);
            this.listBoxStatuses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxStatuses.Name = "listBoxStatuses";
            this.listBoxStatuses.Size = new System.Drawing.Size(224, 144);
            this.listBoxStatuses.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.noStrategy);
            this.panel1.Controls.Add(this.suffixTextBox);
            this.panel1.Controls.Add(this.prefixTextBox);
            this.panel1.Controls.Add(this.leetButton);
            this.panel1.Controls.Add(this.suffixButton);
            this.panel1.Controls.Add(this.prefixButton);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(490, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 280);
            this.panel1.TabIndex = 4;
            // 
            // noStrategy
            // 
            this.noStrategy.AutoSize = true;
            this.noStrategy.Location = new System.Drawing.Point(3, 209);
            this.noStrategy.Name = "noStrategy";
            this.noStrategy.Size = new System.Drawing.Size(117, 24);
            this.noStrategy.TabIndex = 5;
            this.noStrategy.TabStop = true;
            this.noStrategy.Text = "No Add ons";
            this.noStrategy.UseVisualStyleBackColor = true;
            this.noStrategy.CheckedChanged += new System.EventHandler(this.noStrategy_CheckedChanged);
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Enabled = false;
            this.suffixTextBox.Location = new System.Drawing.Point(13, 123);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(169, 26);
            this.suffixTextBox.TabIndex = 4;
            this.suffixTextBox.TextChanged += new System.EventHandler(this.suffixTextBox_TextChanged);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Enabled = false;
            this.prefixTextBox.Location = new System.Drawing.Point(13, 48);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(169, 26);
            this.prefixTextBox.TabIndex = 3;
            this.prefixTextBox.TextChanged += new System.EventHandler(this.prefixTextBox_TextChanged);
            // 
            // leetButton
            // 
            this.leetButton.AutoSize = true;
            this.leetButton.Location = new System.Drawing.Point(3, 155);
            this.leetButton.Name = "leetButton";
            this.leetButton.Size = new System.Drawing.Size(125, 24);
            this.leetButton.TabIndex = 2;
            this.leetButton.TabStop = true;
            this.leetButton.Text = "L33T SP3AK";
            this.leetButton.UseVisualStyleBackColor = true;
            this.leetButton.CheckedChanged += new System.EventHandler(this.leetButton_CheckedChanged);
            // 
            // suffixButton
            // 
            this.suffixButton.AutoSize = true;
            this.suffixButton.Location = new System.Drawing.Point(3, 80);
            this.suffixButton.Name = "suffixButton";
            this.suffixButton.Size = new System.Drawing.Size(107, 24);
            this.suffixButton.TabIndex = 1;
            this.suffixButton.TabStop = true;
            this.suffixButton.Text = "Add Suffix";
            this.suffixButton.UseVisualStyleBackColor = true;
            this.suffixButton.CheckedChanged += new System.EventHandler(this.suffixButton_CheckedChanged);
            // 
            // prefixButton
            // 
            this.prefixButton.AutoSize = true;
            this.prefixButton.Location = new System.Drawing.Point(3, 17);
            this.prefixButton.Name = "prefixButton";
            this.prefixButton.Size = new System.Drawing.Size(106, 24);
            this.prefixButton.TabIndex = 0;
            this.prefixButton.TabStop = true;
            this.prefixButton.Text = "Add Prefix";
            this.prefixButton.UseVisualStyleBackColor = true;
            this.prefixButton.CheckedChanged += new System.EventHandler(this.prefixButton_CheckedChanged);
            // 
            // FormGroupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxStatuses);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.listBoxGroups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGroupView";
            this.Text = "Facebook - Groups";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ListBox listBoxStatuses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton leetButton;
        private System.Windows.Forms.RadioButton suffixButton;
        private System.Windows.Forms.RadioButton prefixButton;
        private System.Windows.Forms.RadioButton noStrategy;
        private System.Windows.Forms.TextBox suffixTextBox;
        private System.Windows.Forms.TextBox prefixTextBox;
    }
}
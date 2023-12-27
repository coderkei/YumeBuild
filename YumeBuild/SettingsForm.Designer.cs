namespace YumeBuild
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.wingetCheck = new System.Windows.Forms.CheckBox();
            this.winget = new System.Windows.Forms.Label();
            this.contentO = new System.Windows.Forms.Label();
            this.wingetBox = new System.Windows.Forms.GroupBox();
            this.contentBox = new System.Windows.Forms.GroupBox();
            this.overrideBtn = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.selectContent = new System.Windows.Forms.FolderBrowserDialog();
            this.wingetBox.SuspendLayout();
            this.contentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // wingetCheck
            // 
            this.wingetCheck.AutoSize = true;
            this.wingetCheck.Location = new System.Drawing.Point(9, 41);
            this.wingetCheck.Name = "wingetCheck";
            this.wingetCheck.Size = new System.Drawing.Size(60, 17);
            this.wingetCheck.TabIndex = 0;
            this.wingetCheck.Text = "Winget";
            this.wingetCheck.UseVisualStyleBackColor = true;
            this.wingetCheck.CheckedChanged += new System.EventHandler(this.wingetCheck_CheckedChanged);
            // 
            // winget
            // 
            this.winget.AutoSize = true;
            this.winget.Location = new System.Drawing.Point(6, 25);
            this.winget.Name = "winget";
            this.winget.Size = new System.Drawing.Size(118, 13);
            this.winget.TabIndex = 1;
            this.winget.Text = "Winget Check Override";
            // 
            // contentO
            // 
            this.contentO.AutoSize = true;
            this.contentO.Location = new System.Drawing.Point(6, 25);
            this.contentO.Name = "contentO";
            this.contentO.Size = new System.Drawing.Size(112, 13);
            this.contentO.TabIndex = 2;
            this.contentO.Text = "Content Path Override";
            // 
            // wingetBox
            // 
            this.wingetBox.Controls.Add(this.winget);
            this.wingetBox.Controls.Add(this.wingetCheck);
            this.wingetBox.Location = new System.Drawing.Point(12, 116);
            this.wingetBox.Name = "wingetBox";
            this.wingetBox.Size = new System.Drawing.Size(200, 100);
            this.wingetBox.TabIndex = 3;
            this.wingetBox.TabStop = false;
            this.wingetBox.Text = "Winget Settings";
            // 
            // contentBox
            // 
            this.contentBox.Controls.Add(this.overrideBtn);
            this.contentBox.Controls.Add(this.contentO);
            this.contentBox.Location = new System.Drawing.Point(12, 10);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(200, 100);
            this.contentBox.TabIndex = 4;
            this.contentBox.TabStop = false;
            this.contentBox.Text = "Content Path Settings";
            // 
            // overrideBtn
            // 
            this.overrideBtn.Location = new System.Drawing.Point(9, 41);
            this.overrideBtn.Name = "overrideBtn";
            this.overrideBtn.Size = new System.Drawing.Size(109, 23);
            this.overrideBtn.TabIndex = 3;
            this.overrideBtn.Text = "Set Content Path";
            this.overrideBtn.UseVisualStyleBackColor = true;
            this.overrideBtn.Click += new System.EventHandler(this.overrideBtn_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(137, 222);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 5;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 252);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.wingetBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.wingetBox.ResumeLayout(false);
            this.wingetBox.PerformLayout();
            this.contentBox.ResumeLayout(false);
            this.contentBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox wingetCheck;
        private System.Windows.Forms.Label winget;
        private System.Windows.Forms.Label contentO;
        private System.Windows.Forms.GroupBox wingetBox;
        private System.Windows.Forms.GroupBox contentBox;
        private System.Windows.Forms.Button overrideBtn;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.FolderBrowserDialog selectContent;
    }
}
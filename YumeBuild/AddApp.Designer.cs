namespace YumeBuild
{
    partial class AddApp
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
            this.nameLab = new System.Windows.Forms.Label();
            this.infoLab = new System.Windows.Forms.Label();
            this.wingetNameLab = new System.Windows.Forms.Label();
            this.wingetLab = new System.Windows.Forms.Label();
            this.cmdLab = new System.Windows.Forms.Label();
            this.msiLab = new System.Windows.Forms.Label();
            this.pathLab = new System.Windows.Forms.Label();
            this.descLab = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.wingetNameBox = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.msiBox = new System.Windows.Forms.CheckBox();
            this.cmdBox = new System.Windows.Forms.CheckBox();
            this.wingetBox = new System.Windows.Forms.CheckBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Location = new System.Drawing.Point(12, 9);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(35, 13);
            this.nameLab.TabIndex = 0;
            this.nameLab.Text = "Name";
            // 
            // infoLab
            // 
            this.infoLab.AutoSize = true;
            this.infoLab.Location = new System.Drawing.Point(12, 182);
            this.infoLab.Name = "infoLab";
            this.infoLab.Size = new System.Drawing.Size(59, 13);
            this.infoLab.TabIndex = 1;
            this.infoLab.Text = "Information";
            // 
            // wingetNameLab
            // 
            this.wingetNameLab.AutoSize = true;
            this.wingetNameLab.Location = new System.Drawing.Point(12, 156);
            this.wingetNameLab.Name = "wingetNameLab";
            this.wingetNameLab.Size = new System.Drawing.Size(72, 13);
            this.wingetNameLab.TabIndex = 2;
            this.wingetNameLab.Text = "Winget Name";
            // 
            // wingetLab
            // 
            this.wingetLab.AutoSize = true;
            this.wingetLab.Location = new System.Drawing.Point(12, 131);
            this.wingetLab.Name = "wingetLab";
            this.wingetLab.Size = new System.Drawing.Size(41, 13);
            this.wingetLab.TabIndex = 3;
            this.wingetLab.Text = "Winget";
            // 
            // cmdLab
            // 
            this.cmdLab.AutoSize = true;
            this.cmdLab.Location = new System.Drawing.Point(12, 108);
            this.cmdLab.Name = "cmdLab";
            this.cmdLab.Size = new System.Drawing.Size(31, 13);
            this.cmdLab.TabIndex = 4;
            this.cmdLab.Text = "CMD";
            // 
            // msiLab
            // 
            this.msiLab.AutoSize = true;
            this.msiLab.Location = new System.Drawing.Point(12, 85);
            this.msiLab.Name = "msiLab";
            this.msiLab.Size = new System.Drawing.Size(26, 13);
            this.msiLab.TabIndex = 5;
            this.msiLab.Text = "MSI";
            // 
            // pathLab
            // 
            this.pathLab.AutoSize = true;
            this.pathLab.Location = new System.Drawing.Point(12, 61);
            this.pathLab.Name = "pathLab";
            this.pathLab.Size = new System.Drawing.Size(29, 13);
            this.pathLab.TabIndex = 6;
            this.pathLab.Text = "Path";
            // 
            // descLab
            // 
            this.descLab.AutoSize = true;
            this.descLab.Location = new System.Drawing.Point(12, 35);
            this.descLab.Name = "descLab";
            this.descLab.Size = new System.Drawing.Size(32, 13);
            this.descLab.TabIndex = 7;
            this.descLab.Text = "Flags";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(92, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(399, 20);
            this.nameBox.TabIndex = 8;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(92, 32);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(399, 20);
            this.descBox.TabIndex = 9;
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(92, 58);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(399, 20);
            this.pathBox.TabIndex = 10;
            // 
            // wingetNameBox
            // 
            this.wingetNameBox.Enabled = false;
            this.wingetNameBox.Location = new System.Drawing.Point(92, 153);
            this.wingetNameBox.Name = "wingetNameBox";
            this.wingetNameBox.Size = new System.Drawing.Size(399, 20);
            this.wingetNameBox.TabIndex = 12;
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(92, 179);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(399, 87);
            this.infoBox.TabIndex = 13;
            // 
            // msiBox
            // 
            this.msiBox.AutoSize = true;
            this.msiBox.Location = new System.Drawing.Point(92, 84);
            this.msiBox.Name = "msiBox";
            this.msiBox.Size = new System.Drawing.Size(40, 17);
            this.msiBox.TabIndex = 14;
            this.msiBox.Text = "No";
            this.msiBox.UseVisualStyleBackColor = true;
            this.msiBox.CheckedChanged += new System.EventHandler(this.msiBox_CheckedChanged);
            // 
            // cmdBox
            // 
            this.cmdBox.AutoSize = true;
            this.cmdBox.Location = new System.Drawing.Point(92, 107);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(40, 17);
            this.cmdBox.TabIndex = 15;
            this.cmdBox.Text = "No";
            this.cmdBox.UseVisualStyleBackColor = true;
            this.cmdBox.CheckedChanged += new System.EventHandler(this.cmdBox_CheckedChanged);
            // 
            // wingetBox
            // 
            this.wingetBox.AutoSize = true;
            this.wingetBox.Location = new System.Drawing.Point(92, 130);
            this.wingetBox.Name = "wingetBox";
            this.wingetBox.Size = new System.Drawing.Size(40, 17);
            this.wingetBox.TabIndex = 16;
            this.wingetBox.Text = "No";
            this.wingetBox.UseVisualStyleBackColor = true;
            this.wingetBox.CheckedChanged += new System.EventHandler(this.wingetBox_CheckedChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(416, 272);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(335, 272);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 304);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.wingetBox);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.msiBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.wingetNameBox);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.descLab);
            this.Controls.Add(this.pathLab);
            this.Controls.Add(this.msiLab);
            this.Controls.Add(this.cmdLab);
            this.Controls.Add(this.wingetLab);
            this.Controls.Add(this.wingetNameLab);
            this.Controls.Add(this.infoLab);
            this.Controls.Add(this.nameLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddApp";
            this.Text = "Add App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Label infoLab;
        private System.Windows.Forms.Label wingetNameLab;
        private System.Windows.Forms.Label wingetLab;
        private System.Windows.Forms.Label cmdLab;
        private System.Windows.Forms.Label msiLab;
        private System.Windows.Forms.Label pathLab;
        private System.Windows.Forms.Label descLab;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox wingetNameBox;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.CheckBox msiBox;
        private System.Windows.Forms.CheckBox cmdBox;
        private System.Windows.Forms.CheckBox wingetBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}
namespace YumeBuild
{
    partial class AppDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppDB));
            this.appList = new System.Windows.Forms.ListView();
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pathCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msiCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wingetCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wingetNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infoCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addAppBtn = new System.Windows.Forms.Button();
            this.removeAppBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appList
            // 
            this.appList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.nameCol,
            this.descCol,
            this.pathCol,
            this.msiCol,
            this.cmdCol,
            this.wingetCol,
            this.wingetNameCol,
            this.infoCol});
            this.appList.Location = new System.Drawing.Point(12, 12);
            this.appList.MultiSelect = false;
            this.appList.Name = "appList";
            this.appList.Size = new System.Drawing.Size(1035, 545);
            this.appList.TabIndex = 0;
            this.appList.UseCompatibleStateImageBehavior = false;
            this.appList.View = System.Windows.Forms.View.Details;
            this.appList.DoubleClick += new System.EventHandler(this.appList_DoubleClick);
            // 
            // idCol
            // 
            this.idCol.Text = "ID";
            // 
            // nameCol
            // 
            this.nameCol.Text = "Name";
            this.nameCol.Width = 114;
            // 
            // descCol
            // 
            this.descCol.Text = "Flags";
            this.descCol.Width = 150;
            // 
            // pathCol
            // 
            this.pathCol.Text = "Path";
            this.pathCol.Width = 102;
            // 
            // msiCol
            // 
            this.msiCol.Text = "MSI";
            // 
            // cmdCol
            // 
            this.cmdCol.Text = "CMD";
            // 
            // wingetCol
            // 
            this.wingetCol.Text = "Winget";
            // 
            // wingetNameCol
            // 
            this.wingetNameCol.Text = "Winget Name";
            this.wingetNameCol.Width = 97;
            // 
            // infoCol
            // 
            this.infoCol.Text = "Information";
            this.infoCol.Width = 313;
            // 
            // addAppBtn
            // 
            this.addAppBtn.Location = new System.Drawing.Point(12, 563);
            this.addAppBtn.Name = "addAppBtn";
            this.addAppBtn.Size = new System.Drawing.Size(83, 23);
            this.addAppBtn.TabIndex = 1;
            this.addAppBtn.Text = "Add App";
            this.addAppBtn.UseVisualStyleBackColor = true;
            this.addAppBtn.Click += new System.EventHandler(this.addAppBtn_Click);
            // 
            // removeAppBtn
            // 
            this.removeAppBtn.Location = new System.Drawing.Point(101, 563);
            this.removeAppBtn.Name = "removeAppBtn";
            this.removeAppBtn.Size = new System.Drawing.Size(81, 23);
            this.removeAppBtn.TabIndex = 2;
            this.removeAppBtn.Text = "Remove App";
            this.removeAppBtn.UseVisualStyleBackColor = true;
            this.removeAppBtn.Click += new System.EventHandler(this.removeAppBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(188, 563);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(81, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // AppDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 598);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.removeAppBtn);
            this.Controls.Add(this.addAppBtn);
            this.Controls.Add(this.appList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppDB";
            this.Text = "Application Database";
            this.Load += new System.EventHandler(this.AppDB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView appList;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader descCol;
        private System.Windows.Forms.ColumnHeader pathCol;
        private System.Windows.Forms.ColumnHeader msiCol;
        private System.Windows.Forms.ColumnHeader cmdCol;
        private System.Windows.Forms.ColumnHeader wingetCol;
        private System.Windows.Forms.ColumnHeader wingetNameCol;
        private System.Windows.Forms.ColumnHeader infoCol;
        private System.Windows.Forms.Button addAppBtn;
        private System.Windows.Forms.Button removeAppBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ColumnHeader idCol;
    }
}
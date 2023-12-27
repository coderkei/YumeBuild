namespace YumeBuild
{
    partial class ScriptMake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptMake));
            this.scriptCode = new System.Windows.Forms.TextBox();
            this.scriptBox = new System.Windows.Forms.GroupBox();
            this.cmdBox = new System.Windows.Forms.ComboBox();
            this.addToScript = new System.Windows.Forms.Button();
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
            this.cmdBtn = new System.Windows.Forms.Button();
            this.dbgParse = new System.Windows.Forms.Button();
            this.scriptMakeMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScript = new System.Windows.Forms.OpenFileDialog();
            this.saveScript = new System.Windows.Forms.SaveFileDialog();
            this.exeScript = new System.Windows.Forms.Button();
            this.scriptBox.SuspendLayout();
            this.scriptMakeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // scriptCode
            // 
            this.scriptCode.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptCode.Location = new System.Drawing.Point(6, 19);
            this.scriptCode.Multiline = true;
            this.scriptCode.Name = "scriptCode";
            this.scriptCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.scriptCode.Size = new System.Drawing.Size(950, 211);
            this.scriptCode.TabIndex = 0;
            // 
            // scriptBox
            // 
            this.scriptBox.Controls.Add(this.scriptCode);
            this.scriptBox.Location = new System.Drawing.Point(12, 398);
            this.scriptBox.Name = "scriptBox";
            this.scriptBox.Size = new System.Drawing.Size(962, 236);
            this.scriptBox.TabIndex = 1;
            this.scriptBox.TabStop = false;
            this.scriptBox.Text = "Script Code";
            // 
            // cmdBox
            // 
            this.cmdBox.FormattingEnabled = true;
            this.cmdBox.Items.AddRange(new object[] {
            "Message Box",
            "Open URL",
            "Execute CMD",
            "Copy File",
            "Create File",
            "Create Folder"});
            this.cmdBox.Location = new System.Drawing.Point(12, 371);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(141, 21);
            this.cmdBox.TabIndex = 2;
            this.cmdBox.Text = "Select Command";
            // 
            // addToScript
            // 
            this.addToScript.Location = new System.Drawing.Point(864, 371);
            this.addToScript.Name = "addToScript";
            this.addToScript.Size = new System.Drawing.Size(104, 23);
            this.addToScript.TabIndex = 3;
            this.addToScript.Text = "Add App To Script";
            this.addToScript.UseVisualStyleBackColor = true;
            this.addToScript.Click += new System.EventHandler(this.addToScript_Click);
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
            this.appList.Location = new System.Drawing.Point(12, 27);
            this.appList.MultiSelect = false;
            this.appList.Name = "appList";
            this.appList.Size = new System.Drawing.Size(962, 338);
            this.appList.TabIndex = 4;
            this.appList.UseCompatibleStateImageBehavior = false;
            this.appList.View = System.Windows.Forms.View.Details;
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
            this.descCol.Width = 84;
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
            // cmdBtn
            // 
            this.cmdBtn.Location = new System.Drawing.Point(159, 369);
            this.cmdBtn.Name = "cmdBtn";
            this.cmdBtn.Size = new System.Drawing.Size(104, 23);
            this.cmdBtn.TabIndex = 5;
            this.cmdBtn.Text = "Add Command";
            this.cmdBtn.UseVisualStyleBackColor = true;
            this.cmdBtn.Click += new System.EventHandler(this.cmdBtn_Click);
            // 
            // dbgParse
            // 
            this.dbgParse.Location = new System.Drawing.Point(760, 640);
            this.dbgParse.Name = "dbgParse";
            this.dbgParse.Size = new System.Drawing.Size(104, 23);
            this.dbgParse.TabIndex = 6;
            this.dbgParse.Text = "Debug Parse";
            this.dbgParse.UseVisualStyleBackColor = true;
            this.dbgParse.Click += new System.EventHandler(this.dbgParse_Click);
            // 
            // scriptMakeMenu
            // 
            this.scriptMakeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.scriptMakeMenu.Location = new System.Drawing.Point(0, 0);
            this.scriptMakeMenu.Name = "scriptMakeMenu";
            this.scriptMakeMenu.Size = new System.Drawing.Size(986, 24);
            this.scriptMakeMenu.TabIndex = 7;
            this.scriptMakeMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadScriptToolStripMenuItem,
            this.saveScriptToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadScriptToolStripMenuItem
            // 
            this.loadScriptToolStripMenuItem.Name = "loadScriptToolStripMenuItem";
            this.loadScriptToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.loadScriptToolStripMenuItem.Text = "Load Script...";
            this.loadScriptToolStripMenuItem.Click += new System.EventHandler(this.loadScriptToolStripMenuItem_Click);
            // 
            // saveScriptToolStripMenuItem
            // 
            this.saveScriptToolStripMenuItem.Name = "saveScriptToolStripMenuItem";
            this.saveScriptToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveScriptToolStripMenuItem.Text = "Save Script...";
            this.saveScriptToolStripMenuItem.Click += new System.EventHandler(this.saveScriptToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // openScript
            // 
            this.openScript.Filter = "UIS Scripts|*.uis|All Files|*.*";
            this.openScript.FileOk += new System.ComponentModel.CancelEventHandler(this.openScript_FileOk);
            // 
            // saveScript
            // 
            this.saveScript.Filter = "UIS Scripts|*.uis|All Files|*.*";
            this.saveScript.FileOk += new System.ComponentModel.CancelEventHandler(this.saveScript_FileOk);
            // 
            // exeScript
            // 
            this.exeScript.Location = new System.Drawing.Point(870, 640);
            this.exeScript.Name = "exeScript";
            this.exeScript.Size = new System.Drawing.Size(104, 23);
            this.exeScript.TabIndex = 8;
            this.exeScript.Text = "Execute Script";
            this.exeScript.UseVisualStyleBackColor = true;
            this.exeScript.Click += new System.EventHandler(this.exeScript_Click);
            // 
            // ScriptMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 675);
            this.Controls.Add(this.exeScript);
            this.Controls.Add(this.dbgParse);
            this.Controls.Add(this.cmdBtn);
            this.Controls.Add(this.appList);
            this.Controls.Add(this.addToScript);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.scriptBox);
            this.Controls.Add(this.scriptMakeMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.scriptMakeMenu;
            this.MaximizeBox = false;
            this.Name = "ScriptMake";
            this.Text = "Script Editor";
            this.Load += new System.EventHandler(this.ScriptMake_Load);
            this.scriptBox.ResumeLayout(false);
            this.scriptBox.PerformLayout();
            this.scriptMakeMenu.ResumeLayout(false);
            this.scriptMakeMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scriptCode;
        private System.Windows.Forms.GroupBox scriptBox;
        private System.Windows.Forms.ComboBox cmdBox;
        private System.Windows.Forms.Button addToScript;
        private System.Windows.Forms.ListView appList;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader descCol;
        private System.Windows.Forms.ColumnHeader pathCol;
        private System.Windows.Forms.ColumnHeader msiCol;
        private System.Windows.Forms.ColumnHeader cmdCol;
        private System.Windows.Forms.ColumnHeader wingetCol;
        private System.Windows.Forms.ColumnHeader wingetNameCol;
        private System.Windows.Forms.ColumnHeader infoCol;
        private System.Windows.Forms.Button cmdBtn;
        private System.Windows.Forms.Button dbgParse;
        private System.Windows.Forms.MenuStrip scriptMakeMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openScript;
        private System.Windows.Forms.SaveFileDialog saveScript;
        private System.Windows.Forms.Button exeScript;
        private System.Windows.Forms.ColumnHeader idCol;
    }
}
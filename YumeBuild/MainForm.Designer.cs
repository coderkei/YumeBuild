namespace YumeBuild
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolsDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.wingetUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.powershellConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registryEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localUsersGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedSystemSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openDatabaseRawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.workingDirLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buildBtn = new System.Windows.Forms.Button();
            this.databaseBtn = new System.Windows.Forms.Button();
            this.toolsBtn = new System.Windows.Forms.Button();
            this.scriptMgr = new System.Windows.Forms.Button();
            this.scriptQuickStart = new System.Windows.Forms.OpenFileDialog();
            this.mBox = new System.Windows.Forms.GroupBox();
            this.sBtn = new System.Windows.Forms.Button();
            this.bBox = new System.Windows.Forms.GroupBox();
            this.extraBtn = new System.Windows.Forms.Button();
            this.quickScrp = new System.Windows.Forms.Button();
            this.oBox = new System.Windows.Forms.GroupBox();
            this.resetDb = new System.Windows.Forms.Button();
            this.wingetBtn = new System.Windows.Forms.Button();
            this.sInfo = new System.Windows.Forms.GroupBox();
            this.diskLabel = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dbLabel = new System.Windows.Forms.Label();
            this.verLabel = new System.Windows.Forms.Label();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.mainStatus.SuspendLayout();
            this.mBox.SuspendLayout();
            this.bBox.SuspendLayout();
            this.oBox.SuspendLayout();
            this.sInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.InitialImage = null;
            this.logoBox.Location = new System.Drawing.Point(12, 27);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(243, 50);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(597, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newScriptToolStripMenuItem,
            this.loadScriptToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newScriptToolStripMenuItem
            // 
            this.newScriptToolStripMenuItem.Name = "newScriptToolStripMenuItem";
            this.newScriptToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newScriptToolStripMenuItem.Text = "New Build Script...";
            this.newScriptToolStripMenuItem.Click += new System.EventHandler(this.newScriptToolStripMenuItem_Click);
            // 
            // loadScriptToolStripMenuItem
            // 
            this.loadScriptToolStripMenuItem.Name = "loadScriptToolStripMenuItem";
            this.loadScriptToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loadScriptToolStripMenuItem.Text = "Load Build Script...";
            this.loadScriptToolStripMenuItem.Click += new System.EventHandler(this.loadScriptToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolsDirectoryToolStripMenuItem,
            this.toolStripSeparator5,
            this.wingetUpdateToolStripMenuItem,
            this.toolStripSeparator6,
            this.powershellConsoleToolStripMenuItem,
            this.cMDConsoleToolStripMenuItem,
            this.registryEditorToolStripMenuItem,
            this.localUsersGroupsToolStripMenuItem,
            this.advancedSystemSettingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // openToolsDirectoryToolStripMenuItem
            // 
            this.openToolsDirectoryToolStripMenuItem.Name = "openToolsDirectoryToolStripMenuItem";
            this.openToolsDirectoryToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.openToolsDirectoryToolStripMenuItem.Text = "Open Tools Directory";
            this.openToolsDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openToolsDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(213, 6);
            // 
            // wingetUpdateToolStripMenuItem
            // 
            this.wingetUpdateToolStripMenuItem.Name = "wingetUpdateToolStripMenuItem";
            this.wingetUpdateToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.wingetUpdateToolStripMenuItem.Text = "Winget Update";
            this.wingetUpdateToolStripMenuItem.Click += new System.EventHandler(this.wingetUpdateToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(213, 6);
            // 
            // powershellConsoleToolStripMenuItem
            // 
            this.powershellConsoleToolStripMenuItem.Name = "powershellConsoleToolStripMenuItem";
            this.powershellConsoleToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.powershellConsoleToolStripMenuItem.Text = "Powershell Admin Console";
            this.powershellConsoleToolStripMenuItem.Click += new System.EventHandler(this.powershellConsoleToolStripMenuItem_Click);
            // 
            // cMDConsoleToolStripMenuItem
            // 
            this.cMDConsoleToolStripMenuItem.Name = "cMDConsoleToolStripMenuItem";
            this.cMDConsoleToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cMDConsoleToolStripMenuItem.Text = "CMD Admin Console";
            this.cMDConsoleToolStripMenuItem.Click += new System.EventHandler(this.cMDConsoleToolStripMenuItem_Click);
            // 
            // registryEditorToolStripMenuItem
            // 
            this.registryEditorToolStripMenuItem.Name = "registryEditorToolStripMenuItem";
            this.registryEditorToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.registryEditorToolStripMenuItem.Text = "Registry Editor";
            this.registryEditorToolStripMenuItem.Click += new System.EventHandler(this.registryEditorToolStripMenuItem_Click);
            // 
            // localUsersGroupsToolStripMenuItem
            // 
            this.localUsersGroupsToolStripMenuItem.Name = "localUsersGroupsToolStripMenuItem";
            this.localUsersGroupsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.localUsersGroupsToolStripMenuItem.Text = "Local Users and Groups";
            this.localUsersGroupsToolStripMenuItem.Click += new System.EventHandler(this.localUsersGroupsToolStripMenuItem_Click);
            // 
            // advancedSystemSettingsToolStripMenuItem
            // 
            this.advancedSystemSettingsToolStripMenuItem.Name = "advancedSystemSettingsToolStripMenuItem";
            this.advancedSystemSettingsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.advancedSystemSettingsToolStripMenuItem.Text = "Advanced System Settings";
            this.advancedSystemSettingsToolStripMenuItem.Click += new System.EventHandler(this.advancedSystemSettingsToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appListToolStripMenuItem,
            this.resetDatabaseToolStripMenuItem,
            this.toolStripSeparator3,
            this.openDatabaseRawToolStripMenuItem,
            this.openConfigDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // appListToolStripMenuItem
            // 
            this.appListToolStripMenuItem.Name = "appListToolStripMenuItem";
            this.appListToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.appListToolStripMenuItem.Text = "App Database";
            this.appListToolStripMenuItem.Click += new System.EventHandler(this.appListToolStripMenuItem_Click);
            // 
            // resetDatabaseToolStripMenuItem
            // 
            this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.resetDatabaseToolStripMenuItem.Text = "Reset App Database";
            this.resetDatabaseToolStripMenuItem.Click += new System.EventHandler(this.resetDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // openDatabaseRawToolStripMenuItem
            // 
            this.openDatabaseRawToolStripMenuItem.Name = "openDatabaseRawToolStripMenuItem";
            this.openDatabaseRawToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openDatabaseRawToolStripMenuItem.Text = "Open App Database Raw";
            this.openDatabaseRawToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseRawToolStripMenuItem_Click);
            // 
            // openConfigDatabaseToolStripMenuItem
            // 
            this.openConfigDatabaseToolStripMenuItem.Name = "openConfigDatabaseToolStripMenuItem";
            this.openConfigDatabaseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.openConfigDatabaseToolStripMenuItem.Text = "Open Config Database Raw";
            this.openConfigDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openConfigDatabaseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainStatus
            // 
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workingDirLabel});
            this.mainStatus.Location = new System.Drawing.Point(0, 406);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(597, 22);
            this.mainStatus.SizingGrip = false;
            this.mainStatus.TabIndex = 4;
            // 
            // workingDirLabel
            // 
            this.workingDirLabel.Name = "workingDirLabel";
            this.workingDirLabel.Size = new System.Drawing.Size(93, 17);
            this.workingDirLabel.Text = "workingDirLabel";
            // 
            // buildBtn
            // 
            this.buildBtn.Location = new System.Drawing.Point(6, 19);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(174, 55);
            this.buildBtn.TabIndex = 5;
            this.buildBtn.Text = "Start Build";
            this.buildBtn.UseVisualStyleBackColor = true;
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // databaseBtn
            // 
            this.databaseBtn.Location = new System.Drawing.Point(6, 19);
            this.databaseBtn.Name = "databaseBtn";
            this.databaseBtn.Size = new System.Drawing.Size(174, 55);
            this.databaseBtn.TabIndex = 6;
            this.databaseBtn.Text = "App Database";
            this.databaseBtn.UseVisualStyleBackColor = true;
            this.databaseBtn.Click += new System.EventHandler(this.databaseBtn_Click);
            // 
            // toolsBtn
            // 
            this.toolsBtn.Location = new System.Drawing.Point(8, 19);
            this.toolsBtn.Name = "toolsBtn";
            this.toolsBtn.Size = new System.Drawing.Size(174, 55);
            this.toolsBtn.TabIndex = 7;
            this.toolsBtn.Text = "Tools";
            this.toolsBtn.UseVisualStyleBackColor = true;
            this.toolsBtn.Click += new System.EventHandler(this.toolsBtn_Click);
            // 
            // scriptMgr
            // 
            this.scriptMgr.Location = new System.Drawing.Point(6, 80);
            this.scriptMgr.Name = "scriptMgr";
            this.scriptMgr.Size = new System.Drawing.Size(174, 55);
            this.scriptMgr.TabIndex = 8;
            this.scriptMgr.Text = "Script Manager";
            this.scriptMgr.UseVisualStyleBackColor = true;
            this.scriptMgr.Click += new System.EventHandler(this.scriptMgr_Click);
            // 
            // scriptQuickStart
            // 
            this.scriptQuickStart.Filter = "UIS Scripts|*.uis|All Files|*.*";
            this.scriptQuickStart.FileOk += new System.ComponentModel.CancelEventHandler(this.scriptQuickStart_FileOk);
            // 
            // mBox
            // 
            this.mBox.Controls.Add(this.sBtn);
            this.mBox.Controls.Add(this.databaseBtn);
            this.mBox.Controls.Add(this.scriptMgr);
            this.mBox.Location = new System.Drawing.Point(400, 83);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(187, 203);
            this.mBox.TabIndex = 9;
            this.mBox.TabStop = false;
            this.mBox.Text = "Management";
            // 
            // sBtn
            // 
            this.sBtn.Location = new System.Drawing.Point(6, 141);
            this.sBtn.Name = "sBtn";
            this.sBtn.Size = new System.Drawing.Size(174, 55);
            this.sBtn.TabIndex = 9;
            this.sBtn.Text = "Settings";
            this.sBtn.UseVisualStyleBackColor = true;
            this.sBtn.Click += new System.EventHandler(this.sBtn_Click);
            // 
            // bBox
            // 
            this.bBox.Controls.Add(this.extraBtn);
            this.bBox.Controls.Add(this.quickScrp);
            this.bBox.Controls.Add(this.buildBtn);
            this.bBox.Location = new System.Drawing.Point(12, 83);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(188, 203);
            this.bBox.TabIndex = 10;
            this.bBox.TabStop = false;
            this.bBox.Text = "Build";
            // 
            // extraBtn
            // 
            this.extraBtn.Location = new System.Drawing.Point(6, 141);
            this.extraBtn.Name = "extraBtn";
            this.extraBtn.Size = new System.Drawing.Size(174, 55);
            this.extraBtn.TabIndex = 7;
            this.extraBtn.Text = "Licenses and Config Files";
            this.extraBtn.UseVisualStyleBackColor = true;
            this.extraBtn.Click += new System.EventHandler(this.extraBtn_Click);
            // 
            // quickScrp
            // 
            this.quickScrp.Location = new System.Drawing.Point(6, 80);
            this.quickScrp.Name = "quickScrp";
            this.quickScrp.Size = new System.Drawing.Size(174, 55);
            this.quickScrp.TabIndex = 6;
            this.quickScrp.Text = "Quick Start Script";
            this.quickScrp.UseVisualStyleBackColor = true;
            this.quickScrp.Click += new System.EventHandler(this.quickScrp_Click);
            // 
            // oBox
            // 
            this.oBox.Controls.Add(this.resetDb);
            this.oBox.Controls.Add(this.wingetBtn);
            this.oBox.Controls.Add(this.toolsBtn);
            this.oBox.Location = new System.Drawing.Point(206, 83);
            this.oBox.Name = "oBox";
            this.oBox.Size = new System.Drawing.Size(188, 203);
            this.oBox.TabIndex = 11;
            this.oBox.TabStop = false;
            this.oBox.Text = "Tools";
            // 
            // resetDb
            // 
            this.resetDb.Location = new System.Drawing.Point(8, 141);
            this.resetDb.Name = "resetDb";
            this.resetDb.Size = new System.Drawing.Size(174, 55);
            this.resetDb.TabIndex = 9;
            this.resetDb.Text = "Reset Database";
            this.resetDb.UseVisualStyleBackColor = true;
            this.resetDb.Click += new System.EventHandler(this.resetDb_Click);
            // 
            // wingetBtn
            // 
            this.wingetBtn.Location = new System.Drawing.Point(8, 80);
            this.wingetBtn.Name = "wingetBtn";
            this.wingetBtn.Size = new System.Drawing.Size(174, 55);
            this.wingetBtn.TabIndex = 8;
            this.wingetBtn.Text = "Winget Update";
            this.wingetBtn.UseVisualStyleBackColor = true;
            this.wingetBtn.Click += new System.EventHandler(this.wingetBtn_Click);
            // 
            // sInfo
            // 
            this.sInfo.Controls.Add(this.diskLabel);
            this.sInfo.Controls.Add(this.serialLabel);
            this.sInfo.Controls.Add(this.modelLabel);
            this.sInfo.Controls.Add(this.ramLabel);
            this.sInfo.Controls.Add(this.cpuLabel);
            this.sInfo.Location = new System.Drawing.Point(12, 292);
            this.sInfo.Name = "sInfo";
            this.sInfo.Size = new System.Drawing.Size(381, 111);
            this.sInfo.TabIndex = 12;
            this.sInfo.TabStop = false;
            this.sInfo.Text = "System Information";
            // 
            // diskLabel
            // 
            this.diskLabel.AutoSize = true;
            this.diskLabel.Location = new System.Drawing.Point(6, 84);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(62, 13);
            this.diskLabel.TabIndex = 4;
            this.diskLabel.Text = "Disk Space";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(6, 68);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(33, 13);
            this.serialLabel.TabIndex = 3;
            this.serialLabel.Text = "Serial";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(6, 52);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.Location = new System.Drawing.Point(6, 36);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(31, 13);
            this.ramLabel.TabIndex = 1;
            this.ramLabel.Text = "RAM";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(6, 20);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(29, 13);
            this.cpuLabel.TabIndex = 0;
            this.cpuLabel.Text = "CPU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbLabel);
            this.groupBox1.Controls.Add(this.verLabel);
            this.groupBox1.Location = new System.Drawing.Point(400, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 111);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "App";
            // 
            // dbLabel
            // 
            this.dbLabel.Location = new System.Drawing.Point(6, 36);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(174, 72);
            this.dbLabel.TabIndex = 6;
            this.dbLabel.Text = "Database GUID";
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.Location = new System.Drawing.Point(6, 16);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(42, 13);
            this.verLabel.TabIndex = 5;
            this.verLabel.Text = "Version";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sInfo);
            this.Controls.Add(this.mBox);
            this.Controls.Add(this.oBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "YumeBuild";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.mBox.ResumeLayout(false);
            this.bBox.ResumeLayout(false);
            this.oBox.ResumeLayout(false);
            this.sInfo.ResumeLayout(false);
            this.sInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel workingDirLabel;
        private System.Windows.Forms.ToolStripMenuItem newScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Button buildBtn;
        private System.Windows.Forms.Button databaseBtn;
        private System.Windows.Forms.Button toolsBtn;
        private System.Windows.Forms.Button scriptMgr;
        private System.Windows.Forms.OpenFileDialog scriptQuickStart;
        private System.Windows.Forms.ToolStripMenuItem openToolsDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
        private System.Windows.Forms.GroupBox mBox;
        private System.Windows.Forms.Button sBtn;
        private System.Windows.Forms.GroupBox bBox;
        private System.Windows.Forms.GroupBox oBox;
        private System.Windows.Forms.GroupBox sInfo;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label diskLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.Button wingetBtn;
        private System.Windows.Forms.Button extraBtn;
        private System.Windows.Forms.Button quickScrp;
        private System.Windows.Forms.Button resetDb;
        private System.Windows.Forms.ToolStripMenuItem wingetUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powershellConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMDConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registryEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localUsersGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedSystemSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseRawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
    }
}


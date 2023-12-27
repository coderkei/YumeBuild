//This code is under MIT licence, you can find the complete file under the LICENSE file included with this project.
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Xml;
using System.Runtime.InteropServices;
using System.Management;

namespace YumeBuild
{
    public partial class MainForm : Form
    {

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

        string defaultPath = Application.StartupPath + @"\data\";
        string configXml = Application.StartupPath + @"\config.xml";
        string database = Application.StartupPath + @"\database.xml";

        string dataPath = "";
        string scriptPath = "";
        string databasePath = "";
        string contentPath = "";
        string toolsPath = "";
        string licensePath = "";

        XmlDocument configDoc = new XmlDocument();
        XmlMgr mainXmlMgr = new XmlMgr();
        ScriptMgr mainScriptMgr = new ScriptMgr();
        Utilities utility = new Utilities();
        DriveInfo diskSpace = new DriveInfo("C");

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "YumeBuild - " + Environment.MachineName;
            if(!File.Exists(configXml))
            {
                MessageBox.Show("Default configuration not found. New configuration & data folder will be created", "Config", MessageBoxButtons.OK, MessageBoxIcon.Information);
                utility.initConfig();
                utility.initDatabase();
                Application.Restart();
            }
            else
            {
                configDoc.Load(configXml);
                wingetCheck();
            }

            dataPath = mainXmlMgr.loadSettings()[0];
            scriptPath = mainXmlMgr.loadSettings()[1];
            databasePath = mainXmlMgr.loadSettings()[2];
            contentPath = mainXmlMgr.loadSettings()[3];
            toolsPath = mainXmlMgr.loadSettings()[4];
            licensePath = mainXmlMgr.loadSettings()[5];
            workingDirLabel.Text = dataPath;

            var CPUkey = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0\");
            var modelkey = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\BIOS\");
            var processorName = CPUkey.GetValue("ProcessorNameString");
            var modelName = modelkey.GetValue("SystemProductName");
            cpuLabel.Text = "CPU: " + processorName.ToString();
            long mem;
            GetPhysicallyInstalledSystemMemory(out mem);
            ramLabel.Text = "RAM: " + mem / 1024 / 1024 + " GB";
            modelLabel.Text = "Model: " + modelName.ToString();

            ManagementObjectSearcher serial = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS");
            ManagementObjectCollection serialObj = serial.Get();
            foreach (ManagementObject obj in serialObj)
            {
                foreach (PropertyData data in obj.Properties)
                    serialLabel.Text = "Serial: " + data.Value.ToString();
            }
            serial.Dispose();

            var freeSpace = diskSpace.AvailableFreeSpace / 1024 / 1024 / 1024;
            var totalSpace = diskSpace.TotalSize / 1024 / 1024 / 1024;
            diskLabel.Text = "Disk Space C Drive: " + freeSpace.ToString() + " GB free of " + totalSpace.ToString() + " GB";

            string ver = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            verLabel.Text = "Program Version: " + ver;
            dbLabel.Text = "Database GUID: " + utility.getGuid();
        }

        private void wingetCheck()
        {
            string wingetResult = configDoc.SelectSingleNode("//Paths/Winget").InnerText;
            if (wingetResult == "0")
            {
                if (utility.wingetCheck() == true)
                {
                    mainXmlMgr.saveSettings(0, "1");
                }
                else
                {
                    MessageBox.Show("Winget is not installed. Update to App Installer in Microsoft Store required.");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void toolsBtn_Click(object sender, EventArgs e)
        {
            Process.Start(toolsPath);
        }

        private void buildBtn_Click(object sender, EventArgs e)
        {
            Form buildFrm = new BuildForm();
            buildFrm.ShowDialog();
        }

        private void databaseBtn_Click(object sender, EventArgs e)
        {
            Form appFrm = new AppDB();
            appFrm.ShowDialog();
        }

        private void scriptMgr_Click(object sender, EventArgs e)
        {
            Form scriptMake = new ScriptMake();
            scriptMake.ShowDialog();
        }

        private void newScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form scriptMake = new ScriptMake();
            scriptMake.ShowDialog();
        }

        private void loadScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will automatically execute the loaded script. Continue?\nScript execution cannot be cancelled.", "Script Execution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                scriptQuickStart.InitialDirectory = utility.getDataPath() + @"scripts";
                scriptQuickStart.ShowDialog();
            }
        }

        private void scriptQuickStart_FileOk(object sender, CancelEventArgs e)
        {
            mainScriptMgr.executeScript(scriptQuickStart.FileName, null);
        }

        private void appListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form appFrm = new AppDB();
            appFrm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form setFrm = new SettingsForm();
            setFrm.ShowDialog();
        }

        private void openToolsDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(toolsPath);
        }

        private void resetDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("WARNING: This will reset the database and the current database will be lost. Continue?", "Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                utility.initDatabase();
            }
        }

        private void sBtn_Click(object sender, EventArgs e)
        {
            Form setFrm = new SettingsForm();
            setFrm.ShowDialog();
        }

        private void quickScrp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will automatically execute the loaded script. Continue?\nScript execution cannot be cancelled.", "Script Execution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                scriptQuickStart.InitialDirectory = utility.getDataPath() + @"scripts";
                scriptQuickStart.ShowDialog();
            }
        }

        private void resetDb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("WARNING: This will reset the database and the current database will be lost. Continue?", "Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                utility.initDatabase();
            }
        }

        private void wingetBtn_Click(object sender, EventArgs e)
        {
            utility.updateWinget();
        }

        private void extraBtn_Click(object sender, EventArgs e)
        {
            Process.Start(licensePath);
        }

        private void wingetUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utility.updateWinget();
        }

        private void powershellConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("powershell.exe");
        }

        private void cMDConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void registryEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("regedit.exe");
        }

        private void localUsersGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("lusrmgr.msc");
        }

        private void advancedSystemSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("sysdm.cpl");
        }

        private void openDatabaseRawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", database);
        }

        private void openConfigDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", configXml);
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream(Application.StartupPath + @"\UsersManual.pdf", FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(DefaultRes.UsersManual);
                }
            }
            Process.Start(Application.StartupPath + @"\UsersManual.pdf");
        }
    }
}

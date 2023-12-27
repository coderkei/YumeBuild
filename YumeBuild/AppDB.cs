//This code is under MIT licence, you can find the complete file under the LICENSE file included with this project.
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace YumeBuild
{
    public partial class AppDB : Form
    {
        string configXml = Application.StartupPath + @"\config.xml";
        string database = Application.StartupPath + @"\database.xml";
        string custXml = Application.StartupPath + @"\custconfig.xml";

        string dataPath = "";
        string scriptPath = "";
        string databasePath = "";
        string contentPath = "";
        string toolsPath = "";
        string selPath = "";

        string[] currDB;
        string[] selApp;
        int appNum;
        int remNum;
        int clickNum;

        XmlMgr mainXmlMgr = new XmlMgr();
        Utilities utility = new Utilities();
        TextBox infoBox = new TextBox();
        Form infoForm = new Form();

        public AppDB()
        {
            InitializeComponent();
        }

        private void AppDB_Load(object sender, EventArgs e)
        {
            dataPath = mainXmlMgr.loadSettings()[0];
            scriptPath = mainXmlMgr.loadSettings()[1];
            databasePath = mainXmlMgr.loadSettings()[2];
            contentPath = mainXmlMgr.loadSettings()[3];
            toolsPath = mainXmlMgr.loadSettings()[4];

            appNum = mainXmlMgr.getInt();

            int[] idList = mainXmlMgr.getIDList();


            for (int i = 0; i < idList.Length; i++ )
            {
                currDB = mainXmlMgr.getAppFromID(idList[i]);
                var appItem = new ListViewItem(currDB);
                appList.Items.Add(appItem);
            }
            
        }

        private void addAppBtn_Click(object sender, EventArgs e)
        {
            Form addAppFrm = new AddApp();
            addAppFrm.ShowDialog();
            refreshView();
        }

        private void removeAppBtn_Click(object sender, EventArgs e)
        {
            if(appList.FocusedItem == null)
            {
                MessageBox.Show("No app selected", "App DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                remNum = appList.FocusedItem.Index;
                remNum++;
                mainXmlMgr.removeApp(remNum);
                refreshView();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshView();
        }

        private void refreshView()
        {
            appList.Items.Clear();

            int[] idList = mainXmlMgr.getIDList();


            for (int i = 0; i < idList.Length; i++)
            {
                currDB = mainXmlMgr.getAppFromID(idList[i]);
                var appItem = new ListViewItem(currDB);
                appList.Items.Add(appItem);
            }
        }

        public void genInfoForm()
        {
            infoForm.Text = "Information";
            infoForm.Size = new System.Drawing.Size(630, 351);
            infoForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            infoBox.Dock = DockStyle.Fill;
            infoBox.Multiline = true;
            infoBox.WordWrap = true;
            infoBox.ScrollBars = ScrollBars.Vertical;
            infoBox.Font = new System.Drawing.Font("Cascadia Code", 9.75f);
            infoForm.Controls.Add(infoBox);
            infoForm.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                infoForm.Show();
            }
            catch
            {
                MessageBox.Show("Unable to load Info box. Please reopen the App Database window.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void appList_DoubleClick(object sender, EventArgs e)
        {
            genInfoForm();
            clickNum = int.Parse(appList.FocusedItem.SubItems[0].Text);
            selApp = mainXmlMgr.getAppFromID(clickNum);
            selPath =  utility.getContentPath() + selApp[3];
            infoBox.Text = selApp[8];
            if(selApp[6] == "Y")
            {
                try
                {
                    var processInfo = new ProcessStartInfo
                    {
                        Verb = "runas",
                        LoadUserProfile = true,
                        FileName = "powershell.exe",
                        Arguments = "winget install -e -h --accept-source-agreements --accept-package-agreements --id " + selApp[7],
                        RedirectStandardOutput = false,
                        UseShellExecute = true,
                    };
                    var p = Process.Start(processInfo);
                }
                catch
                {
                    MessageBox.Show("Action was cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if(selApp[5] == "Y")
            {
                try
                {
                    Process iappc = new Process();
                    iappc.StartInfo.FileName = utility.getContentPath() + selApp[3];
                    iappc.StartInfo.Arguments = selApp[2];
                    iappc.Start();
                    iappc.WaitForExit();
                }
                catch
                {
                    MessageBox.Show("Action was cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                if (File.Exists(selPath))
                {
                    try
                    {
                        Process.Start(utility.getContentPath() + selApp[3]);
                    }
                    catch
                    {
                        MessageBox.Show("Action was cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to start program. The file could not be found", "App DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

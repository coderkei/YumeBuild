//This code is under MIT licence, you can find the complete file under the LICENSE file included with this project.
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace YumeBuild
{
    public partial class ScriptMake : Form
    {
        string[] currDB;
        string[] selApp;
        string[] scriptArray;
        string ver;
        int appNum;
        int clickNum;
        string guid = Application.StartupPath + @"\guid.ini";

        Utilities utility = new Utilities();
        XmlMgr mainXmlMgr = new XmlMgr();
        ScriptMgr mainScriptMgr = new ScriptMgr();
        //string defaultPath = Application.StartupPath + @"\data\";

        public ScriptMake()
        {
            InitializeComponent();
        }

        private void ScriptMake_Load(object sender, EventArgs e)
        {
            openScript.InitialDirectory = utility.getDataPath() + @"scripts";
            saveScript.InitialDirectory = utility.getDataPath() + @"scripts";
            ver = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            scriptCode.Text = "YumeBuild UIS Script";
            scriptCode.AppendText(Environment.NewLine + ver);
            scriptCode.AppendText(Environment.NewLine + File.ReadAllText(guid));
            appNum = mainXmlMgr.getInt();

            int[] idList = mainXmlMgr.getIDList();


            for (int i = 0; i < idList.Length; i++)
            {
                currDB = mainXmlMgr.getAppFromID(idList[i]);
                var appItem = new ListViewItem(currDB);
                appList.Items.Add(appItem);
            }

        }

        private void addToScript_Click(object sender, EventArgs e)
        {
            if(appList.FocusedItem == null)
            {
                MessageBox.Show("Please select a valid app", "App Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                clickNum = int.Parse(appList.FocusedItem.SubItems[0].Text);
                selApp = mainXmlMgr.getAppFromID(clickNum);
                if (selApp[6] == "Y")
                {
                    scriptCode.AppendText(Environment.NewLine + "=wg " + appList.FocusedItem.SubItems[0].Text);
                }
                else if(selApp[4] == "Y")
                {
                    scriptCode.AppendText(Environment.NewLine + "=msi " + appList.FocusedItem.SubItems[0].Text);
                }
                else if(selApp[5] == "Y")
                {
                    scriptCode.AppendText(Environment.NewLine + "=iappc " + appList.FocusedItem.SubItems[0].Text);
                }
                else
                {
                    scriptCode.AppendText(Environment.NewLine + "=iapp " + appList.FocusedItem.SubItems[0].Text);
                }
            }           
        }

        private void cmdBtn_Click(object sender, EventArgs e)
        {
            /*
             0: Message Box
             1: Open URL
             2: Execute CMD
             3: Copy File
             4: Create File
             5: Create Folder
             */
            clickNum = cmdBox.SelectedIndex;
            switch(clickNum)
            {
                case -1:
                    MessageBox.Show("Please select a valid command", "Command Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 0:
                    scriptCode.AppendText(Environment.NewLine + "+text InsertTextHere");
                    break;
                case 1:
                    scriptCode.AppendText(Environment.NewLine + "+url InsertURLHere");
                    break;
                case 2:
                    scriptCode.AppendText(Environment.NewLine + "+cmd InsertCommandHere");
                    break;
                case 3:
                    scriptCode.AppendText(Environment.NewLine + "+copy =SourcePath =DestinationPath");
                    break;
                case 4:
                    scriptCode.AppendText(Environment.NewLine + "+cfile FilePath");
                    break;
                case 5:
                    scriptCode.AppendText(Environment.NewLine + "+cfol FolderPath");
                    break;
                default:
                    break;
            }
        }

        private void dbgParse_Click(object sender, EventArgs e)
        {
            scriptArray = scriptCode.Lines;
            mainScriptMgr.debugScript(scriptArray);
        }

        private void loadScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openScript.ShowDialog();
        }

        private void saveScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveScript.ShowDialog();
        }

        private void saveScript_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllLines(saveScript.FileName, scriptCode.Lines);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openScript_FileOk(object sender, CancelEventArgs e)
        {
            scriptCode.Lines = File.ReadAllLines(openScript.FileName);
        }

        private void exeScript_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("WARNING: Do not perform this action in a development environment! Please use the debug parser.\n\nDo you wish to execute this script? Script execution cannot be cancelled.", "Script Execution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                mainScriptMgr.executeScript(null, scriptCode.Lines);
            }
        }
    }
}

//This code is under MIT licence, you can find the complete file under the LICENSE file included with this project.
using System;
using System.Windows.Forms;
using System.IO;

namespace YumeBuild
{
    public partial class BuildForm : Form
    {
        XmlMgr mainXmlMgr = new XmlMgr();
        Utilities utility = new Utilities();
        ScriptMgr mainScriptMgr = new ScriptMgr();

        public BuildForm()
        {
            InitializeComponent();
        }

        private void BuildForm_Load(object sender, EventArgs e)
        {
            openScript.InitialDirectory = utility.getDataPath() + @"scripts";
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to execute this script? Script execution cannot be cancelled.", "Script Execution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                var scriptResult = openScript.ShowDialog();
                if(scriptResult == DialogResult.OK)
                {
                    status.Text = "Status: Running...";
                    infoBox.Text = File.ReadAllText(openScript.FileName);
                    startBuild();
                    status.Text = "Status: Ready...";
                }
            }
        }

        private void startBuild()
        {
            mainScriptMgr.genInfoForm();
            mainScriptMgr.executeScript(openScript.FileName);
            MessageBox.Show("Build finished. You may load another script or close these Windows.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

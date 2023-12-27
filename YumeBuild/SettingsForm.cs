//This code is under MIT licence, you can find the complete file under the LICENSE file included with this project.
using System;
using System.Windows.Forms;
using System.Xml;

namespace YumeBuild
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        XmlDocument configDoc = new XmlDocument();
        XmlMgr mainXmlMgr = new XmlMgr();
        string configXml = Application.StartupPath + @"\config.xml";
        string newPath;

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            configDoc.Load(configXml);
            string wingetResult = configDoc.SelectSingleNode("//Paths/Winget").InnerText;
            if (wingetResult == "0")
            {
                wingetCheck.Text = "Not installed";
                wingetCheck.Checked = false;
            }
            else
            {
                wingetCheck.Text = "Installed";
                wingetCheck.Checked = true;
            }
        }

        private void wingetCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(wingetCheck.Checked == true)
            {
                mainXmlMgr.saveSettings(0, "1");
                wingetCheck.Text = "Installed";
            }
            else
            {
                mainXmlMgr.saveSettings(0, "0");
                wingetCheck.Text = "Not installed";
            }
        }

        private void overrideBtn_Click(object sender, EventArgs e)
        {
            if (selectContent.ShowDialog() == DialogResult.OK)
            {
                newPath = selectContent.SelectedPath;
                configDoc.Load(configXml);
                configDoc.SelectSingleNode("//Paths/Content").InnerText = newPath + @"\";
                configDoc.Save(configXml);
                MessageBox.Show("Content path changed.", "Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

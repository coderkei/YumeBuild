//This code is under MIT licence, you can find the complete file under the LICENSE file included with this project.
using System;
using System.Windows.Forms;

namespace YumeBuild
{
    public partial class AddApp : Form
    {
        public AddApp()
        {
            InitializeComponent();
        }

        XmlMgr mainXmlMgr = new XmlMgr();

        string name = "";
        string desc = "";
        string path = "";
        string MSI = "N";
        string CMD = "N";
        string winget = "N";
        string wingetName = "";
        string info = "";

        private void msiBox_CheckedChanged(object sender, EventArgs e)
        {
            if (msiBox.Checked)
            {
                MSI = "Y";
                msiBox.Text = "Yes";
                cmdBox.Enabled = false;
                wingetBox.Enabled = false;
            }
            else
            {
                MSI = "N";
                msiBox.Text = "No";
                cmdBox.Enabled = true;
                wingetBox.Enabled = true;
            }
        }

        private void cmdBox_CheckedChanged(object sender, EventArgs e)
        {
            if(cmdBox.Checked)
            {
                CMD = "Y";
                cmdBox.Text = "Yes";
                msiBox.Enabled = false;
                wingetBox.Enabled = false;
            }
            else
            {
                CMD = "N";
                cmdBox.Text = "No";
                msiBox.Enabled = true;
                wingetBox.Enabled = true;
            }
        }

        private void wingetBox_CheckedChanged(object sender, EventArgs e)
        {
            if(wingetBox.Checked)
            {
                winget = "Y";
                wingetBox.Text = "Yes";
                wingetNameBox.Enabled = true;
                msiBox.Enabled = false;
                cmdBox.Enabled = false;
                pathBox.Enabled = false;
            }
            else
            {
                winget = "N";
                wingetBox.Text = "No";
                wingetNameBox.Enabled = false;
                msiBox.Enabled = true;
                cmdBox.Enabled = true;
                pathBox.Enabled = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            name = nameBox.Text;
            desc = descBox.Text;
            path = pathBox.Text;
            wingetName = wingetNameBox.Text;
            info = infoBox.Text;
            mainXmlMgr.addApp(name, desc, path, MSI, CMD, winget, wingetName, info);
            this.Close();
        }
    }
}

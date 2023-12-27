//This code is under MIT licence, you can find the complete file under the LICENSE file included with this project.
using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace YumeBuild
{
    class ScriptMgr
    {
        XmlMgr mainXmlMgr = new XmlMgr();
        Utilities utility = new Utilities();
        WebClient client = new WebClient();
        Form infoForm = new Form();
        string scriptPath = "";
        string ver;
        string reportedVer;
        string[] subString;
        int scriptLength;
        string guid = Application.StartupPath + @"\guid.ini";
        TextBox infoBox = new TextBox();

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
                MessageBox.Show("Unable to load Info box. Please reopen the build window and restart the script.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void genScript(string name)
        {
            scriptPath = mainXmlMgr.loadSettings()[1];
            File.CreateText(scriptPath + name + ".uis");
        }

        public void createScript(int id)
        {
            //unused
        }

        public int getInt(string name)
        {
            scriptPath = mainXmlMgr.loadSettings()[1];
            string[] lines;
            lines = File.ReadAllLines(scriptPath + name + ".uis");
            return lines.Length;
            
        }

        public int getApp(int id)
        {
            scriptPath = mainXmlMgr.loadSettings()[1];
            return 0;
        }

        public void executeScript(string scriptPath = null, string[] scriptText = null)
        {
            string[] scriptData = null;
            if (scriptPath != null)
            {
                scriptData = File.ReadAllLines(scriptPath);
            }
            else
            {
                scriptData = scriptText;
            }
            ver = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            var appVer = new Version(ver);
            if (scriptData[0] == "YumeBuild UIS Script")
            {
                reportedVer = scriptData[1];
                var scriptVer = new Version(reportedVer);
                var verResult = appVer.CompareTo(scriptVer);
                if(verResult < 0)
                {
                    MessageBox.Show("This UIS script is designed for a newer version of YumeBuild. Execution cannot continue.", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if(File.ReadAllText(guid) != scriptData[2])
                {
                    MessageBox.Show("UIS Script was designed for a different database. Execution cannot continue.", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    scriptLength = scriptData.Length;
                    for (int i = 2; i < scriptLength; i++)
                    {
                        subString = scriptData[i].Split(' ');
                        var appendData = scriptData[i].Remove(0, scriptData[i].IndexOf(' ') + 1);
                        if (scriptData[i].StartsWith("="))
                        {
                            switch(subString[0])
                            {
                                case "=iapp":
                                    if(File.Exists(utility.getContentPath() + mainXmlMgr.getAppFromID(int.Parse(appendData))[3]))
                                    {
                                        infoBox.Text = "Installing " + mainXmlMgr.getAppFromID(int.Parse(appendData))[1];
                                        infoBox.AppendText(Environment.NewLine + "Application Information: " + mainXmlMgr.getAppFromID(int.Parse(appendData))[8]);
                                        Process.Start(utility.getContentPath() + mainXmlMgr.getAppFromID(int.Parse(appendData))[3]).WaitForExit();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to continue UIS script. The file " + utility.getContentPath() + mainXmlMgr.getAppFromID(int.Parse(appendData))[3] + " could not be found", "App DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    break;
                                case "=wg":
                                    infoBox.Text = "Installing " + mainXmlMgr.getAppFromID(int.Parse(appendData))[7];
                                    infoBox.AppendText(Environment.NewLine + "Application Information: " + mainXmlMgr.getAppFromID(int.Parse(appendData))[8]);
                                    try
                                    {
                                        var processInfo = new ProcessStartInfo
                                        {
                                            Verb = "runas",
                                            LoadUserProfile = true,
                                            FileName = "powershell.exe",
                                            Arguments = "winget install -e -h --accept-source-agreements --accept-package-agreements --id " + mainXmlMgr.getAppFromID(int.Parse(appendData))[7],
                                            RedirectStandardOutput = false,
                                            UseShellExecute = true,
                                        };
                                        var p = Process.Start(processInfo);
                                        p.WaitForExit();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Action was cancelled or an error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                    break;
                                case "=msi":
                                    infoBox.Text = "Installing " + mainXmlMgr.getAppFromID(int.Parse(appendData))[1];
                                    infoBox.AppendText(Environment.NewLine + "Application Information: " + mainXmlMgr.getAppFromID(int.Parse(appendData))[8]);
                                    if (File.Exists(utility.getContentPath() + mainXmlMgr.getAppFromID(int.Parse(appendData))[3]))
                                    {
                                        try
                                        {
                                            var processInfoMSI = new ProcessStartInfo
                                            {
                                                Verb = "runas",
                                                LoadUserProfile = true,
                                                FileName = "msiexec.exe",
                                                WorkingDirectory = utility.getContentPath(),
                                                Arguments = " /quiet /i " + mainXmlMgr.getAppFromID(int.Parse(appendData))[3],
                                            };
                                            var pMSI = Process.Start(processInfoMSI);
                                            pMSI.WaitForExit();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Action was cancelled or an error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to continue UIS script. The file " + utility.getContentPath() + mainXmlMgr.getAppFromID(int.Parse(appendData))[3] + " could not be found", "App DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }                                    
                                    break;
                                case "=iappc":
                                    infoBox.Text = "Installing " + mainXmlMgr.getAppFromID(int.Parse(appendData))[1];
                                    infoBox.AppendText(Environment.NewLine + "Application Information: " + mainXmlMgr.getAppFromID(int.Parse(appendData))[8]);
                                    if (File.Exists(utility.getContentPath() + mainXmlMgr.getAppFromID(int.Parse(appendData))[3]))
                                    {
                                        try
                                        {
                                            Process iappc = new Process();
                                            iappc.StartInfo.FileName = utility.getContentPath() + mainXmlMgr.getAppFromID(int.Parse(appendData))[3];
                                            iappc.StartInfo.Arguments = mainXmlMgr.getAppFromID(int.Parse(appendData))[2];
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
                                        MessageBox.Show("Unable to continue UIS script. The file " + utility.getContentPath() + mainXmlMgr.getAppFromID(int.Parse(appendData))[3] + " could not be found", "App DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    break;
                                default:
                                    MessageBox.Show("UIS Script error. Syntax error on line " + (i+1) +". Execution of UIS script cannot continue.", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    break;
                            }
                            
                        }
                        else if (scriptData[i].StartsWith("+"))
                        {
                            switch(subString[0])
                            {
                                case "+text":
                                    MessageBox.Show(appendData, "UIS Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case "+url":
                                    Process.Start(appendData);
                                    break;
                                case "cmd":
                                    string strCmdText;
                                    strCmdText = "/C " + appendData;
                                    Process.Start("CMD.exe", strCmdText).WaitForExit();
                                    break;
                                case "+copy":
                                    var paths = scriptData[i].Split('=');
                                    File.Copy(paths[1],paths[2]);
                                    break;
                                case "+cfile":
                                    File.Create(appendData);
                                    break;
                                case "+cfol":
                                    Directory.CreateDirectory(appendData);
                                    break;
                                case "+dl":
                                    client.DownloadFile(appendData, utility.getDataPath() + Path.GetFileName(appendData));
                                    break;
                                case "+dli":
                                    string fileName = Path.GetFileName(appendData);
                                    client.DownloadFile(appendData, utility.getDataPath() + fileName);
                                    Process.Start(utility.getDataPath() + fileName).WaitForExit();
                                    break;
                                default:
                                    MessageBox.Show("UIS Script error. Syntax error on line " + (i + 1) + ". Execution of UIS script cannot continue.", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    break;
                            }
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Header missing. Not a valid UIS script", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void debugScript(string[] scriptData)
        {
            MessageBox.Show(scriptData[0]);
            ver = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            var appVer = new Version(ver);
            if (scriptData[0] == "YumeBuild UIS Script")
            {
                reportedVer = scriptData[1];
                var scriptVer = new Version(reportedVer);
                var verResult = appVer.CompareTo(scriptVer);
                if(verResult < 0)
                {
                    MessageBox.Show("This UIS script is designed for a newer version of YumeBuild. Execution cannot continue.", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if (File.ReadAllText(guid) != scriptData[2])
                {
                    MessageBox.Show("Expected GUID: " + File.ReadAllText(guid));
                    MessageBox.Show("Script GUID: " + scriptData[2]);
                    MessageBox.Show("UIS Script was designed for a different database. Execution cannot continue.", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    scriptLength = scriptData.Length;
                    for (int i = 2; i < scriptLength; i++)
                    {
                        subString = scriptData[i].Split(' ');
                        var appendData = scriptData[i].Remove(0, scriptData[i].IndexOf(' ') + 1);
                        if (scriptData[i].StartsWith("="))
                        {
                            switch(subString[0])
                            {
                                case "=iapp":
                                    MessageBox.Show("DEBUG: App Install " + mainXmlMgr.getAppFromID(int.Parse(appendData))[3]);
                                    break;
                                case "=wg":
                                    MessageBox.Show("DEBUG: Winget Install " + mainXmlMgr.getAppFromID(int.Parse(appendData))[7]);
                                    break;
                                case "=msi":
                                    MessageBox.Show("DEBUG: MSI Install " + mainXmlMgr.getAppFromID(int.Parse(appendData))[3]);
                                    break;
                                case "=iappc":
                                    MessageBox.Show("DEBUG: App Install " + mainXmlMgr.getAppFromID(int.Parse(appendData))[3] + " With " + mainXmlMgr.getAppFromID(int.Parse(appendData))[2]);
                                    break;
                                default:
                                    MessageBox.Show("Syntax error on line " + (i+1) +".", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    break;
                            }
                            
                        }
                        else if (scriptData[i].StartsWith("+"))
                        {
                            switch(subString[0])
                            {
                                case "+text":
                                    MessageBox.Show("DEBUG: Text " + appendData, "UIS Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case "+url":
                                    MessageBox.Show("DEBUG: URL " + appendData);
                                    break;
                                case "cmd":
                                    MessageBox.Show("DEBUG: CMD " + appendData);
                                    break;
                                case "+copy":
                                    var paths = scriptData[i].Split('=');
                                    MessageBox.Show("DEBUG: Copy " + paths[1] + "to " + paths[2], "UIS Script", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case "+cfile":
                                    MessageBox.Show("DEBUG: File " + appendData);
                                    break;
                                case "+cfol":
                                    MessageBox.Show("DEBUG: Folder " + appendData);
                                    break;
                                case "+dl":
                                    MessageBox.Show("DEBUG: Download " + appendData);
                                    break;
                                case "+dli":
                                    MessageBox.Show("DEBUG: Download & Install " + appendData);
                                    break;
                                default:
                                    break;
                            }
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Header missing. Not a valid UIS script", "Script Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

//This code is under MIT licence, you can find the complete file under the LICENSE file included with this project.
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace YumeBuild
{
    class Utilities
    {
        string defaultPath = Application.StartupPath + @"\data\";
        string configXml = Application.StartupPath + @"\config.xml";
        string databaseXml = Application.StartupPath + @"\database.xml";
        string guid = Application.StartupPath + @"\guid.ini";
        XmlDocument configDoc = new XmlDocument();

        /// <summary>
        /// Checks for Winget installation and also agrees to terms
        /// </summary>
        /// <returns></returns>
        public bool wingetCheck()
        {
            ProcessStartInfo winget = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            Process wingetProc = new Process
            {
                StartInfo = winget
            };

            wingetProc.Start();
            wingetProc.StandardInput.WriteLine("winget --version --accept-source-agreements");
            wingetProc.StandardInput.WriteLine("exit");

            string output = wingetProc.StandardOutput.ReadToEnd();
            wingetProc.WaitForExit();

            if (output.Contains("winget version") || output.Contains("v"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getDataPath()
        {
            configDoc.Load(configXml);
            return configDoc.SelectSingleNode("//Paths/Content").InnerText;
        }

        public string getContentPath()
        {
            configDoc.Load(configXml);
            return configDoc.SelectSingleNode("//Paths/Content").InnerText + @"content\";
        }

        /// <summary>
        /// Initialises first run config
        /// </summary>
        public void initConfig()
        {
            File.WriteAllText(configXml, DefaultRes.config);
            configDoc.Load(configXml);
            configDoc.SelectSingleNode("//Paths/Content").InnerText = defaultPath;
            configDoc.Save(configXml);
            if (!Directory.Exists(defaultPath))
            {
                Directory.CreateDirectory(defaultPath);
                Directory.CreateDirectory(defaultPath + @"scripts\");
                Directory.CreateDirectory(defaultPath + @"content\");
                Directory.CreateDirectory(defaultPath + @"tools\");
                Directory.CreateDirectory(defaultPath + @"licensesconfig\");
            }
        }

        public void initDatabase()
        {
            File.WriteAllText(databaseXml, DefaultRes.database);
            File.WriteAllText(guid, Guid.NewGuid().ToString());
        }

        public void initGuid()
        {
            File.WriteAllText(guid, Guid.NewGuid().ToString());
        }

        public string getGuid()
        {
            string guidRead = File.ReadAllText(guid);
            return guidRead;
        }

        public void updateWinget()
        {
            configDoc.Load(configXml);
            string wingetResult = configDoc.SelectSingleNode("//Paths/Winget").InnerText;
            if (wingetResult == "0")
            {
                MessageBox.Show("Winget is not installed. Update to App Installer in Microsoft Store required.");
            }
            else
            {
                var processInfo = new ProcessStartInfo
                {
                    Verb = "runas",
                    LoadUserProfile = true,
                    FileName = "powershell.exe",
                    Arguments = "winget update -r",
                    RedirectStandardOutput = false,
                    UseShellExecute = true,
                };
                try
                {
                    var p = Process.Start(processInfo);
                    p.WaitForExit();
                }
                catch
                {
                    MessageBox.Show("Action was cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}

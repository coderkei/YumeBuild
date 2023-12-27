//This code is under MIT licence, you can find the complete file under the LICENSE file included with this project.
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Windows.Forms;

namespace YumeBuild

{
    class XmlMgr
    {
        XmlDocument configDoc = new XmlDocument();
        XmlDocument databaseDoc = new XmlDocument();

        string database = Application.StartupPath + @"\database.xml";
        string configXml = Application.StartupPath + @"\config.xml";

        /// <summary>
        /// Retrieve amount of application entries in the XML as an integer from the default database
        /// </summary>
        /// <returns></returns>
        public int getInt()
        {
            databaseDoc.Load(database);
            XmlNodeList idList = databaseDoc.GetElementsByTagName("ID");
            return idList.Count;
        }

        /// <summary>
        /// Retrieve the XML data of a particular ID as a string from the default database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getXml(int id)
        {
            databaseDoc.Load(database);
            id = id - 1; //Convert real number to actual number
            XmlNodeList appNode = databaseDoc.GetElementsByTagName("Application");
            return appNode[id].InnerXml;
        }


        /// <summary>
        /// Retrieve the XML data for an app entry of a particular ID as a string array from the default database.
        /// Name, Description, Path, MSI, CMD and Info. Use getAppFromID if possible.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public string[] getApp(int id)
        {
            id = id - 1; //Convert real number to actual number
            databaseDoc.Load(database);
            XmlNodeList idList = databaseDoc.GetElementsByTagName("ID");
            XmlNodeList nameList = databaseDoc.GetElementsByTagName("Name");
            XmlNodeList descList = databaseDoc.GetElementsByTagName("Desc");
            XmlNodeList pathList = databaseDoc.GetElementsByTagName("PathName");
            XmlNodeList msiList = databaseDoc.GetElementsByTagName("MSI");
            XmlNodeList cmdList = databaseDoc.GetElementsByTagName("CMD");
            XmlNodeList wingetList = databaseDoc.GetElementsByTagName("Winget");
            XmlNodeList wingetNList = databaseDoc.GetElementsByTagName("WingetName");
            XmlNodeList infoList = databaseDoc.GetElementsByTagName("Info");

            return new string[] { nameList[id].InnerText, descList[id].InnerText, pathList[id].InnerText, msiList[id].InnerText, cmdList[id].InnerText, wingetList[id].InnerText, wingetNList[id].InnerText, infoList[id].InnerText, idList[id].InnerText };
        }

        /// <summary>
        /// Retrieves an app by searching the XML Database with the provided ID. Deprecates getApp and getAppCust
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string[] getAppFromID(int id)
        {
            string[] nodes;
            databaseDoc.Load(database);

            //Values
            // 0 ID
            // 1 Name
            // 2 Description
            // 3 Path
            // 4 MSI
            // 5 CMD
            // 6 Winget
            // 7 Winget Name
            // 8 Info

            XmlNode node;
            XmlNode root = databaseDoc.DocumentElement;

            node = root.SelectSingleNode("descendant::Application[ID=" + id.ToString() + "]");

            List<string> xmlNodes = new List<string>();
            foreach(XmlNode xn in node)
            {
                xmlNodes.Add(xn.InnerText);
            }
            nodes = xmlNodes.ToArray();
            return nodes;
        }

        /// <summary>
        /// Retrieves the list of app IDs
        /// </summary>
        /// <returns></returns>
        public int[] getIDList()
        {
            int[]intNodes;
            databaseDoc.Load(database);
            XmlNodeList idList = databaseDoc.GetElementsByTagName("ID");
            var nodeIdList = idList.Cast<XmlNode>().Select(x => int.Parse(x.InnerText)).ToList();
            return intNodes = nodeIdList.ToArray();
        }


        /// <summary>
        /// Append an app into the default XML database using the provided information
        /// </summary>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        /// <param name="path"></param>
        /// <param name="msi"></param>
        /// <param name="cmd"></param>
        /// <param name="winget"></param>
        /// <param name="wingetN"></param>
        /// <param name="info"></param>
        /// <param name="xmlPath"></param>
        public void addApp(string name, string desc, string path, string msi, string cmd, string winget, string wingetN, string info)
        {
            databaseDoc.Load(database);
            XmlElement appAdd = databaseDoc.CreateElement("Application");
            XmlElement idAdd = databaseDoc.CreateElement("ID");
            XmlElement nameAdd = databaseDoc.CreateElement("Name");
            XmlElement descAdd = databaseDoc.CreateElement("Desc");
            XmlElement pathAdd = databaseDoc.CreateElement("PathName");
            XmlElement msiAdd = databaseDoc.CreateElement("MSI");
            XmlElement cmdAdd = databaseDoc.CreateElement("CMD");
            XmlElement wingetAdd = databaseDoc.CreateElement("Winget");
            XmlElement wingetNAdd = databaseDoc.CreateElement("WingetName");
            XmlElement infoAdd = databaseDoc.CreateElement("Info");
            XmlNodeList idList = databaseDoc.GetElementsByTagName("ID");
            XmlNodeList nameList = databaseDoc.GetElementsByTagName("Name");
            XmlNodeList descList = databaseDoc.GetElementsByTagName("Desc");
            XmlNodeList pathList = databaseDoc.GetElementsByTagName("PathName");
            XmlNodeList msiList = databaseDoc.GetElementsByTagName("MSI");
            XmlNodeList cmdList = databaseDoc.GetElementsByTagName("CMD");
            XmlNodeList wingetList = databaseDoc.GetElementsByTagName("Winget");
            XmlNodeList wingetNList = databaseDoc.GetElementsByTagName("WingetName");
            XmlNodeList infoList = databaseDoc.GetElementsByTagName("Info");

            int[] idCount = getIDList();

            int maxID = 0;

            try
            {
                maxID = idCount.Max();
            }
            catch
            {
                maxID = 0;
            }


            idAdd.InnerText = (maxID + 1).ToString();
            nameAdd.InnerText = name;
            descAdd.InnerText = desc;
            pathAdd.InnerText = path;
            msiAdd.InnerText = msi;
            cmdAdd.InnerText = cmd;
            wingetAdd.InnerText = winget;
            wingetNAdd.InnerText = wingetN;
            infoAdd.InnerText = info;

            appAdd.AppendChild(idAdd);
            appAdd.AppendChild(nameAdd);
            appAdd.AppendChild(descAdd);
            appAdd.AppendChild(pathAdd);
            appAdd.AppendChild(msiAdd);
            appAdd.AppendChild(cmdAdd);
            appAdd.AppendChild(wingetAdd);
            appAdd.AppendChild(wingetNAdd);
            appAdd.AppendChild(infoAdd);

            databaseDoc.DocumentElement.AppendChild(appAdd);
            databaseDoc.Save(database);
        }

        /// <summary>
        /// Remove an app from the default XML database using the provided ID, then reformat the list
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xmlPath"></param>
        public void removeApp(int id)
        {
            id = id - 1; //Convert real number to actual number
            databaseDoc.Load(database);
            XmlNodeList appNode = databaseDoc.GetElementsByTagName("Application");
            appNode[id].ParentNode.RemoveChild(appNode[id]);
            databaseDoc.Save(database);
        }

        /// <summary>
        /// Returns the default configuration as a string array.
        /// </summary>
        /// <returns></returns>
        public string[] loadSettings()
        {
            return loadCustSettings(configXml);
        }

        /// <summary>
        /// Returns the custom configuration as a string array.
        /// </summary>
        /// <param name="custXml"></param>
        /// <returns></returns>
        public string[] loadCustSettings(string custXml)
        {
            configDoc.Load(custXml);
            string dataPath = configDoc.SelectSingleNode("//Paths/Content").InnerText;
            string scriptPath = dataPath + @"scripts\";
            string databasePath = dataPath + @"database\";
            string contentPath = dataPath + @"content\";
            string toolsPath = dataPath + @"tools\";
            string licensePath = dataPath + @"licensesconfig\";
            return new string[] { dataPath, scriptPath, databasePath, contentPath, toolsPath, licensePath};
        }

        /// <summary>
        /// Saves the default configuration. Mode 0: Winget. Mode 1: Path.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="data"></param>
        public void saveSettings(int mode, string data)
        {
            saveCustSettings(configXml, mode, data);
        }

        /// <summary>
        /// Saves the custom configuration. Mode 0: Winget. Mode 1: Path.
        /// </summary>
        /// <param name="custXml"></param>
        /// <param name="mode"></param>
        /// <param name="data"></param>
        public void saveCustSettings(string custXml, int mode, string data)
        {
            configDoc.Load(custXml);
            switch(mode)
            {
                case 0:
                    configDoc.SelectSingleNode("//Paths/Winget").InnerText = data;
                    break;
                case 1:
                    configDoc.SelectSingleNode("//Paths/Content").InnerText = data;
                    break;
                default:
                    break;
            }
            configDoc.Save(custXml);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace Exile_Payment_Reminder
{
    static class XML
    {
        public static string savedXmlFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Exile Territory Management\saved.xml"; //default path
        public static XmlDocument xmlDoc = new XmlDocument();

        public static void CreateNewXml(string filedir)
        {
            FileInfo fileInfo = new FileInfo(filedir);

            if (!fileInfo.Exists)
                Directory.CreateDirectory(fileInfo.Directory.FullName);

            using (FileStream fs = new FileStream(XML.savedXmlFile, FileMode.Create))
            {
                byte[] BufferData = { 0x00 };
                fs.Write(BufferData, 0, 1);
                fs.Flush();
            }

            xmlDoc.RemoveAll();

            XmlElement root;
            XmlElement servers;
            XmlElement territories;
            XmlDocument doc = XML.xmlDoc;

            root = doc.CreateElement("ExileTerritoryManagement");

            servers = doc.CreateElement("Servers");
            territories = doc.CreateElement("Territories");
            root.AppendChild(servers);
            root.AppendChild(territories);

            doc.AppendChild(root);

            try
            {
                xmlDoc.Save(filedir);
            }
            catch (Exception ex)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error Saving XML!", body: ex.Message);
            }
        }

        public static void Save(string savedXmlFile)
        {
            xmlDoc.Save(savedXmlFile);
        }

        public static void CreateNewServerNode(string ID, string Name, string IP, bool GrabNameFromInternet, List<Territory> territories)
        {
            int serverIndex = ReturnServerNodeIndex(ID);

            if (serverIndex != -1)
                return;

            XmlElement root = xmlDoc.DocumentElement;
            XmlNode servers = root.ChildNodes[0];
            XmlNode xmlterritories = root.ChildNodes[1];

            XmlElement xmlNewServer = xmlDoc.CreateElement("Server");
            servers.AppendChild(xmlNewServer);

            XmlNode idNode = xmlDoc.CreateElement("ID");
            XmlNode nameNode = xmlDoc.CreateElement("NAME");
            XmlNode ipNode = xmlDoc.CreateElement("IP");
            XmlNode autoGrabNameNode = xmlDoc.CreateElement("GET_NAME_FROM_INTERNET");
            XmlElement territoryIDNode = xmlDoc.CreateElement("TERRITORIES");


            xmlNewServer.AppendChild(idNode).InnerText = ID;
            xmlNewServer.AppendChild(nameNode).InnerText = Name;
            xmlNewServer.AppendChild(ipNode).InnerText = IP;
            xmlNewServer.AppendChild(autoGrabNameNode).InnerText = GrabNameFromInternet.ToString();
            xmlNewServer.AppendChild(territoryIDNode);

            foreach(Territory territory in territories)
            {
                XmlNode node = xmlDoc.CreateElement("ID");
                territoryIDNode.AppendChild(node).InnerText = territory.id;
            }
        }

        public static void CreateNewTerritoryNode(string ID, string parentID, string Name, DateTime paymentDate, int notificationID, List<string> buildRightOwners)
        {
            int territoryIndex = ReturnTerritoryNodeIndex(ID);
            int serverIndex = ReturnParentServerIndex(ID, parentID);
            int territoryIDFromParentServer = ReturnTerritoryNodeIndexFromParentServer(ID, parentID);

            if (territoryIndex != -1 && serverIndex != -1 && territoryIDFromParentServer != -1)
                return;

            XmlElement root = xmlDoc.DocumentElement;
            XmlNode servers = root.ChildNodes[0];
            XmlNode territories = root.ChildNodes[1];

            XmlElement xmlNewTerritory = xmlDoc.CreateElement("TERRITORY");
            territories.AppendChild(xmlNewTerritory);

            XmlNode idNode = xmlDoc.CreateElement("ID");
            XmlNode parentIdNode = xmlDoc.CreateElement("PARENT_ID");
            XmlNode nameNode = xmlDoc.CreateElement("NAME");
            XmlNode paymentDateNode = xmlDoc.CreateElement("PAYMENT_DATE");
            XmlNode xmlNotificationIDNode = xmlDoc.CreateElement("NOTIFICATION_ID");
            XmlElement xmlBuildRightOwners = xmlDoc.CreateElement("BUILD_RIGHTS_OWNERS");

            xmlNewTerritory.AppendChild(idNode).InnerText = ID;
            xmlNewTerritory.AppendChild(parentIdNode).InnerText = parentID;
            xmlNewTerritory.AppendChild(nameNode).InnerText = Name;
            xmlNewTerritory.AppendChild(paymentDateNode).InnerText = paymentDate.ToString();
            xmlNewTerritory.AppendChild(xmlNotificationIDNode).InnerText = notificationID.ToString();
            xmlNewTerritory.AppendChild(xmlBuildRightOwners);

            foreach (XmlNode server in servers.ChildNodes)
            {
                if (server.ChildNodes[0].InnerText == parentID)
                {
                    XmlNode territoryID = xmlDoc.CreateElement("ID");
                    server.ChildNodes[4].AppendChild(territoryID).InnerText = ID;
                }
            }

            foreach (string owner in buildRightOwners)
            {
                XmlNode ownerNode = xmlDoc.CreateElement("OWNER");
                xmlBuildRightOwners.AppendChild(ownerNode).InnerText = owner;
            }
        }
        public static int ReturnServerNodeIndex(string serverID)
        {
            int xmlindex = -1;
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes[0].ChildNodes.Count; i++)
            {
                string xmlID = xmlDoc.DocumentElement.ChildNodes[0].ChildNodes[i].ChildNodes[0].InnerText;
                if (serverID == xmlID)
                {
                    xmlindex = i;
                    break;
                }
            }

            if (xmlindex < 0)
                return -1;

            return xmlindex;
        }

        public static int ReturnTerritoryNodeIndex(string territoryID)
        {
            int xmlindex = -1;
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes[1].ChildNodes.Count; i++)
            {
                string xmlID = xmlDoc.DocumentElement.ChildNodes[1].ChildNodes[i].ChildNodes[0].InnerText;
                if (territoryID == xmlID)
                {
                    xmlindex = i;
                    break;
                }
            }

            if (xmlindex < 0)
                return -1;

            return xmlindex;
        }

        public static int ReturnParentServerIndex(string territoryID, string parentID)
        {
            int xmlserverindex = -1;

            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes[0].ChildNodes.Count; i++)
            {
                string xmlID = xmlDoc.DocumentElement.ChildNodes[0].ChildNodes[i].ChildNodes[0].InnerText;
                if (parentID == xmlID)
                {
                    xmlserverindex = i;
                    break;
                }
            }

            if (xmlserverindex < 0)
                return -1;

            return xmlserverindex;
        }

        public static int ReturnTerritoryNodeIndexFromParentServer(string territoryID, string parentID)
        {
            int xmlserverindex = -1;
            int xmlterritoryIDindex = -1;

            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes[0].ChildNodes.Count; i++)
            {
                string xmlID = xmlDoc.DocumentElement.ChildNodes[0].ChildNodes[i].ChildNodes[0].InnerText;
                if (parentID == xmlID)
                {
                    xmlserverindex = i;
                    for (int j = 0; j < xmlDoc.DocumentElement.ChildNodes[0].ChildNodes[i].ChildNodes[4].ChildNodes.Count; j++)
                    {
                        if (xmlDoc.DocumentElement.ChildNodes[0].ChildNodes[i].ChildNodes[4].ChildNodes[j].InnerText == territoryID)
                        {
                            xmlterritoryIDindex = j;
                            break;
                        }
                    }
                }
            }

            if (xmlserverindex < 0)
                return -1;

            if (xmlterritoryIDindex < 0)
                return -1;

            return xmlterritoryIDindex;
        }

        public static void RemoveServerNode(string serverID)
        {
            int xmlindex = -1;

            xmlindex = ReturnServerNodeIndex(serverID);

            if (xmlindex < 0)
                return;

            XmlNode xmlServerTreeNode = xmlDoc.DocumentElement.ChildNodes[0].ChildNodes[xmlindex]; //XmlNode server object from XML
            xmlDoc.DocumentElement.ChildNodes[0].RemoveChild(xmlServerTreeNode); //remove Server Node from XML
        }

        public static void RemoveTerritoryNode(string territoryID, string parentID)
        {
            //xmlindex = index of territory node in <Territories /> node, xmlserverindex = index of server node which hosts territory, xmlterritoryIDindex = index of territory ID node inside server territories <Territories /> node
            int xmlindex = ReturnTerritoryNodeIndex(territoryID);
            int xmlserverindex = ReturnParentServerIndex(territoryID, parentID);
            int xmlterritoryIDindex = ReturnTerritoryNodeIndexFromParentServer(territoryID, parentID);

            if (xmlindex < 0 || xmlserverindex < 0 || xmlterritoryIDindex < 0)
                return;

            XmlNode territoryTreeNode = xmlDoc.DocumentElement.ChildNodes[1].ChildNodes[xmlindex];
            xmlDoc.DocumentElement.ChildNodes[1].RemoveChild(territoryTreeNode);

            XmlNode serverTerritoryIDTreeNode = xmlDoc.DocumentElement.ChildNodes[0].ChildNodes[xmlserverindex].ChildNodes[4].ChildNodes[xmlterritoryIDindex];
            xmlDoc.DocumentElement.ChildNodes[0].ChildNodes[xmlserverindex].ChildNodes[4].RemoveChild(serverTerritoryIDTreeNode);
        }

        public static void ReplaceBuildRightsOwners(string territoryID, List<string> newGUIDs) //xmlindex = index of territory node in <Territories /> node
        {
            int xmlindex = ReturnTerritoryNodeIndex(territoryID);

            if (xmlindex < 0)
                return;

            XmlNode buildrightsowners = xmlDoc.DocumentElement.ChildNodes[1].ChildNodes[xmlindex].ChildNodes[5];
            buildrightsowners.RemoveAll();

            foreach (string GUID in newGUIDs)
            {
                XmlNode newOwner = xmlDoc.CreateElement("OWNER");
                buildrightsowners.AppendChild(newOwner).InnerText = GUID;
            }
        }
        public static void PopulateLists()
        {
            try
            {
                xmlDoc.Load(savedXmlFile);

                XmlElement root = xmlDoc.DocumentElement;
                XmlNode servers = root.ChildNodes[0];
                XmlNode territories = root.ChildNodes[1];

                foreach (XmlNode territory in territories.ChildNodes)
                {
                    string territoryID = territory.ChildNodes[0].InnerText;
                    string territoryParentID = territory.ChildNodes[1].InnerText;
                    string territoryName = territory.ChildNodes[2].InnerText;
                    DateTime territoryPaymentDate = Convert.ToDateTime(territory.ChildNodes[3].InnerText);
                    int territoryNotificationID = Convert.ToInt32(territory.ChildNodes[4].InnerText);
                    List<string> buildRightOwners = new List<string>();
                    XmlNode xmlBuildRightOwners = territory.ChildNodes[5];

                    foreach (XmlNode owner in xmlBuildRightOwners.ChildNodes)
                        buildRightOwners.Add(owner.InnerText);

                    Territory newTerritory = new Territory(territoryID, territoryParentID, territoryName, territoryPaymentDate, territoryNotificationID, buildRightOwners);
                    frmMain.listTerritories.Add(newTerritory);
                }

                foreach (XmlNode server in servers.ChildNodes)
                {
                    string serverID = server.ChildNodes[0].InnerText;
                    string serverName = server.ChildNodes[1].InnerText;
                    string serverIP = server.ChildNodes[2].InnerText;
                    bool serverAutoGrabName = Convert.ToBoolean(server.ChildNodes[3].InnerText);
                    XmlNode xmlServerTerritories = server.ChildNodes[4];

                    List<string> territoryIDs = new List<string>();
                    foreach (XmlNode territory in xmlServerTerritories.ChildNodes)
                        territoryIDs.Add(territory.InnerText);

                    List<Territory> serverTerritories = new List<Territory>();

                    foreach (Territory territory in frmMain.listTerritories)
                    {
                        if (territoryIDs.Contains(territory.id))
                            serverTerritories.Add(territory);
                    }

                    Server newServer = new Server(serverID, serverName, serverIP, serverAutoGrabName, serverTerritories);
                    frmMain.listServers.Add(newServer);
                }
            }
            catch (Exception ex)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error Loading XML!", body: ex.Message);
            }
        }

        public static void UpdateTreeList()
        {
            TreeView mainTree = Application.OpenForms["frmMain"].Controls["mainTree"] as TreeView;

            mainTree.Nodes.Clear();
            mainTree.Nodes.Add("Servers and Territories");

            foreach (Server server in frmMain.listServers)
            {
                TreeNode newServerNode = new TreeNode();
                newServerNode.Text = frmMain.getServerTreeNodeText(server.Name, server.Ip);
                newServerNode.Tag = server;
                mainTree.TopNode.Nodes.Add(newServerNode);

                foreach (Territory territory in server.Territories)
                {
                    TreeNode newTerritoryNode = new TreeNode();
                    newTerritoryNode.Text = territory.Name;
                    newTerritoryNode.Tag = territory;
                    newServerNode.Nodes.Add(newTerritoryNode);
                }
            }

            mainTree.ExpandAll();
        }
    }
}

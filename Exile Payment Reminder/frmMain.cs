using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ToastNotifications;
using System.Xml;
using System.IO;
using System.Web;
using System.Net;
using HtmlAgilityPack;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Threading;
using System.Net.NetworkInformation;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Security.Permissions;

namespace Exile_Payment_Reminder
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        #region Variables
        /// <summary>
        /// Holds some of the variables and objects used in our program.
        /// </summary>
        internal static List<Server> listServers = new List<Server>(); //contains a list of Server class instances
        internal static List<Territory> listTerritories = new List<Territory>(); //contains a list of Territory class instances
        private static List<Server> pingedServers = new List<Server>(); //contains a list of Server class instances which we have already checked the status of

        private static readonly Random random = new Random(); //used for random integers
        private static readonly object syncLock = new object(); //used for Random class

        private static string selectedServerID = "SERVER_abc123"; //default serverID
        private static string selectedTerritoryID = "TERRITORY_abc123"; //default territoryID
        private static string selectedIDType = "SERVER"; //currently selected id type of treeview node
        private static string savedOwnerGUID = string.Empty;
        public static string defaultOwnerGUID = string.Empty;

        private bool internetEnabled = false; //a check to see if end user has an active internet connection
        private bool allowVisible;     // ContextMenu's Show command used
        private bool allowClose;       // ContextMenu's Exit command used
        private bool alreadyClosing = false;
        public static bool isDebug = false; //not used
        private bool askToClose = true; //ask the user if they want to close first
        private bool unsavedChanges = false; //if program has unsaved changes
        public static bool suppressErrors = false;
        public static bool dismissingNotifications = false;
        public static bool autoSave = true;

        public static Form mainForm;

        public static string UserSteamAPIKey;

        //private static SessionEndingEventHandler systemShutdown = new SessionEndingEventHandler(HandleShutdown);


        //Used for notifications
        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X1;
        const int AW_HOR_NEGATIVE = 0X2;
        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags); //used for notifications

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Our main constructor method. Creates components on our form, and is used to get/set registry keys and create new XML files if applicable.
        /// </summary>
        public frmMain(params string[] startParams)
        {

            InitializeComponent();

            SystemEvents.SessionEnding += (sender, e) => HandleExit();
            Application.ThreadExit += (sender, e) => HandleExit();
            
            mainForm = this;
            StartNotifications();

            //RegistryKey rk = Registry.CurrentUser.OpenSubKey
            //("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            //string AppName = "Exile Territory Management";
            //rk.SetValue(AppName, Application.ExecutablePath.ToString());

            //rk.Close();


            RegistryKey registryPath = Registry.CurrentUser.CreateSubKey
                     ("SOFTWARE\\Bravo Foxtrot Company\\Exile Territory Management");

            //Let's get registry keys
            bool? FirstRun = Convert.ToBoolean(registryPath.GetValue(name: "FirstRun", defaultValue: null));
            string SavedPath = registryPath.GetValue(name: "SavedPath", defaultValue: XML.savedXmlFile).ToString();
            bool PlaySounds = Convert.ToBoolean(registryPath.GetValue(name: "PlaySounds", defaultValue: true));
            int maxNotifications = Convert.ToInt32(registryPath.GetValue(name: "MaxNotificationsOnScreen", defaultValue: 4));
            bool AskToClose = Convert.ToBoolean(registryPath.GetValue(name: "AskToClose", defaultValue: true));
            string SteamAPIKey = Convert.ToString(registryPath.GetValue(name: "SteamAPIKey", defaultValue: null)).ToString();
            bool AutomagicallySave = Convert.ToBoolean(registryPath.GetValue(name: "AutoSave", defaultValue: true));
            bool SuppressErrors = Convert.ToBoolean(registryPath.GetValue(name: "SuppressErrors", defaultValue: false));
            string DefaultOwnerGUID = registryPath.GetValue(name: "DefaultOwnerGUID", defaultValue: string.Empty).ToString();

            if (registryPath.ValueCount < 1)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: "Unable to read registry keys! No keys exist. Default keys created...");

                if (!File.Exists(XML.savedXmlFile))
                    XML.CreateNewXml(XML.savedXmlFile);

                registryPath.SetValue(name: "FirstRun", value: false);
                registryPath.SetValue(name: "SavedPath", value: XML.savedXmlFile);
                registryPath.SetValue(name: "PlaySounds", value: true);
                registryPath.SetValue(name: "MaxNotificationsOnScreen", value: 4);
                registryPath.SetValue(name: "AskToClose", value: true);
                registryPath.SetValue(name: "AutoSave", value: true);
                registryPath.SetValue(name: "SuppressErrors", value: false);
                registryPath.SetValue(name: "DefaultOwnerGUID", value: string.Empty);
                registryPath.SetValue(name: "SteamAPIKey", value: string.Empty);
            }

            if (!FirstRun.HasValue)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: "Unable to read registry key 'FirstRun'");
                registryPath.SetValue(name: "FirstRun", value: true);
                registryPath.SetValue(name: "SavedPath", value: XML.savedXmlFile);
                registryPath.SetValue(name: "PlaySounds", value: true);
                registryPath.SetValue(name: "MaxNotificationsOnScreen", value: 4);
                registryPath.SetValue(name: "AskToClose", value: true);
                registryPath.SetValue(name: "AutoSave", value: true);
                registryPath.SetValue(name: "SuppressErrors", value: false);
                registryPath.SetValue(name: "DefaultOwnerGUID", value: string.Empty);
                registryPath.SetValue(name: "SteamAPIKey", value: string.Empty);
            }
            else
            {
                if (!FirstRun.Value)
                {
                    XML.savedXmlFile = SavedPath;
                    frmMainNotifications.playSounds = PlaySounds;
                    frmMainNotifications.maxNotificationsOnScreen = maxNotifications;
                    askToClose = AskToClose;
                    suppressErrors = SuppressErrors;
                    defaultOwnerGUID = DefaultOwnerGUID;
                    UserSteamAPIKey = SteamAPIKey;
                    autoSave = AutomagicallySave;
                }
                else
                {
                    if (!File.Exists(XML.savedXmlFile))
                        XML.CreateNewXml(XML.savedXmlFile);

                    registryPath.SetValue(name: "FirstRun", value: false);
                    registryPath.SetValue(name: "SavedPath", value: XML.savedXmlFile);
                    registryPath.SetValue(name: "PlaySounds", value: true);
                    registryPath.SetValue(name: "MaxNotificationsOnScreen", value: 4);
                    registryPath.SetValue(name: "AskToClose", value: true);
                    registryPath.SetValue(name: "AutoSave", value: true);
                    registryPath.SetValue(name: "SuppressErrors", value: false);
                    registryPath.SetValue(name: "DefaultOwnerGUID", value: string.Empty);
                    registryPath.SetValue(name: "SteamAPIKey", value: string.Empty);

                    frmMainNotifications.playSounds = true;
                    frmMainNotifications.maxNotificationsOnScreen = 4;
                    askToClose = true;
                    suppressErrors = false;
                    defaultOwnerGUID = string.Empty;
                    UserSteamAPIKey = string.Empty;
                    autoSave = true;
                }
            }

            if (SteamAPIKey != null)
            {
                UserSteamAPIKey = SteamAPIKey;
            }

            registryPath.Close();
            initMain(startParams);
        }

        #endregion Constructor

        #region Overrides
        /// <summary>
        /// Form overrides for frmMain. Keeps the form from exiting when pressing the X at the top.
        /// </summary>
        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall || e.CloseReason == CloseReason.TaskManagerClosing &&!alreadyClosing)
                HandleExit();

            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
        #endregion Overrides

        #region Methods

        /// <summary>
        /// A method which reads command line execution arguments, populates our lists from the saved XML, and then shows all payment reminder notifications.
        /// </summary>
        private void initMain(params string[] startParams)
        {
            bool showForm = false;
            bool shutdown = false;

            foreach (string param in startParams)
            {
                int paramIndex = startParams.ToList().FindIndex(element => element == param);
                switch (param.ToLower())
                {
                    case "-showmainform":
                        showForm = true;
                        break;
                    case "-shutdown":
                        string param2 = startParams[paramIndex + 1];
                        if (isNull(param2))
                            break;

                        if (param2 == "all" || param2 == "other")
                        {
                            int currentProcessID = Process.GetCurrentProcess().Id;
                            Process[] listProcesses = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location));
                            foreach (Process process in listProcesses)
                            {
                                if (process.Id != currentProcessID)
                                    process.Kill();
                            }

                            if (param2 == "all")
                                shutdown = true;
                        }
                        break;
                }
            }

            if (shutdown)
            {
                ExilePaymentTrayIcon.Visible = false;
                ExilePaymentTrayIcon.Dispose();
                Application.Exit();
            }

            PopulateLists();
            ShowAllPaymentReminders();

            if (showForm)
            {
                allowVisible = true;
                Show();
            }
        }

        /// <summary>
        /// A method which begins the notification queue process
        /// </summary>
        private static void StartNotifications()
        {
            frmMainNotifications.RaiseEvents();
            frmMainNotifications.BeginNotificationQueue();
        }

        /// <summary>
        /// Sets a new registry value with the specified key name and data
        /// </summary>
        private void CreateRegistryValue(string value, string data)
        {
            RegistryKey MyReg = Registry.CurrentUser.CreateSubKey
                     ("SOFTWARE\\Bravo Foxtrot Company\\Exile Territory Management");
            MyReg.SetValue(value, data);
            MyReg.Flush();
            MyReg.Close();
        }

        /// <summary>
        /// Opens the saved XML and reads the Server and Territory nodes to recreate them in the XML class' xmlDoc document.
        /// </summary>
        public static void PopulateLists()
        {
            if (!File.Exists(XML.savedXmlFile))
            {
                XML.CreateNewXml(XML.savedXmlFile);
            }
            else
            {
                XML.PopulateLists();
            }
        }

        /// <summary>
        /// Gets all the territory payments that are due today, and displays the notification. Only shows the max amount of notifications allowed on screen.
        /// </summary>
        public static void ShowAllPaymentReminders()
        {
            foreach(Territory territory in listTerritories)
            {
                DateTime now = DateTime.Now;
                if (territory.ReceiveNotificationsID == 0)
                    continue;
                
                if (territory.ReceiveNotificationsID == 1 || territory.ReceiveNotificationsID == 2)
                {
                    if (territory.PaymentDate < now)
                    {
                        frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Uh Oh!", body: "Payment for territory '" + territory.Name + "' is past due! Did you make your payment?");
                        continue;
                    }

                    int daysBeforePayment = Convert.ToInt32((territory.PaymentDate - now).TotalDays);
                    switch (territory.ReceiveNotificationsID)
                    {
                        case 0:
                            break;
                        case 1:
                            if (daysBeforePayment <= 1)
                                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Payment for Territory", body: "Your territory payment for '" + territory.Name + "' is due tomorrow!");
                            else
                                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Payment for Territory", body: "Your territory payment for '" + territory.Name + "' is due in " + daysBeforePayment + " day(s)");
                            break;
                        case 2:
                            if (daysBeforePayment <= 1)
                                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Payment for Territory", body: "Your territory payment for '" + territory.Name + "' is due tomorrow!");
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Returns a string list of all Server IDs
        /// </summary>
        public List<string> GrabServerIDs()
        {
            var IDs = new List<string>();

            foreach (Server server in listServers)
                IDs.Add(server.id);

            return IDs;
        }

        /// <summary>
        /// Returns a string list of all Server Names
        /// </summary>
        public static List<string> GrabServerNames()
        {
            var names = new List<string>();

            foreach (Server server in listServers)
                names.Add(server.Name);

            return names;
        }

        /// <summary>
        /// Returns a string list of all Territory IDs
        /// </summary>
        public List<string> GrabTerritoryIDs()
        {
            var IDs = new List<string>();

            foreach (Territory territory in listTerritories)
                IDs.Add(territory.id);

            return IDs;
        }

        /// <summary>
        /// Returns a string list of ALL Server and Territory IDs combined in one list
        /// </summary>
        public List<string> GrabAllIDs()
        {
            var IDs = new List<string>();

            foreach (Server server in listServers)
                IDs.Add(server.id);

            foreach (Territory territory in listTerritories)
                IDs.Add(territory.id);

            return IDs;
        }

        /// <summary>
        /// Returns a random ID for a server or territory. Prefix being 'SERVER' or 'TERRITORY'. count parameter is how many times the method has failed to retrieve an ID before returning null.
        /// </summary>
        public string returnID(string prefix, int count = 0)
        {
            int IDSuffixLength = 8; //the length of the ID suffix after the _ in the ID
            int MaxIDCountTries = 30; //to prevent this function running forever

            if (count > MaxIDCountTries)
                return null;

            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string testID = prefix + "_";
            while (testID.Substring(testID.IndexOf('_') + 1).Length < IDSuffixLength)
            {
                testID = testID + chars[randomintrange(0, chars.Length)];
            }

            List<string> allIDs = GrabAllIDs();
            bool exists = Array.Exists(allIDs.ToArray(), element => element == testID);

            if (exists)
            {
                count++;
                return returnID(prefix, count);
            }
            else return testID;
        }

        /// <summary>
        /// Returns a random integer between min and max
        /// </summary>
        public int randomintrange(int min, int max)
        {
            lock (syncLock)
            {
                return (int) (random.Next(min, max));
            }
        }

        /// <summary>
        /// Returns a string array of all strings between the seperator
        /// </summary>
        public string[] StrTok(string str, char[] seperator)
        {
            string[] split = str.Split(seperator);

            return split;
        }

        /// <summary>
        /// Returns the server name if a user has chosen to automatically grab the server name from the internet, otherwise returns name from new server text input box.
        /// </summary>
        private string getServerName(string serverName, string IP, bool? GrabNameFromInternet)
        {
            if (GrabNameFromInternet.Value)
            {
                string urlAddress = "https://www.gametracker.com/server_info/" + IP;
                string data = WebRequests.createWebRequest(urlAddress);

                if (data == null)
                {
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "getServerName Error", body: "Data is null.");
                    return null;
                }

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(data);

                var titlenode = doc.DocumentNode.Descendants("span").Where(n => n.Attributes["class"] != null && n.Attributes["class"].Value == "blocknewheadertitle").ToArray();

                if (titlenode == null || titlenode.Length < 1)
                {
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Invalid Server!", body: "Unable to retrieve info about server!");
                    return null;
                }

                return titlenode[0].InnerText.Trim(' ', '\n', '\t');
            }
            else
                return serverName;
        }

        /// <summary>
        /// Returns TreeView node text to display depending on name and IP
        /// </summary>
        internal static string getServerTreeNodeText(string name, string ip = null)
        {
            string iptext = isNull(ip) ? "IP Not Found" : ip;
            return name + " (" + iptext + ")";
        }

        /// <summary>
        /// Returns bool if string is empty or null
        /// </summary>
        private static bool isNull(string str)
        {
            return (str == null || str == "");
        }

        /// <summary>
        /// Expands the TreeView control
        /// </summary>
        private void ExpandTreeView()
        {
            mainTree.ExpandAll();
        }

        /// <summary>
        /// Sets the label text of every label in the right side panel
        /// </summary>
        private void UpdatePanelInfo(string type, Server? server = null, Territory? territory = null)
        {
            try
            {
                if (type == "SERVER")
                {
                    string serverIP = (isNull(server.Value.Ip) ? "Unknown" : server.Value.Ip);
                    string serverStatus = (isNull(server.Value.Ip) ? "OFFLINE (UNABLE TO PING IP)" : PingServerGetResponse(server.Value.Ip));
                    string serverPlayers = (isNull(server.Value.Ip) ? "0/0" : returnStrPlayerCount(server.Value.Ip));

                    this.Invoke((MethodInvoker) delegate ()
                    {
                        lblPanelServerIP.Text = "Server IP: " + serverIP;
                        lblPanelServerStatus.Text = "Server Status: " + serverStatus;
                        lblPanelServerPlayersOnline.Text = "Players Online: " + serverPlayers;


                        checkReceiveNotifs.Checked = false;
                        lblPanelTerritoryName.Text = "Territory Name:";
                        lblPanelTerritoryPaymentDue.Text = "Territory Payment Due:";

                        btnEditBuildRightsOwners.Enabled = false;
                        btnMadePayment.Enabled = false;
                    });
                }
                else if (type == "TERRITORY")
                {
                    this.Invoke((MethodInvoker) delegate ()
                    {
                        lblPanelServerIP.Text = "Server IP:";
                        lblPanelServerStatus.Text = "Server Status:";
                        lblPanelServerPlayersOnline.Text = "Players Online:";


                        checkReceiveNotifs.Checked = Convert.ToBoolean(territory.Value.ReceiveNotificationsID);
                        lblPanelTerritoryName.Text = "Territory Name: " + territory.Value.Name;
                        lblPanelTerritoryPaymentDue.Text = "Territory Payment Due: " + territory.Value.PaymentDate.ToString("MM/dd/yyyy hh:mm:ss");

                        btnEditBuildRightsOwners.Enabled = true;
                        btnMadePayment.Enabled = true;
                    });
                }
                else if (type == "EMPTY")
                {
                    this.Invoke((MethodInvoker) delegate ()
                    {
                        lblPanelServerIP.Text = "Server IP:";
                        lblPanelServerStatus.Text = "Server Status:";
                        lblPanelServerPlayersOnline.Text = "Players Online:";

                        checkReceiveNotifs.Checked = false;
                        lblPanelTerritoryName.Text = "Territory Name:";
                        lblPanelTerritoryPaymentDue.Text = "Territory Payment Due:";

                        btnEditBuildRightsOwners.Enabled = false;
                        btnMadePayment.Enabled = false;
                    });
                }
            }
            catch (Exception ex)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: ex.Message);
            }
        }

        /// <summary>
        /// Creates a webRequest to the gametracker website and returns 'OFFLINE' or 'ONLINE' if the game server exists
        /// </summary>
        private static string PingServerGetResponse(string ip = null)
        {
            if (ip == null)
                return string.Empty;

            if (pingedServers.Exists(element => element.Ip == ip))
                return pingedServers.Find(element => element.Ip == ip).responseStatus;
            else
            {
                //string id = listServers.Find(element => element.Ip == ip).id;
                int index = listServers.FindIndex(element => element.Ip == ip);

                if (index > -1)
                {
                    Server server = listServers.ElementAt(index);

                    try
                    {
                        string data = WebRequests.createWebRequest("https://www.gametracker.com/server_info/" + ip);

                        if (data == string.Empty || data == null)
                        {
                            frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Get Server Status Error!", body: "Unable to retrieve server status. WebRequest is null!");
                            return data;
                        }

                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(data);


                        var nodes = doc.DocumentNode.Descendants("span").Where(n => n.Attributes["class"] != null && n.Attributes["class"].Value == "item_color_success").ToArray();
                        bool foundStatus = false;
                        foreach (var node in nodes)
                        {
                            string str = node.InnerText.Trim(' ', '\n', '\t');
                            if (str == "Alive")
                            {
                                foundStatus = true;
                                break;
                            }

                        }
                        if (foundStatus)
                        {
                            server.responseStatus = "ONLINE";
                            pingedServers.Add(server);
                            return "ONLINE";
                        }
                        else
                        {
                            server.responseStatus = "OFFLINE";
                            pingedServers.Add(server);
                            return "OFFLINE";
                        }
                    }
                    catch (Exception ex)
                    {
                        frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Exception Error!", body: ex.Message);
                    }
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// Creates a webRequest to the gametracker website and returns the player count of the game server, if it exists
        /// </summary>
        private static string returnStrPlayerCount(string ip = null)
        {
            try
            {
                string data = WebRequests.createWebRequest("https://www.gametracker.com/server_info/" + ip);

                if (data == null)
                {
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "returnStrPlayerCount Error", body: "WebRequest Data is null.");
                    return null;
                }

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(data);

                var curplayernode = doc.GetElementbyId("HTML_num_players");
                var maxplayernode = doc.GetElementbyId("HTML_max_players");

                if (curplayernode != null && maxplayernode != null)
                    return curplayernode.InnerText.Trim(' ', '\n', '\t') + "/" + maxplayernode.InnerText.Trim(' ', '\n', '\t');
                else
                {
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error Getting Player Count!", body: "Unable to retrieve player count for server! Please check your IP!");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: "Try and catch statement failed getting player count.");
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: ex.Message);
            }

            return string.Empty;
        }

        /// <summary>
        /// Opens a Edit form depending on the node type
        /// </summary>
        private void EditTreeNode()
        {
            TreeNode selectedItem = mainTree.SelectedNode;

            if (selectedItem == null)
                return;

            Object tag = selectedItem.Tag;

            if (tag == null)
                return;

            if (tag.GetType() == typeof(Server))
            {
                Server server = (Server) tag;

                inputNewServer editServer = new inputNewServer(server.Name, server.Ip, server.GetNameFromInternet, true);
                if (editServer.ShowDialog() == DialogResult.OK)
                {
                    string ServerID = server.id;
                    string ServerName = editServer.ServerName;
                    string IPAddress = editServer.IPAddress;
                    bool AutoGrabFromInternet = editServer.AutoGrabName;
                    List<Territory> territories = server.Territories;
                    string responseStatus = server.responseStatus;

                    int ServerIndex = XML.ReturnServerNodeIndex(ServerID);
                    int ListServerIndex = listServers.FindIndex(element => element.id == ServerID);

                    if (ServerIndex < 0 || ListServerIndex < 0)
                        return;

                    string newName = getServerName(ServerName, IPAddress, AutoGrabFromInternet);
                    XML.RemoveServerNode(ServerID);
                    Server newServer = new Server(ServerID, newName, IPAddress, AutoGrabFromInternet, territories, responseStatus);
                    listServers[ListServerIndex] = newServer;
                    selectedItem.Tag = listServers[ListServerIndex];
                    XML.CreateNewServerNode(ServerID, ServerName, IPAddress, AutoGrabFromInternet, territories);
                    XML.UpdateTreeList();

                    if (autoSave)
                        SaveXML();
                    else
                        ShowUnsavedChangesLabel();

                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Success", body: "Successfully edited the server '" + ServerName + "'!");
                }
            }
            else if (tag.GetType() == typeof(Territory))
            {
                Territory territory = (Territory) tag;

                inputNewTerritory editTerritory = new inputNewTerritory(territory.Name, territory.BuildRightOwners[0].Substring(0, 17), territory.PaymentDate, territory.ReceiveNotificationsID, true);
                if (editTerritory.ShowDialog() == DialogResult.OK)
                {
                    string TerritoryID = territory.id;
                    string ParentID = territory.parentID;
                    string TerritoryName = editTerritory.TerritoryName;
                    DateTime PaymentDate = editTerritory.paymentDate;
                    int ReceiveNotificationID = editTerritory.receiveNotificationsID;
                    string OwnerGUID = editTerritory.GUID;
                    List<string> BuildRightsOwners = territory.BuildRightOwners;
                    string personaname = editTerritoryGUIDs.GetSteamProfileName(OwnerGUID);

                    BuildRightsOwners[0] = OwnerGUID + " (" + personaname + ")";

                    int xmlindex = XML.ReturnTerritoryNodeIndex(TerritoryID);
                    int ListTerritoryIndex = listTerritories.FindIndex(element => element.id == TerritoryID);
                    int ListServerIndexOfParentServer = XML.ReturnParentServerIndex(TerritoryID, ParentID);
                    int territoryIndexOfParentServer = listServers[ListServerIndexOfParentServer].Territories.FindIndex(element => element.id == TerritoryID);

                    if (xmlindex < 0 || ListTerritoryIndex < 0 || ListServerIndexOfParentServer < 0 || territoryIndexOfParentServer < 0)
                        return;

                    Territory newTerritory = new Territory(TerritoryID, ParentID, TerritoryName, PaymentDate, ReceiveNotificationID, BuildRightsOwners);
                    XML.RemoveTerritoryNode(TerritoryID, ParentID);
                    listTerritories[ListTerritoryIndex] = newTerritory;

                    listServers[ListServerIndexOfParentServer].Territories[territoryIndexOfParentServer] = listTerritories[ListTerritoryIndex]; 
                    selectedItem.Tag = listTerritories[ListTerritoryIndex];
                    XML.CreateNewTerritoryNode(TerritoryID, ParentID, TerritoryName, PaymentDate, ReceiveNotificationID, BuildRightsOwners);
                    XML.UpdateTreeList();

                    if (autoSave)
                        SaveXML();
                    else
                        ShowUnsavedChangesLabel();

                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Success", body: "Successfully edited the territory '" + TerritoryName + "'!");
                }
            }

            this.Activate();
        }

        /// <summary>
        /// Saves the XML to the savedXML file path
        /// </summary>
        private void SaveXML()
        {
            unsavedChanges = false;
            lblUnsavedChanges.Visible = false;
            XML.Save(XML.savedXmlFile);

            frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Saved", body: "Your servers and territories have been successfully saved.");
        }

        /// <summary>
        /// Removes a TreeView Item, the server and/or territory from the lists, and its corresponding XML node(s) in the xmlDoc
        /// </summary>
        private void RemoveItem(TreeNode node = null)
        {
            if (node == null)
                return;

            Object tag = node.Tag;

            if (tag.GetType() == typeof(Server)) //if selected item is server
            {
                Server selectedItem = (Server) tag;
                string serverName = selectedItem.Name;
                int serverListIndex = listServers.FindIndex(element => element.id == selectedItem.id);

                if (node.Nodes.Count > 0) //if node has children (territories in this case)
                {
                    foreach (TreeNode _node in node.Nodes)
                        RemoveItem(_node); //will call this function for all territories

                    while (node.Nodes.Count > 0) //must delete nodes 1 at a time, or it skips some nodes
                    {
                        if (node.Nodes[0] != null)
                            node.Nodes[0].Remove();
                    }
                }


                XML.RemoveServerNode(selectedItem.id);
                node.Remove();
                listServers.RemoveAt(serverListIndex);

                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Removed Server", body: "Successfully removed server '" + serverName + "'!");
                /*if (autoSave)
                    XML.Save(XML.savedXmlFile);
                else
                    ShowUnsavedChangesLabel();*/
            }
            else if (tag.GetType() == typeof(Territory))
            {
                Territory selectedItem = (Territory) tag;
                string territoryName = selectedItem.Name;
                int territoryListIndex = listTerritories.FindIndex(element => element.id == selectedItem.id);

                string parentID = selectedItem.parentID;
                string territoryID = selectedItem.id;

                int getServerListIndex = listServers.FindIndex(element => element.id == parentID);
                int getTerritoryIndexOfServer = listServers[getServerListIndex].Territories.FindIndex(element => element.id == territoryID);

                listServers[getServerListIndex].Territories.RemoveAt(getTerritoryIndexOfServer);

                XML.RemoveTerritoryNode(territoryID, parentID);

                listTerritories.RemoveAt(territoryListIndex);

                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Removed Territory", body: "Successfully removed territory '" + territoryName + "'!");
                //unsavedChanges = true;
                //lblUnsavedChanges.Visible = true;
            }
            else { return; }
        }

        private void ShowUnsavedChangesLabel()
        {
            if (autoSave)
                return;

            unsavedChanges = true;
            lblUnsavedChanges.Visible = true;
        }

        #endregion Methods

        #region EventHandlers

        /// <summary>
        /// EventHandler for onFormLoad, which sets control properties and updates tree list
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            picDivider_1.Padding = new Padding(0);
            picDivider_1.BorderStyle = System.Windows.Forms.BorderStyle.None;

            picExileLogoAboutMe.Padding = new Padding(0);
            picExileLogoAboutMe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tipExileLogo.SetToolTip(picExileLogoAboutMe, "Right click to access settings, about me, our forums, and the notification logs. You can also save your XML or open a new XML file.");

            XML.UpdateTreeList();
        }

        /// <summary>
        /// Show the main form when the menu item is clicked
        /// </summary>
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowVisible = true;
            Show();
        }

        /// <summary>
        /// Exits the application when the menu item is clicked
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!askToClose)
            {
                XML.xmlDoc.Save(XML.savedXmlFile);

                allowClose = true;
                Application.Exit();
            }

            if (allowClose)
                return;

            ExitMessageDialog exitConfirmation = new ExitMessageDialog();
            if (exitConfirmation.ShowDialog() == DialogResult.OK)
            {
                bool bGetCheckState = exitConfirmation.AskToCloseAgain;
                allowClose = true;

                RegistryKey registryPath = Registry.CurrentUser.CreateSubKey
                     ("SOFTWARE\\Bravo Foxtrot Company\\Exile Territory Management");

                registryPath.SetValue(name: "AskToClose", value: bGetCheckState);
                registryPath.Close();

                if (autoSave)
                {
                    XML.Save(XML.savedXmlFile);
                    Application.Exit();
                }

                if (unsavedChanges)
                {
                    if (MessageBox.Show("You have unsaved changes. Would you like to save them?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        XML.xmlDoc.Save(XML.savedXmlFile);
                }

                Application.Exit();
            }
        }

        /// <summary>
        /// Opens a form to add/edit buildrightowners of the selected territory
        /// </summary>
        private void btnEditBuildRightsOwners_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null)
                return;

            if (mainTree.SelectedNode.Tag == null)
                return;

            Object tag = mainTree.SelectedNode.Tag;

            if (tag.GetType() == typeof(Territory))
            {
                Territory territory = (Territory) tag;
                editTerritoryGUIDs buildRightsOwnersForm = new editTerritoryGUIDs();
                int index = listTerritories.FindIndex(element => element.id == territory.id);
                buildRightsOwnersForm.GUIDs = listTerritories[index].BuildRightOwners;

                if (buildRightsOwnersForm.ShowDialog() == DialogResult.OK)
                {

                    List<string> newGUIDs = buildRightsOwnersForm.GUIDs;
                    int territoryIndex = listTerritories.FindIndex(element => element.id == territory.id);

                    Territory newTerritory = new Territory(territory.id, territory.parentID, territory.Name, territory.PaymentDate, territory.ReceiveNotificationsID, newGUIDs);
                    listTerritories[territoryIndex] = newTerritory;

                    tag = listTerritories[territoryIndex];

                    XML.ReplaceBuildRightsOwners(territory.id, newGUIDs);

                    if (autoSave)
                        SaveXML();
                    else
                        ShowUnsavedChangesLabel();
                }
            }
            this.Activate();
        }

        /// <summary>
        /// Call RemoveItem to remove the selected TreeView node if node is not null and is a valid node
        /// </summary>
        private void onRemoveSelectedMenuItemClick(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null)
                return;

            if (mainTree.SelectedNode.Tag == null)
                return;

            Object tag = mainTree.SelectedNode.Tag;
            string name = string.Empty;

            if (tag.GetType() == typeof(Server))
            {
                Server selectedItem = (Server) tag;
                name = selectedItem.Name;
            }
            else if (tag.GetType() == typeof(Territory))
            {
                Territory selectedItem = (Territory) tag;
                name = selectedItem.Name;
            }

            if (name == null || name == string.Empty)
                return;

            if (MessageBox.Show("Are you sure you wish to delete " + name + "?", "Delete Selected Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TreeNode selectedNode = mainTree.SelectedNode;

                RemoveItem(selectedNode);
                XML.UpdateTreeList();

                if (autoSave)
                    SaveXML();
                else
                    ShowUnsavedChangesLabel();
            }
        }

        /// <summary>
        /// Opens a form to add a new territory to the selected server
        /// </summary>
        private void addNewTerritoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null)
                return;
            if (mainTree.SelectedNode.Tag == null)
                return;

            if (mainTree.SelectedNode.Tag.GetType() == typeof(Territory))
                return;

            Server parentServer = (Server) mainTree.SelectedNode.Tag;
            string parentID = parentServer.id;

            inputNewTerritory form = new inputNewTerritory(_Owner: defaultOwnerGUID);
            //form.savedOwnerGUID = savedOwnerGUID;
            if (form.ShowDialog() == DialogResult.OK)
            {
                string ID = returnID("Territory");
                string Name = form.TerritoryName;
                string GUID = form.GUID;
                DateTime paymentDate = form.paymentDate;
                bool receiveNotifs = form.receiveNotifs;
                string NotifsRate = form.receiveNotifsRate;
                int notificationID = 0;
                if (receiveNotifs)
                {
                    switch (form.receiveNotifsRate.ToLower())
                    {
                        case "never":
                            notificationID = 0;
                            break;
                        case "daily":
                            notificationID = 1;
                            break;
                        case "day before payment":
                            notificationID = 2;
                            break;
                        default:
                            notificationID = 0;
                            break;
                    }
                }

                List<string> buildRightOwners = new List<string>();
                string personaname = editTerritoryGUIDs.GetSteamProfileName(GUID);

                buildRightOwners.Add(GUID + " (" + personaname + ")");

                Territory newTerritory = new Territory(ID, parentID, Name, paymentDate, notificationID, buildRightOwners);
                listTerritories.Add(newTerritory);
                int index = listTerritories.FindIndex(element => element.id == ID);

                parentServer.Territories.Add(listTerritories[index]);
                mainTree.SelectedNode.Nodes.Add(Name).Tag = listTerritories[index];

                XML.CreateNewTerritoryNode(ID, parentID, Name, paymentDate, notificationID, buildRightOwners);

                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Success!", body: "Your territory '" + Name + "' has been added!");
                ExpandTreeView();

                if (autoSave)
                    SaveXML();
                else
                    ShowUnsavedChangesLabel();
            }

            this.Activate();
        }

        /// <summary>
        /// Self explanatory
        /// </summary>
        private void ShowMainForm(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
        }

        /// <summary>
        /// Opens a form to add a new server
        /// </summary>
        private void AddNewServer(object sender, EventArgs e)
        {
            var Thread = new Thread(() =>
            {
                inputNewServer form = new inputNewServer();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string ID = returnID("SERVER");
                    string ServerName = form.ServerName;
                    string Ip = form.IPAddress;
                    bool GrabNameFromInternet = form.AutoGrabName;
                    string newName = getServerName(ServerName, Ip, GrabNameFromInternet);

                    bool error = false;

                    if (newName == null || newName == string.Empty)
                    {
                        error = true;
                        mainForm.Invoke((MethodInvoker) delegate ()
                        {
                            frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Server Creation Error!", body: "Unable to create new server!");
                        });
                    }

                    if (!error)
                    {
                        List<Territory> territories = new List<Territory>();
                        Server newServer = new Server(ID, newName, Ip, GrabNameFromInternet, territories);
                        listServers.Add(newServer);
                        int index = listServers.FindIndex(element => element.id == ID);

                        if (index < 0)
                            return;

                        mainForm.Invoke((MethodInvoker) delegate ()
                        {
                            mainTree.TopNode.Nodes.Add(getServerTreeNodeText(newName, Ip)).Tag = listServers[index];
                            ExpandTreeView();
                            frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Success!", body: "Your server " + newName + " has been added!");
                            if (autoSave)
                                SaveXML();
                            else
                                ShowUnsavedChangesLabel();
                            mainForm.Activate();
                        });

                        XML.CreateNewServerNode(ID, newName, Ip, GrabNameFromInternet, territories);
                    }
                    /*else
                    {
                        mainForm.Invoke((MethodInvoker) delegate ()
                        {
                            frmMainNotifications.ShowNotification(isError: true, title: "Server Creation Error!", body: "Unable to create new server!");
                        });
                    }*/
                }
            });
            Thread.Start();
        }

        /// <summary>
        /// Updates labels in panel for newly selected TreeView node
        /// </summary>
        private void TreeViewSelectionChanged(object sender, TreeViewEventArgs e)
        {
            var Thread = new Thread(() =>
            {
                try
                {
                    if (mainTree == null)
                        return;

                    if (e.Node == null)
                        return;

                    TreeNode node = e.Node;

                    if (node == null)
                        return;

                    if (this.mainTree.InvokeRequired)
                    {
                        mainForm.Invoke((MethodInvoker) delegate ()
                        {
                            if (node == mainTree.TopNode)
                            {
                                UpdatePanelInfo("EMPTY");
                                return;
                            }
                        });
                    }
                    else
                    {
                        node = mainTree.TopNode;
                        UpdatePanelInfo("EMPTY");
                        return;
                    }

                    object tag = node.Tag;

                    if (tag == null)
                        return;

                    Type tagtype = tag.GetType();
                    Server server;
                    Territory territory;

                    if (tagtype == typeof(Server))
                    {
                        server = (Server) tag;
                        selectedIDType = "SERVER";
                        selectedServerID = server.id;
                        selectedTerritoryID = string.Empty;

                        UpdatePanelInfo("SERVER", server, null);

                    }
                    else if (tagtype == typeof(Territory))
                    {
                        territory = (Territory) tag;
                        selectedServerID = string.Empty;
                        selectedIDType = "TERRITORY";
                        selectedTerritoryID = territory.id;

                        UpdatePanelInfo("TERRITORY", null, territory);
                    }
                }
                catch (Exception ex)
                {
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: ex.Message);
                }
            });
            Thread.Start();
        }

        /// <summary>
        /// Calls EditTreeNode to edit selected node
        /// </summary>
        private void onTreeNodeDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            EditTreeNode();
        }

        /// <summary>
        /// Same as above method
        /// </summary>
        private void onEditSelectedClick(object sender, EventArgs e)
        {
            EditTreeNode();
        }

        /// <summary>
        /// Saves XML to savedXml Path when clicked.
        /// </summary>
        private void onSaveListMenuClick(object sender, EventArgs e)
        {
            SaveXML();
        }

        /// <summary>
        /// Opens a new webpage to the BFC forums in the default browser
        /// </summary>
        private void visitBFCForumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bravofoxtrotcompany.com");
        }

        /// <summary>
        /// Opens the About form
        /// </summary>
        private void readAboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPage newAboutPage = new AboutPage();
            newAboutPage.ShowDialog();
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(XML.savedXmlFile, defaultOwnerGUID, UserSteamAPIKey, frmMainNotifications.maxNotificationsOnScreen, frmMainNotifications.playSounds, askToClose, autoSave, suppressErrors); //open up a new settings form with the current settings
            if (settings.ShowDialog() == DialogResult.OK)
            {
                RegistryKey registryPath = Registry.CurrentUser.CreateSubKey
                     ("SOFTWARE\\Bravo Foxtrot Company\\Exile Territory Management");

                XML.savedXmlFile = settings.savedXmlPath;
                defaultOwnerGUID = settings.defaultGUIDOwner;
                UserSteamAPIKey = settings.steamAPIKey;
                frmMainNotifications.maxNotificationsOnScreen = settings.maxNotifications;
                frmMainNotifications.playSounds = settings.playSounds;
                askToClose = settings.askToClose;
                autoSave = settings.autoSave;
                suppressErrors = settings.suppressErrors;

                registryPath.SetValue(name: "SavedPath", value: settings.savedXmlPath);
                registryPath.SetValue(name: "DefaultOwnerGUID", value: settings.defaultGUIDOwner);
                registryPath.SetValue(name: "SteamAPIKey", value: settings.steamAPIKey);
                registryPath.SetValue(name: "MaxNotificationsOnScreen", value: settings.maxNotifications);
                registryPath.SetValue(name: "PlaySounds", value: settings.playSounds);
                registryPath.SetValue(name: "AskToClose", value: settings.askToClose);
                registryPath.SetValue(name: "AutoSave", value: settings.autoSave);
                registryPath.SetValue(name: "SuppressErrors", value: settings.suppressErrors);

                XML.Save(XML.savedXmlFile);

                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Settings Saved", body: "Your settings have successfully been updated and saved.");
            }
            this.Activate();
        }

        private void dismissAllNotificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dismissingNotifications = true;

            frmMainNotifications.notificationQueue.Clear();

            dismissingNotifications = false;

            foreach (Notification notification in Notification.OpenNotifications)
                notification.Hide();

            Notification.OpenNotifications.Clear();
        }

        private void loadXMLFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unsavedChanges)
            {
                if (autoSave)
                    SaveXML();
                else
                {
                    if (MessageBox.Show("You have unsaved changes. Would you like to save them before opening a new XML?", "Unsaved Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        SaveXML();
                }
            }


            OpenFileDialog openXML = new OpenFileDialog();
            openXML.Title = "Please choose the XML file you would like to load...";
            //openXML.ValidateNames = true;
            openXML.Multiselect = false;
            openXML.DefaultExt = ".xml";
            openXML.Filter = "XML files(*.xml) | *.xml";
            if (openXML.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openXML.FileName) != ".xml")
                {
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: "Cannot open this file. It is not an XML file.");
                    return;
                }

                RegistryKey registryPath = Registry.CurrentUser.CreateSubKey
                    ("SOFTWARE\\Bravo Foxtrot Company\\Exile Territory Management");

                registryPath.SetValue(name: "SavedPath", value: openXML.FileName);
                registryPath.Close();

                XML.savedXmlFile = openXML.FileName;

                mainTree.Nodes.Clear();
                listServers.Clear();
                listTerritories.Clear();
                pingedServers.Clear();
                selectedServerID = string.Empty;
                selectedTerritoryID = string.Empty;
                selectedIDType = string.Empty;

                mainTree.Nodes.Add("Servers and Territories");
                XML.PopulateLists();
                XML.UpdateTreeList();

                if (mainTree.TopNode.Nodes.Count < 1)
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Blank XML", body: "No tree nodes found! Are you sure this is a valid XML?");
                else
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Success", body: "Successfully opened the XML file.");
            }
        }

        private void saveXMLToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XML.Save(XML.savedXmlFile);
            lblUnsavedChanges.Visible = false;
            unsavedChanges = false;
            frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Success", body: "Successfully saved servers and territories to XML.");
        }

        private void btnMadePayment_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null)
                return;

            TreeNode selectedNode = mainTree.SelectedNode;

            if (selectedNode.Tag == null)
                return;

            Object tag = selectedNode.Tag;

            if (tag.GetType() != typeof(Territory))
                return;

            Territory territory = (Territory) tag;

            editTerritoryPaymentDate newDatePicker = new editTerritoryPaymentDate(DateTime.Now);
            if (newDatePicker.ShowDialog() == DialogResult.OK)
            {
                DateTime newSelectedDate = newDatePicker.newPaymentDate;
                string newDateString = newSelectedDate.ToString("MM/dd/yyyy hh:mm:ss");

                int ListTerritoryIndex = listTerritories.FindIndex(element => element.id == territory.id);
                int ListTerritoryXMLIndex = XML.ReturnTerritoryNodeIndex(territory.id);
                int ListParentServerIndex = listServers.FindIndex(element => element.id == territory.parentID);

                if (ListTerritoryIndex < 0 && ListTerritoryXMLIndex < 0 && ListParentServerIndex < 0)
                    return;

                int TerritoryIndexOfParentServer = listServers[ListParentServerIndex].Territories.FindIndex(element => element.id == territory.id);

                if (TerritoryIndexOfParentServer < 0)
                    return;

                XML.xmlDoc.DocumentElement.ChildNodes[1].ChildNodes[ListTerritoryXMLIndex].ChildNodes[3].InnerText = newDateString;
                Territory newTerritory = new Territory(territory.id, territory.parentID, territory.Name, newSelectedDate, territory.ReceiveNotificationsID, territory.BuildRightOwners);
                listTerritories[ListTerritoryIndex] = newTerritory;
                tag = listTerritories[ListTerritoryIndex];
                listServers[ListParentServerIndex].Territories[TerritoryIndexOfParentServer] = listTerritories[ListTerritoryIndex];

                XML.UpdateTreeList();

                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: false, title: "Updated Payment Date", body: "Your payment for '" + territory.Name + "' is now due on " + newSelectedDate.ToString("D"));

                if (autoSave)
                    SaveXML();
                else
                    ShowUnsavedChangesLabel();
            }
        }

        private void viewCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditsDialog credits = new CreditsDialog();
            credits.ShowDialog();
        }

        private void viewNotificationLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notificationLog log = new notificationLog();
            log.ShowDialog();
        }

        private void restorePaymentNotificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllPaymentReminders();
        }

        private void HandleExit()
        {
            if (alreadyClosing)
                return;

            alreadyClosing = true;
            if (frmMain.ActiveForm != null)
            {
                frmMain.ActiveForm.Invoke((MethodInvoker) delegate ()
                {
                    frmMain.ActiveForm.DialogResult = DialogResult.Abort;
                    frmMain.ActiveForm.Close();
                });
            }
            XML.Save(XML.savedXmlFile);

            //systemShutdown = null;
            Application.Exit();
        }

        private void Control_onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
                SaveXML();
            if (e.Control && e.KeyCode == Keys.L)
                loadXMLFromFileToolStripMenuItem_Click(sender, new EventArgs());
        }

        #endregion EventHandlers
    }

    #region Structs

    /// <summary>
    /// A struct which holds our server data. Multiple instances can be created.
    /// </summary>
    public struct Server
    {
        public readonly string id;
        public string Name;
        public string Ip;
        public bool? GetNameFromInternet;
        public List<Territory> Territories;
        public string responseStatus;

        public Server(string id, string name, string ip = null, bool? GetNameFromInternet = null, List<Territory> territories = null, string responseStatus = null)
        {
            this.id = id;
            this.Name = name;
            this.Ip = ip;
            this.GetNameFromInternet = GetNameFromInternet;
            this.Territories = territories;
            this.responseStatus = responseStatus;
        }
    }

    /// <summary>
    /// A struct which holds our territory data. Multiple instances can be created.
    /// </summary>
    public struct Territory
    {
        public readonly string id;
        public string parentID;
        public string Name;
        public DateTime PaymentDate;
        public int ReceiveNotificationsID;
        public List<string> BuildRightOwners;

        public Territory(string id, string parentID, string name, DateTime paymentDate, int receiveNotificationsID, List<string> buildRightOwners = null)
        {
            this.id = id;
            this.parentID = parentID;
            this.Name = name;
            this.PaymentDate = paymentDate;
            this.ReceiveNotificationsID = receiveNotificationsID;
            this.BuildRightOwners = buildRightOwners;
        }
    }

    #endregion Structs

    #region Notifications

    /// <summary>
    /// Class which holds functions related to notifications
    /// </summary>
    public static class frmMainNotifications
    {
        public static bool playSounds = true; //should notifications sounds be played? default is true
        public static int maxNotificationsOnScreen = 4; //maximum number of notifications that can be displayed on screen
        public static int notificationTime = 15; //amount of time that a notification stays on screen in seconds
        public static ObservableCollection<Notification> notificationQueue = new ObservableCollection<Notification>(); //notification queue which holds our notifications currently in the queue to be displayed
        public static List<string> notificationLogs = new List<string>();

        /// <summary>
        /// Sets the onCollectionChanged event for the notificationQueue
        /// </summary>
        public static void RaiseEvents()
        {
            notificationQueue.CollectionChanged += OnCollectionChanged;
        }

        /// <summary>
        /// If collection is changed, fire notification queue method
        /// </summary>
        public static void OnCollectionChanged(object sender, EventArgs e)
        {
            BeginNotificationQueue();
        }

        /// <summary>
        /// Adds a new notification to the queue
        /// </summary>
        public static void AddNotification(Notification notification)
        {
            notificationQueue.Add(notification);
        }

        /// <summary>
        /// Removes a notification from the queue
        /// </summary>
        public static void RemoveNotificationFromQueue(int index)
        {
            notificationQueue.RemoveAt(index);
        }

        /// <summary>
        /// Method which defines a new notification instance and adds it to the queue
        /// </summary>
        public static void ShowNotification(string methodname, bool isError, string title, string body)
        {
            var animationMethod = FormAnimator.AnimationMethod.Slide;

            var animationDirection = FormAnimator.AnimationDirection.Up;

            var toastNotification = new Notification(title, body, notificationTime, animationMethod, animationDirection);

            string date_time = DateTime.Now.ToString("hh:mm:ss");

            notificationLogs.Add("[" + date_time + "]: " + methodname + "() - '" + title + "' - " + body + Environment.NewLine);

            if (frmMain.dismissingNotifications)
                return;

            if (isError && frmMain.suppressErrors)
                return;

            AddNotification(toastNotification);
        }

        /// <summary>
        /// Shows the notification which is next in line.
        /// </summary>
        public static void BeginNotificationQueue()
        {
            if (frmMain.dismissingNotifications)
                return;

            if (notificationQueue.Count < 1)
                return;

            if (Notification.OpenNotifications.Count < maxNotificationsOnScreen)
            {
                int index = GetNextNotificationIndex();
                if (index != -1)
                {
                    frmMain.mainForm.Invoke((MethodInvoker) delegate
                    {
                        PlayNotificationSound();
                        if (notificationQueue[index] != null)
                            notificationQueue[index].Show();
                    });
                }
            }

        }

        /// <summary>
        /// Gets the index of the notification that is next in line and returns it to BeginNotificationQueue
        /// </summary>
        private static int GetNextNotificationIndex()
        {
            for (int i = 0; i < notificationQueue.Count; i++)
            {
                if (Notification.OpenNotifications.FindIndex(element => element == notificationQueue[i]) == -1)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Plays the notification sound
        /// </summary>
        private static void PlayNotificationSound()
        {
            if (!playSounds)
                return;

            using (var player = new System.Media.SoundPlayer(Properties.Resources.sonata))
            {
                player.Play();
            }
        }
    }

    #endregion Notifications
}

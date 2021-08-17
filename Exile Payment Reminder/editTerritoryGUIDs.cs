using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Exile_Payment_Reminder
{
    public partial class editTerritoryGUIDs : MetroFramework.Forms.MetroForm
    {
        public List<string> GUIDs = new List<string>();

        public editTerritoryGUIDs()
        {
            InitializeComponent();
        }

        private void editTerritoryGUIDs_Load(object sender, EventArgs e)
        {
            foreach (string guid in GUIDs)
                listGUIDs.Items.Add(guid);
        }

        private void btnNewGUID_Click(object sender, EventArgs e)
        {
            if (GUIDs.Count > 9)
                return;

            InputBox input = new InputBox();
            input.Text = "Please enter the new GUID";
            input.txtInputText.MaxLength = 17;
            input.textBoxInputMaxLength = 17;
            if (input.ShowDialog() == DialogResult.OK)
            {
                string GUID = input.returnInput;

                string GUIDProfileName = string.Empty;

                if (frmMain.UserSteamAPIKey != null && frmMain.UserSteamAPIKey != string.Empty)
                {
                    string personaname = GetSteamProfileName(GUID);

                    if (personaname == null || personaname == string.Empty)
                    {
                        GUIDProfileName = GUID + " ()";
                        GUIDs.Add(GUIDProfileName);
                        listGUIDs.Items.Add(GUIDProfileName);
                        return;
                    }

                    GUIDProfileName = GUID + " (" + personaname + ")";
                }
                else
                    GUIDProfileName = GUID + " ()";

                if (GUID.Length != 17)
                {
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: "GUID/SteamID64 is not a valid 17 digit number.");
                    return;
                }
                GUIDs.Add(GUIDProfileName);
                listGUIDs.Items.Add(GUIDProfileName);
            }
        }

        public static string GetSteamProfileName(string GUID)
        {
            try
            {
                string devAPIKey = frmMain.UserSteamAPIKey;

                if (devAPIKey == string.Empty)
                    return string.Empty;

                string data = WebRequests.createWebRequest("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=" + devAPIKey + "&steamids=" + GUID + "&format=xml");

                if (data != null && data != string.Empty)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(data);

                    var personaname = doc.GetElementsByTagName("personaname");

                    if (personaname == null || personaname.Count == 0)
                    {
                        frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: "Could not retrieve profile name of GUID '" + GUID + "'");
                        return string.Empty;
                    }
                    else return personaname[0].InnerText;
                }
            }
            catch (Exception ex)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: ex.Message);
            }

            return string.Empty;
        }

        private void btnRemoveGUID_Click(object sender, EventArgs e)
        {
            if (listGUIDs.SelectedItems.Count < 1)
                return;

            if (listGUIDs.Items[0].Selected)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: "Cannot remove owner GUID from list!");
            }
            else
            {
                foreach(ListViewItem item in listGUIDs.SelectedItems)
                {
                    int listIndex = GUIDs.FindIndex(element => element == item.Text);

                    if (listIndex < 0)
                    {
                        item.Remove();
                        continue;
                    }

                    item.Remove();
                    GUIDs.RemoveAt(listIndex);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listGUIDs.SelectedItems.Count < 1)
                return;

            string str = string.Empty;

            foreach (ListViewItem item in listGUIDs.SelectedItems)
                str += item.Text + "|";

            Clipboard.SetText(str);
        }
    }
}

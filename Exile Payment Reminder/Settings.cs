using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exile_Payment_Reminder
{
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        public string savedXmlPath;
        public string defaultGUIDOwner;
        public string steamAPIKey;
        public int maxNotifications;
        public bool playSounds;
        public bool askToClose;
        public bool autoSave;
        public bool suppressErrors;

        public Settings(string _savedXmlPath = null, string _defaultGUIDOwner = null, string _APIKey = null, int? _maxNotifications = null, bool? _playSounds = null, bool? _askToClose = null, bool? _autoSave = null, bool? _suppressErrors = null)
        {
            InitializeComponent();

            comboDefaultOwnerGUID.SelectedIndex = 0;

            List<string> GUIDs = new List<string>();
            foreach(Territory territory in frmMain.listTerritories)
            {
                foreach(string GUID in territory.BuildRightOwners)
                {
                    if (!GUIDs.Exists(element => element == GUID))
                        GUIDs.Add(GUID);
                }
            }

            foreach(string GUID in GUIDs)
                comboDefaultOwnerGUID.Items.Add(GUID);

            savedXmlPath = _savedXmlPath != null ? _savedXmlPath : XML.savedXmlFile;
            defaultGUIDOwner = _defaultGUIDOwner != null ? _defaultGUIDOwner : string.Empty;
            steamAPIKey = _APIKey != null ? _APIKey : string.Empty;
            maxNotifications = _maxNotifications.HasValue ? _maxNotifications.Value : 4;
            playSounds = _playSounds.HasValue ? _playSounds.Value : true;
            askToClose = _askToClose.HasValue ? _askToClose.Value : true;
            autoSave = _autoSave.HasValue ? _autoSave.Value : true;
            suppressErrors = _suppressErrors.HasValue ? _suppressErrors.Value : false;

            comboDefaultOwnerGUID.SelectedIndex = defaultGUIDOwner != string.Empty ? comboDefaultOwnerGUID.Items.IndexOf(defaultGUIDOwner) : 0;
            txtXMLLocation.Text = savedXmlPath;
            txtSteamAPIKey.Text = steamAPIKey;
            lblTrack.Text = maxNotifications.ToString();
            trackNotificationsCount.Value = maxNotifications;
            checkPlaySounds.Checked = playSounds;
            checkAskToClose.Checked = askToClose;
            checkAutoSave.Checked = autoSave;
            checkSuppressErrors.Checked = suppressErrors;
        }

        private void onScroll(object sender, ScrollEventArgs e)
        {
            lblTrack.Text = e.NewValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(txtXMLLocation.Text) == ".xml")
            {
                savedXmlPath = txtXMLLocation.Text;
                defaultGUIDOwner = comboDefaultOwnerGUID.SelectedIndex > 0 ? comboDefaultOwnerGUID.SelectedItem.ToString() : string.Empty;
                steamAPIKey = txtSteamAPIKey.Text != string.Empty ? txtSteamAPIKey.Text : string.Empty;
                maxNotifications = trackNotificationsCount.Value;
                playSounds = checkPlaySounds.Checked;
                askToClose = checkAskToClose.Checked;
                autoSave = checkAutoSave.Checked;
                suppressErrors = checkSuppressErrors.Checked;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: "You did not provide a valid XML path.");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void linkAPIKeyInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your steam API key is what allows this program to make calls to the steam API to automatically grab profile names of GUIDs that you enter, which allows you to easily define who has access to your territory. Please visit http://steamcommunity.com/dev/apikey to get yours and get more information.", "Steam API Key", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChangeXMLLocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog newSaveLocation = new SaveFileDialog();
            newSaveLocation.Title = "Please choose where you want to save your XML...";
            newSaveLocation.ValidateNames = true;
            newSaveLocation.DefaultExt = ".xml";
            //newSaveLocation.InitialDirectory = savedXmlPath;
            newSaveLocation.Filter = "XML files(*.xml) | *.xml";

            if (newSaveLocation.ShowDialog() == DialogResult.OK)
                txtXMLLocation.Text = newSaveLocation.FileName;
        }

        private void linkDefaultOwnerGUID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is optional. This allows you to easily set a default owner for new territories based on current GUIDs without having to copy and paste it in each time.", "Default GUID", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkSavedXMLPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is where your XML is being saved to. The XML file contains all the data that Exile Territory Management needs to read servers/territories and their information accordingly. You can set this to any location you'd like.", "XML Location", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

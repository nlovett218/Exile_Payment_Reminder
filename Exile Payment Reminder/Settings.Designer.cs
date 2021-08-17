namespace Exile_Payment_Reminder
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblSteamAPIKey = new MetroFramework.Controls.MetroLabel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.checkSuppressErrors = new MetroFramework.Controls.MetroCheckBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.comboDefaultOwnerGUID = new MetroFramework.Controls.MetroComboBox();
            this.linkSavedXMLPath = new MetroFramework.Controls.MetroLink();
            this.linkDefaultOwnerGUID = new MetroFramework.Controls.MetroLink();
            this.lblDefaultTerritoryOwner = new MetroFramework.Controls.MetroLabel();
            this.linkAPIKeyInfo = new MetroFramework.Controls.MetroLink();
            this.btnChangeXMLLocation = new MetroFramework.Controls.MetroButton();
            this.txtSteamAPIKey = new MetroFramework.Controls.MetroTextBox();
            this.lblSavedXMLPath = new MetroFramework.Controls.MetroLabel();
            this.lblTrack = new MetroFramework.Controls.MetroLabel();
            this.checkAskToClose = new MetroFramework.Controls.MetroCheckBox();
            this.lblNotificationsToDisplay = new MetroFramework.Controls.MetroLabel();
            this.trackNotificationsCount = new MetroFramework.Controls.MetroTrackBar();
            this.checkPlaySounds = new MetroFramework.Controls.MetroCheckBox();
            this.txtXMLLocation = new MetroFramework.Controls.MetroTextBox();
            this.checkAutoSave = new MetroFramework.Controls.MetroCheckBox();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSteamAPIKey
            // 
            this.lblSteamAPIKey.AutoSize = true;
            this.lblSteamAPIKey.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSteamAPIKey.Location = new System.Drawing.Point(11, 154);
            this.lblSteamAPIKey.Name = "lblSteamAPIKey";
            this.lblSteamAPIKey.Size = new System.Drawing.Size(205, 25);
            this.lblSteamAPIKey.Style = MetroFramework.MetroColorStyle.Red;
            this.lblSteamAPIKey.TabIndex = 0;
            this.lblSteamAPIKey.Text = "Steam API Key (Optional):";
            this.lblSteamAPIKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.checkAutoSave);
            this.panelControls.Controls.Add(this.btnCancel);
            this.panelControls.Controls.Add(this.checkSuppressErrors);
            this.panelControls.Controls.Add(this.btnSave);
            this.panelControls.Controls.Add(this.comboDefaultOwnerGUID);
            this.panelControls.Controls.Add(this.linkSavedXMLPath);
            this.panelControls.Controls.Add(this.linkDefaultOwnerGUID);
            this.panelControls.Controls.Add(this.lblDefaultTerritoryOwner);
            this.panelControls.Controls.Add(this.linkAPIKeyInfo);
            this.panelControls.Controls.Add(this.btnChangeXMLLocation);
            this.panelControls.Controls.Add(this.txtSteamAPIKey);
            this.panelControls.Controls.Add(this.lblSavedXMLPath);
            this.panelControls.Controls.Add(this.lblTrack);
            this.panelControls.Controls.Add(this.checkAskToClose);
            this.panelControls.Controls.Add(this.lblNotificationsToDisplay);
            this.panelControls.Controls.Add(this.trackNotificationsCount);
            this.panelControls.Controls.Add(this.checkPlaySounds);
            this.panelControls.Controls.Add(this.txtXMLLocation);
            this.panelControls.Controls.Add(this.lblSteamAPIKey);
            this.panelControls.Location = new System.Drawing.Point(24, 63);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(592, 387);
            this.panelControls.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.Location = new System.Drawing.Point(397, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 38);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkSuppressErrors
            // 
            this.checkSuppressErrors.AutoSize = true;
            this.checkSuppressErrors.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkSuppressErrors.Location = new System.Drawing.Point(16, 354);
            this.checkSuppressErrors.Name = "checkSuppressErrors";
            this.checkSuppressErrors.Size = new System.Drawing.Size(126, 19);
            this.checkSuppressErrors.Style = MetroFramework.MetroColorStyle.Red;
            this.checkSuppressErrors.TabIndex = 16;
            this.checkSuppressErrors.Text = "Suppress Errors?";
            this.checkSuppressErrors.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkSuppressErrors.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(397, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 38);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save and Close";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboDefaultOwnerGUID
            // 
            this.comboDefaultOwnerGUID.FormattingEnabled = true;
            this.comboDefaultOwnerGUID.ItemHeight = 23;
            this.comboDefaultOwnerGUID.Items.AddRange(new object[] {
            "None"});
            this.comboDefaultOwnerGUID.Location = new System.Drawing.Point(16, 115);
            this.comboDefaultOwnerGUID.MaxDropDownItems = 12;
            this.comboDefaultOwnerGUID.Name = "comboDefaultOwnerGUID";
            this.comboDefaultOwnerGUID.Size = new System.Drawing.Size(396, 29);
            this.comboDefaultOwnerGUID.Style = MetroFramework.MetroColorStyle.Red;
            this.comboDefaultOwnerGUID.TabIndex = 3;
            this.comboDefaultOwnerGUID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboDefaultOwnerGUID.UseSelectable = true;
            // 
            // linkSavedXMLPath
            // 
            this.linkSavedXMLPath.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkSavedXMLPath.Location = new System.Drawing.Point(145, 17);
            this.linkSavedXMLPath.Name = "linkSavedXMLPath";
            this.linkSavedXMLPath.Size = new System.Drawing.Size(84, 23);
            this.linkSavedXMLPath.Style = MetroFramework.MetroColorStyle.Red;
            this.linkSavedXMLPath.TabIndex = 14;
            this.linkSavedXMLPath.Text = "What is this?";
            this.linkSavedXMLPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkSavedXMLPath.UseSelectable = true;
            this.linkSavedXMLPath.Click += new System.EventHandler(this.linkSavedXMLPath_Click);
            // 
            // linkDefaultOwnerGUID
            // 
            this.linkDefaultOwnerGUID.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkDefaultOwnerGUID.Location = new System.Drawing.Point(328, 89);
            this.linkDefaultOwnerGUID.Name = "linkDefaultOwnerGUID";
            this.linkDefaultOwnerGUID.Size = new System.Drawing.Size(84, 23);
            this.linkDefaultOwnerGUID.Style = MetroFramework.MetroColorStyle.Red;
            this.linkDefaultOwnerGUID.TabIndex = 13;
            this.linkDefaultOwnerGUID.Text = "What is this?";
            this.linkDefaultOwnerGUID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkDefaultOwnerGUID.UseSelectable = true;
            this.linkDefaultOwnerGUID.Click += new System.EventHandler(this.linkDefaultOwnerGUID_Click);
            // 
            // lblDefaultTerritoryOwner
            // 
            this.lblDefaultTerritoryOwner.AutoSize = true;
            this.lblDefaultTerritoryOwner.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDefaultTerritoryOwner.Location = new System.Drawing.Point(12, 87);
            this.lblDefaultTerritoryOwner.Name = "lblDefaultTerritoryOwner";
            this.lblDefaultTerritoryOwner.Size = new System.Drawing.Size(320, 25);
            this.lblDefaultTerritoryOwner.Style = MetroFramework.MetroColorStyle.Red;
            this.lblDefaultTerritoryOwner.TabIndex = 11;
            this.lblDefaultTerritoryOwner.Text = "Default Territory Owner GUID (Optional):";
            this.lblDefaultTerritoryOwner.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // linkAPIKeyInfo
            // 
            this.linkAPIKeyInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkAPIKeyInfo.Location = new System.Drawing.Point(210, 157);
            this.linkAPIKeyInfo.Name = "linkAPIKeyInfo";
            this.linkAPIKeyInfo.Size = new System.Drawing.Size(84, 23);
            this.linkAPIKeyInfo.Style = MetroFramework.MetroColorStyle.Red;
            this.linkAPIKeyInfo.TabIndex = 10;
            this.linkAPIKeyInfo.Text = "What is this?";
            this.linkAPIKeyInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkAPIKeyInfo.UseSelectable = true;
            this.linkAPIKeyInfo.Click += new System.EventHandler(this.linkAPIKeyInfo_Click);
            // 
            // btnChangeXMLLocation
            // 
            this.btnChangeXMLLocation.BackgroundImage = global::Exile_Payment_Reminder.Properties.Resources.add;
            this.btnChangeXMLLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChangeXMLLocation.Location = new System.Drawing.Point(535, 43);
            this.btnChangeXMLLocation.Name = "btnChangeXMLLocation";
            this.btnChangeXMLLocation.Size = new System.Drawing.Size(43, 23);
            this.btnChangeXMLLocation.Style = MetroFramework.MetroColorStyle.Red;
            this.btnChangeXMLLocation.TabIndex = 2;
            this.btnChangeXMLLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnChangeXMLLocation.UseSelectable = true;
            this.btnChangeXMLLocation.Click += new System.EventHandler(this.btnChangeXMLLocation_Click);
            // 
            // txtSteamAPIKey
            // 
            // 
            // 
            // 
            this.txtSteamAPIKey.CustomButton.Image = null;
            this.txtSteamAPIKey.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.txtSteamAPIKey.CustomButton.Name = "";
            this.txtSteamAPIKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSteamAPIKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSteamAPIKey.CustomButton.TabIndex = 1;
            this.txtSteamAPIKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSteamAPIKey.CustomButton.UseSelectable = true;
            this.txtSteamAPIKey.CustomButton.Visible = false;
            this.txtSteamAPIKey.Lines = new string[0];
            this.txtSteamAPIKey.Location = new System.Drawing.Point(16, 182);
            this.txtSteamAPIKey.MaxLength = 60;
            this.txtSteamAPIKey.Name = "txtSteamAPIKey";
            this.txtSteamAPIKey.PasswordChar = '\0';
            this.txtSteamAPIKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSteamAPIKey.SelectedText = "";
            this.txtSteamAPIKey.SelectionLength = 0;
            this.txtSteamAPIKey.SelectionStart = 0;
            this.txtSteamAPIKey.ShortcutsEnabled = true;
            this.txtSteamAPIKey.Size = new System.Drawing.Size(396, 23);
            this.txtSteamAPIKey.Style = MetroFramework.MetroColorStyle.Red;
            this.txtSteamAPIKey.TabIndex = 4;
            this.txtSteamAPIKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSteamAPIKey.UseSelectable = true;
            this.txtSteamAPIKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSteamAPIKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSavedXMLPath
            // 
            this.lblSavedXMLPath.AutoSize = true;
            this.lblSavedXMLPath.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSavedXMLPath.Location = new System.Drawing.Point(11, 15);
            this.lblSavedXMLPath.Name = "lblSavedXMLPath";
            this.lblSavedXMLPath.Size = new System.Drawing.Size(138, 25);
            this.lblSavedXMLPath.Style = MetroFramework.MetroColorStyle.Red;
            this.lblSavedXMLPath.TabIndex = 7;
            this.lblSavedXMLPath.Text = "Saved XML Path:";
            this.lblSavedXMLPath.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTrack.Location = new System.Drawing.Point(371, 221);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(21, 25);
            this.lblTrack.Style = MetroFramework.MetroColorStyle.Red;
            this.lblTrack.TabIndex = 6;
            this.lblTrack.Text = "4";
            this.lblTrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // checkAskToClose
            // 
            this.checkAskToClose.AutoSize = true;
            this.checkAskToClose.Checked = true;
            this.checkAskToClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAskToClose.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkAskToClose.Location = new System.Drawing.Point(16, 304);
            this.checkAskToClose.Name = "checkAskToClose";
            this.checkAskToClose.Size = new System.Drawing.Size(191, 19);
            this.checkAskToClose.Style = MetroFramework.MetroColorStyle.Red;
            this.checkAskToClose.TabIndex = 7;
            this.checkAskToClose.Text = "Ask to Close When Exiting?";
            this.checkAskToClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkAskToClose.UseSelectable = true;
            // 
            // lblNotificationsToDisplay
            // 
            this.lblNotificationsToDisplay.AutoSize = true;
            this.lblNotificationsToDisplay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNotificationsToDisplay.Location = new System.Drawing.Point(11, 221);
            this.lblNotificationsToDisplay.Name = "lblNotificationsToDisplay";
            this.lblNotificationsToDisplay.Size = new System.Drawing.Size(364, 25);
            this.lblNotificationsToDisplay.Style = MetroFramework.MetroColorStyle.Red;
            this.lblNotificationsToDisplay.TabIndex = 4;
            this.lblNotificationsToDisplay.Text = "Amount of Notifications To Display On Screen:";
            this.lblNotificationsToDisplay.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // trackNotificationsCount
            // 
            this.trackNotificationsCount.BackColor = System.Drawing.Color.Transparent;
            this.trackNotificationsCount.Location = new System.Drawing.Point(16, 249);
            this.trackNotificationsCount.Maximum = 10;
            this.trackNotificationsCount.Minimum = 1;
            this.trackNotificationsCount.MouseWheelBarPartitions = 2;
            this.trackNotificationsCount.Name = "trackNotificationsCount";
            this.trackNotificationsCount.Size = new System.Drawing.Size(275, 23);
            this.trackNotificationsCount.Style = MetroFramework.MetroColorStyle.Red;
            this.trackNotificationsCount.TabIndex = 5;
            this.trackNotificationsCount.Text = "metroTrackBar1";
            this.trackNotificationsCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.trackNotificationsCount.Value = 4;
            this.trackNotificationsCount.Scroll += new System.Windows.Forms.ScrollEventHandler(this.onScroll);
            // 
            // checkPlaySounds
            // 
            this.checkPlaySounds.AutoSize = true;
            this.checkPlaySounds.Checked = true;
            this.checkPlaySounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPlaySounds.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkPlaySounds.Location = new System.Drawing.Point(16, 279);
            this.checkPlaySounds.Name = "checkPlaySounds";
            this.checkPlaySounds.Size = new System.Drawing.Size(179, 19);
            this.checkPlaySounds.Style = MetroFramework.MetroColorStyle.Red;
            this.checkPlaySounds.TabIndex = 6;
            this.checkPlaySounds.Text = "Play Notification Sounds?";
            this.checkPlaySounds.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkPlaySounds.UseSelectable = true;
            // 
            // txtXMLLocation
            // 
            // 
            // 
            // 
            this.txtXMLLocation.CustomButton.Image = null;
            this.txtXMLLocation.CustomButton.Location = new System.Drawing.Point(491, 1);
            this.txtXMLLocation.CustomButton.Name = "";
            this.txtXMLLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtXMLLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtXMLLocation.CustomButton.TabIndex = 1;
            this.txtXMLLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtXMLLocation.CustomButton.UseSelectable = true;
            this.txtXMLLocation.CustomButton.Visible = false;
            this.txtXMLLocation.Enabled = false;
            this.txtXMLLocation.Lines = new string[0];
            this.txtXMLLocation.Location = new System.Drawing.Point(16, 43);
            this.txtXMLLocation.MaxLength = 500;
            this.txtXMLLocation.Name = "txtXMLLocation";
            this.txtXMLLocation.PasswordChar = '\0';
            this.txtXMLLocation.ReadOnly = true;
            this.txtXMLLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtXMLLocation.SelectedText = "";
            this.txtXMLLocation.SelectionLength = 0;
            this.txtXMLLocation.SelectionStart = 0;
            this.txtXMLLocation.ShortcutsEnabled = true;
            this.txtXMLLocation.Size = new System.Drawing.Size(513, 23);
            this.txtXMLLocation.Style = MetroFramework.MetroColorStyle.Red;
            this.txtXMLLocation.TabIndex = 1;
            this.txtXMLLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtXMLLocation.UseSelectable = true;
            this.txtXMLLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtXMLLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkAutoSave
            // 
            this.checkAutoSave.AutoSize = true;
            this.checkAutoSave.Checked = true;
            this.checkAutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoSave.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkAutoSave.Location = new System.Drawing.Point(16, 329);
            this.checkAutoSave.Name = "checkAutoSave";
            this.checkAutoSave.Size = new System.Drawing.Size(93, 19);
            this.checkAutoSave.Style = MetroFramework.MetroColorStyle.Red;
            this.checkAutoSave.TabIndex = 18;
            this.checkAutoSave.Text = "Auto Save?";
            this.checkAutoSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkAutoSave.UseSelectable = true;
            // 
            // Settings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(639, 473);
            this.Controls.Add(this.panelControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblSteamAPIKey;
        private System.Windows.Forms.Panel panelControls;
        private MetroFramework.Controls.MetroTextBox txtXMLLocation;
        private MetroFramework.Controls.MetroCheckBox checkPlaySounds;
        private MetroFramework.Controls.MetroCheckBox checkAskToClose;
        private MetroFramework.Controls.MetroLabel lblNotificationsToDisplay;
        private MetroFramework.Controls.MetroTrackBar trackNotificationsCount;
        private MetroFramework.Controls.MetroLabel lblTrack;
        private MetroFramework.Controls.MetroTextBox txtSteamAPIKey;
        private MetroFramework.Controls.MetroLabel lblSavedXMLPath;
        private MetroFramework.Controls.MetroButton btnChangeXMLLocation;
        private MetroFramework.Controls.MetroLink linkAPIKeyInfo;
        private MetroFramework.Controls.MetroComboBox comboDefaultOwnerGUID;
        private MetroFramework.Controls.MetroLink linkSavedXMLPath;
        private MetroFramework.Controls.MetroLink linkDefaultOwnerGUID;
        private MetroFramework.Controls.MetroLabel lblDefaultTerritoryOwner;
        private MetroFramework.Controls.MetroCheckBox checkSuppressErrors;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroCheckBox checkAutoSave;
    }
}
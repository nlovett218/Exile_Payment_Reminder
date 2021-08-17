namespace Exile_Payment_Reminder
{
    partial class inputNewTerritory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputNewTerritory));
            this.lblTerritoryName = new MetroFramework.Controls.MetroLabel();
            this.txtNameBox = new MetroFramework.Controls.MetroTextBox();
            this.lblGUID = new MetroFramework.Controls.MetroLabel();
            this.txtGUID = new MetroFramework.Controls.MetroTextBox();
            this.paymentDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.checkReceiveNotifs = new MetroFramework.Controls.MetroCheckBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.comboNotifRate = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lblTerritoryName
            // 
            this.lblTerritoryName.AutoSize = true;
            this.lblTerritoryName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTerritoryName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTerritoryName.Location = new System.Drawing.Point(23, 69);
            this.lblTerritoryName.Name = "lblTerritoryName";
            this.lblTerritoryName.Size = new System.Drawing.Size(72, 25);
            this.lblTerritoryName.TabIndex = 5;
            this.lblTerritoryName.Text = "Name *";
            this.lblTerritoryName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtNameBox
            // 
            // 
            // 
            // 
            this.txtNameBox.CustomButton.Image = null;
            this.txtNameBox.CustomButton.Location = new System.Drawing.Point(507, 1);
            this.txtNameBox.CustomButton.Name = "";
            this.txtNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameBox.CustomButton.TabIndex = 1;
            this.txtNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameBox.CustomButton.UseSelectable = true;
            this.txtNameBox.CustomButton.Visible = false;
            this.txtNameBox.Lines = new string[] {
        "Enter your territory name here..."};
            this.txtNameBox.Location = new System.Drawing.Point(23, 97);
            this.txtNameBox.MaxLength = 40;
            this.txtNameBox.Name = "txtNameBox";
            this.txtNameBox.PasswordChar = '\0';
            this.txtNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameBox.SelectedText = "";
            this.txtNameBox.SelectionLength = 0;
            this.txtNameBox.SelectionStart = 0;
            this.txtNameBox.ShortcutsEnabled = true;
            this.txtNameBox.Size = new System.Drawing.Size(529, 23);
            this.txtNameBox.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNameBox.TabIndex = 4;
            this.txtNameBox.Text = "Enter your territory name here...";
            this.txtNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNameBox.UseSelectable = true;
            this.txtNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNameBox.Click += new System.EventHandler(this.txtNameBox_Click);
            // 
            // lblGUID
            // 
            this.lblGUID.AutoSize = true;
            this.lblGUID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGUID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblGUID.Location = new System.Drawing.Point(23, 133);
            this.lblGUID.Name = "lblGUID";
            this.lblGUID.Size = new System.Drawing.Size(124, 25);
            this.lblGUID.TabIndex = 7;
            this.lblGUID.Text = "Owner GUID *";
            this.lblGUID.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtGUID
            // 
            // 
            // 
            // 
            this.txtGUID.CustomButton.Image = null;
            this.txtGUID.CustomButton.Location = new System.Drawing.Point(507, 1);
            this.txtGUID.CustomButton.Name = "";
            this.txtGUID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGUID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGUID.CustomButton.TabIndex = 1;
            this.txtGUID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGUID.CustomButton.UseSelectable = true;
            this.txtGUID.CustomButton.Visible = false;
            this.txtGUID.Lines = new string[] {
        "Enter your Steam64/GUID here..."};
            this.txtGUID.Location = new System.Drawing.Point(23, 161);
            this.txtGUID.MaxLength = 17;
            this.txtGUID.Name = "txtGUID";
            this.txtGUID.PasswordChar = '\0';
            this.txtGUID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGUID.SelectedText = "";
            this.txtGUID.SelectionLength = 0;
            this.txtGUID.SelectionStart = 0;
            this.txtGUID.ShortcutsEnabled = true;
            this.txtGUID.Size = new System.Drawing.Size(529, 23);
            this.txtGUID.Style = MetroFramework.MetroColorStyle.Red;
            this.txtGUID.TabIndex = 6;
            this.txtGUID.Text = "Enter your Steam64/GUID here...";
            this.txtGUID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtGUID.UseSelectable = true;
            this.txtGUID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGUID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGUID.Click += new System.EventHandler(this.txtGUID_Click);
            // 
            // paymentDateTime
            // 
            this.paymentDateTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.paymentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.paymentDateTime.Location = new System.Drawing.Point(23, 234);
            this.paymentDateTime.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.paymentDateTime.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.paymentDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.paymentDateTime.Name = "paymentDateTime";
            this.paymentDateTime.Size = new System.Drawing.Size(404, 29);
            this.paymentDateTime.Style = MetroFramework.MetroColorStyle.Red;
            this.paymentDateTime.TabIndex = 8;
            this.paymentDateTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.paymentDateTime.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(22, 205);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(417, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Payment Protection Due (MM/dd/yyyy hh:mm:ss) *";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // checkReceiveNotifs
            // 
            this.checkReceiveNotifs.AutoSize = true;
            this.checkReceiveNotifs.Checked = true;
            this.checkReceiveNotifs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkReceiveNotifs.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.checkReceiveNotifs.Location = new System.Drawing.Point(23, 286);
            this.checkReceiveNotifs.Name = "checkReceiveNotifs";
            this.checkReceiveNotifs.Size = new System.Drawing.Size(200, 25);
            this.checkReceiveNotifs.Style = MetroFramework.MetroColorStyle.Red;
            this.checkReceiveNotifs.TabIndex = 10;
            this.checkReceiveNotifs.Text = "Receive Notifications?";
            this.checkReceiveNotifs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkReceiveNotifs.UseSelectable = true;
            this.checkReceiveNotifs.CheckedChanged += new System.EventHandler(this.checkReceiveNotifs_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(433, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 29);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Red;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Save";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(433, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 31);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboNotifRate
            // 
            this.comboNotifRate.FormattingEnabled = true;
            this.comboNotifRate.ItemHeight = 23;
            this.comboNotifRate.Items.AddRange(new object[] {
            "Never",
            "Daily",
            "Day Before Payment"});
            this.comboNotifRate.Location = new System.Drawing.Point(229, 282);
            this.comboNotifRate.Name = "comboNotifRate";
            this.comboNotifRate.Size = new System.Drawing.Size(198, 29);
            this.comboNotifRate.Style = MetroFramework.MetroColorStyle.Red;
            this.comboNotifRate.TabIndex = 13;
            this.comboNotifRate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboNotifRate.UseSelectable = true;
            this.comboNotifRate.SelectedIndexChanged += new System.EventHandler(this.onSelectedIndexChanged);
            // 
            // inputNewTerritory
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(567, 334);
            this.Controls.Add(this.comboNotifRate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkReceiveNotifs);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.paymentDateTime);
            this.Controls.Add(this.lblGUID);
            this.Controls.Add(this.txtGUID);
            this.Controls.Add(this.lblTerritoryName);
            this.Controls.Add(this.txtNameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inputNewTerritory";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Add New Territory";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.inputNewTerritory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTerritoryName;
        private MetroFramework.Controls.MetroTextBox txtNameBox;
        private MetroFramework.Controls.MetroLabel lblGUID;
        private MetroFramework.Controls.MetroTextBox txtGUID;
        private MetroFramework.Controls.MetroDateTime paymentDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox checkReceiveNotifs;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroComboBox comboNotifRate;
    }
}
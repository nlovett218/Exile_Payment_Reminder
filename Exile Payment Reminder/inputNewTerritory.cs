using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exile_Payment_Reminder
{
    public partial class inputNewTerritory : MetroFramework.Forms.MetroForm
    {
        public string TerritoryName;
        public string GUID;
        public DateTime paymentDate;
        public bool receiveNotifs;
        public string receiveNotifsRate;
        public bool editing = false;
        public int receiveNotificationsID;

        public string savedOwnerGUID = string.Empty;

        private static string defaultnametext = string.Empty;
        private static string defaultguidtext = string.Empty;

        public inputNewTerritory(string _TerritoryName = null, string _Owner = null, DateTime? _PaymentDate = null, int? _notificationID = null, bool? _isEditing = null)
        {
            InitializeComponent();

            if (_isEditing != null && _isEditing.HasValue)
                editing = _isEditing.Value;

            if (_Owner != null && _Owner != string.Empty)
                GUID = _Owner;

            if (GUID != null && GUID != string.Empty)
                txtGUID.Text = GUID.Substring(0, 17);

            if (editing)
            {
                this.Text = "Edit Territory";

                if (_TerritoryName != null && _TerritoryName != string.Empty)
                    TerritoryName = _TerritoryName;

                if (_Owner != null && _Owner != string.Empty)
                    GUID = _Owner;

                if (_PaymentDate != null && _PaymentDate.HasValue)
                    paymentDate = _PaymentDate.Value;

                if (_notificationID != null && _notificationID.HasValue)
                {
                    receiveNotifs = _notificationID.Value > 0 ? true : false;
                    if (_notificationID.Value == 0)
                    {
                        receiveNotifsRate = "never";
                        checkReceiveNotifs.Checked = false;
                        comboNotifRate.Enabled = false;
                    }

                    if (receiveNotifs)
                    {
                        comboNotifRate.SelectedIndex = (int)_notificationID;
                        checkReceiveNotifs.Checked = true;
                        comboNotifRate.Enabled = true;
                    }
                }

                txtNameBox.Text = TerritoryName;
                txtGUID.Text = GUID;
                paymentDateTime.Value = paymentDate;
            }

            if (editing == false)
            {
                paymentDateTime.Value = DateTime.Now;
                comboNotifRate.SelectedIndex = 1;
                checkReceiveNotifs.Checked = true;
            }

            defaultnametext = txtNameBox.Text;
            defaultguidtext = txtGUID.Text;

        }

        private void inputNewTerritory_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNameBox.Text.Trim().Length < 1 || txtNameBox.Text.Trim() == "")
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error!", body: "Your Territory is invalid! Please enter a valid territory name.");
                return;
            }

            if (txtGUID.Text.Length != 17)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error!", body: "Your GUID is invalid! Please enter a valid 17 digit SteamID64/GUID.");
                return;
            }

            TerritoryName = txtNameBox.Text;
            GUID = txtGUID.Text;
            paymentDate = paymentDateTime.Value;
            receiveNotifs = checkReceiveNotifs.Checked;
            receiveNotifsRate = comboNotifRate.SelectedItem.ToString();
            receiveNotificationsID = comboNotifRate.SelectedIndex;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkReceiveNotifs_CheckedChanged(object sender, EventArgs e)
        {
            comboNotifRate.Enabled = checkReceiveNotifs.Checked;

            if (checkReceiveNotifs.Checked)
            {
                comboNotifRate.SelectedIndex = 1;
                receiveNotifsRate = comboNotifRate.SelectedText;
            }
            else
            {
                comboNotifRate.SelectedIndex = 0;
                receiveNotifsRate = "Never";
            }
        }

        private void onSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNotifRate.SelectedIndex == 0)
            {
                checkReceiveNotifs.Checked = false;
                comboNotifRate.Enabled = false;
            }
        }

        private void txtNameBox_Click(object sender, EventArgs e)
        {
            if (!editing && txtNameBox.Text == defaultnametext)
                txtNameBox.Text = string.Empty;
        }

        private void txtGUID_Click(object sender, EventArgs e)
        {
            if (GUID != null && GUID != string.Empty)
                return;

            if (!editing && txtGUID.Text == defaultguidtext)
                txtGUID.Text = string.Empty;
        }
    }
}

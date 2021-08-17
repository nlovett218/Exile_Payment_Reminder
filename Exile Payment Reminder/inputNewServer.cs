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
    public partial class inputNewServer : MetroFramework.Forms.MetroForm
    {
        public string ServerName;
        public string IPAddress;
        public bool AutoGrabName;
        public bool editing = false;

        private string defaultnametext;
        private string defaultiptext;

        public inputNewServer(string _ServerName = null, string _IPAddress = null, bool? _AutoGrabName = null, bool? _isEditing = null)
        {
            InitializeComponent();

            if (_ServerName != null)
                ServerName = _ServerName;
            if (_IPAddress != null)
                IPAddress = _IPAddress;
            if (_AutoGrabName != null)
                AutoGrabName = _AutoGrabName.Value;
            if (_isEditing != null)
                editing = _isEditing.Value;

            if (editing)
                this.Text = "Edit Server";

            if (ServerName != null && ServerName != string.Empty)
                txtNameBox.Text = ServerName;

            if (IPAddress != null && IPAddress != string.Empty)
                txtIPBox.Text = IPAddress;

            if (AutoGrabName.ToString() != null)
                checkGrabServerName.Checked = AutoGrabName;

            defaultnametext = txtNameBox.Text;
            defaultiptext = txtIPBox.Text;
        }

        private void SubmitForm(object sender, EventArgs e)
        {
            string txtServerName = txtNameBox.Text;
            bool bValid = true;

            if (!checkGrabServerName.Checked)
            {
                if (NameExists(txtServerName) && !editing)
                {
                    frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error!", body: "This server name already exists!");
                    bValid = false;
                    return;
                }

                switch (txtServerName.ToLower())
                {
                    case "enter your server name here...":
                        frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error!", body: "Please enter a valid name for your server!");
                        bValid = false;
                        break;
                    case "":
                        frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error!", body: "Please enter a valid name for your server!");
                        bValid = false;
                        break;
                    case null:
                        frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error!", body: "Please enter a valid name for your server!");
                        bValid = false;
                        break;
                    default:
                        bValid = true;
                        break;

                }
            }

            if (bValid)
            {
                ServerName = txtNameBox.Text;
                IPAddress = txtIPBox.Text;

                switch(IPAddress.ToLower())
                {
                    case "enter your server ip here...":
                        IPAddress = string.Empty;
                        break;
                    case "":
                        IPAddress = string.Empty;
                        break;
                    case " ":
                        IPAddress = string.Empty;
                        break;
                    case null:
                        IPAddress = string.Empty;
                        break;
                }

                AutoGrabName = checkGrabServerName.Checked;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelForm(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool NameExists(string str)
        {
            List<string> AllServerNames = frmMain.GrabServerNames();

            foreach(string _ServerName in AllServerNames)
            {
                if (_ServerName == str)
                    return true;
            }

            return false;
        }

        private void txtNameBox_Click(object sender, EventArgs e)
        {
            if (!editing && txtNameBox.Text == defaultnametext)
                txtNameBox.Text = string.Empty;
        }

        private void txtIPBox_Click(object sender, EventArgs e)
        {
            if (!editing && txtIPBox.Text == defaultiptext)
                txtIPBox.Text = string.Empty;
        }
    }
}

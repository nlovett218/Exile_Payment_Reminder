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
    public partial class notificationLog : MetroFramework.Forms.MetroForm
    {
        public notificationLog()
        {
            InitializeComponent();
        }

        private void notificationLog_Load(object sender, EventArgs e)
        {
            txtLogs.Lines = frmMainNotifications.notificationLogs.ToArray();
        }
    }
}

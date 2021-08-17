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
    public partial class editTerritoryPaymentDate : MetroFramework.Forms.MetroForm
    {
        public DateTime newPaymentDate;

        public editTerritoryPaymentDate(DateTime? date = null)
        {
            InitializeComponent();

            if (date.HasValue)
            {
                newPaymentDate = date.Value;
                dateTimePicker.Value = date.Value;
            }
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            if (now > dateTimePicker.Value)
            {
                frmMainNotifications.ShowNotification(methodname: System.Reflection.MethodBase.GetCurrentMethod().Name, isError: true, title: "Error", body: "Not a valid payment date.");
                return;
            }

            newPaymentDate = dateTimePicker.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

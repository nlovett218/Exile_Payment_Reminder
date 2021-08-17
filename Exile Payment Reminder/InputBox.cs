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
    public partial class InputBox : MetroFramework.Forms.MetroForm
    {
        public string returnInput = string.Empty;
        public int textBoxInputMaxLength;

        public InputBox()
        {
            InitializeComponent();
            txtInputText.MaxLength = textBoxInputMaxLength;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            returnInput = txtInputText.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

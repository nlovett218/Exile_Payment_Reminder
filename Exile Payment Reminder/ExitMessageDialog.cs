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
    public partial class ExitMessageDialog : MetroFramework.Forms.MetroForm
    {
        public bool AskToCloseAgain = true;

        public ExitMessageDialog()
        {
            InitializeComponent();
        }

        private void btnYesExit_Click(object sender, EventArgs e)
        {
            AskToCloseAgain = !checkDontAskAgain.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNoExit_Click(object sender, EventArgs e)
        {
            AskToCloseAgain = !checkDontAskAgain.Checked;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

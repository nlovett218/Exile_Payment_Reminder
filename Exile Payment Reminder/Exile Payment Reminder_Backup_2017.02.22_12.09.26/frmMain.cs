using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ToastNotifications;

namespace Exile_Payment_Reminder
{
    public partial class frmMain : Form
    {
        private List<Server> listServers = new List<Server>();
        private List<Territory> listTerritories = new List<Territory>();
        private int selectedServerID = 0;
        private int selectedTerritoryID = 0;

        private bool allowVisible;     // ContextMenu's Show command used
        private bool allowClose;       // ContextMenu's Exit command used

        public frmMain()
        {

            InitializeComponent();
            this.restoreMainWindowContextItem.Click += showToolStripMenuItem_Click;
            this.closeExilePaymentReminderContextItem.Click += exitToolStripMenuItem_Click;

            ShowAllPaymentReminders();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                this.Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowVisible = true;
            Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowClose = true;
            Application.Exit();
        }

        public void ShowAllPaymentReminders()
        {
            frmMainNotifications.ShowNotification("BFC Exile Esseker #1", "Your territory payment for 'Bi-Polar Bears' is due tomorrow!");
            frmMainNotifications.ShowNotification("BFC Exile Esseker #2", "Your territory payment for 'Ich Bin Fabelhaft!' is due tomorrow!");
            frmMainNotifications.ShowNotification("BFC Exile Al Rayak", "Your territory payment for 'WGL and Others' is due tomorrow!");
        }

        public void UpdateTerritoryName(string id)
        {

        }

        public void UpdateServerName(string id)
        {

        }

        public List<int> GrabServerIDs()
        {
            return null;
        }

        public List<int> GrabTerritoryIDs()
        {
            return null;
        }

        private void showMainForm(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
        }
    }

    public class Server
    {
        Server(int id, string Name, string ip = null, Territory newTerritory = null)
        {

        }
    }

    public class Territory
    {
        Territory(int id, string Name, DateTime paymentDate, int receiveNotificationsID, List<string> buildRightOwners = null)
        {

        }
    }

    public static class frmMainNotifications
    {
        public static void ShowNotification(string title, string body)
        {
            int duration = 15;

            var animationMethod = FormAnimator.AnimationMethod.Slide;

            var animationDirection = FormAnimator.AnimationDirection.Up;

            var toastNotification = new Notification(title, body, duration, animationMethod, animationDirection);

            PlayNotificationSound();
            toastNotification.Show();
        }

        private static void PlayNotificationSound()
        {
            using (var player = new System.Media.SoundPlayer(Properties.Resources.sonata))
            {
                player.Play();
            }
        }
    }
}

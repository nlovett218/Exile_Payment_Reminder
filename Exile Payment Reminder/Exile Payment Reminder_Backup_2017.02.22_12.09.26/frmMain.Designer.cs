namespace Exile_Payment_Reminder
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ExilePaymentTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restorePaymentNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreMainWindowContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeExilePaymentReminderContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.notifyTrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExilePaymentTrayIcon
            // 
            this.ExilePaymentTrayIcon.ContextMenuStrip = this.notifyTrayContextMenu;
            this.ExilePaymentTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ExilePaymentTrayIcon.Icon")));
            this.ExilePaymentTrayIcon.Text = "Exile Payment Reminder";
            this.ExilePaymentTrayIcon.Visible = true;
            this.ExilePaymentTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.showMainForm);
            // 
            // notifyTrayContextMenu
            // 
            this.notifyTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restorePaymentNotificationsToolStripMenuItem,
            this.restoreMainWindowContextItem,
            this.closeExilePaymentReminderContextItem});
            this.notifyTrayContextMenu.Name = "notifyTrayContextMenu";
            this.notifyTrayContextMenu.Size = new System.Drawing.Size(235, 70);
            // 
            // restorePaymentNotificationsToolStripMenuItem
            // 
            this.restorePaymentNotificationsToolStripMenuItem.Name = "restorePaymentNotificationsToolStripMenuItem";
            this.restorePaymentNotificationsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.restorePaymentNotificationsToolStripMenuItem.Text = "Restore Payment Notifications";
            // 
            // restoreMainWindowContextItem
            // 
            this.restoreMainWindowContextItem.Name = "restoreMainWindowContextItem";
            this.restoreMainWindowContextItem.Size = new System.Drawing.Size(234, 22);
            this.restoreMainWindowContextItem.Text = "Restore Main Window";
            // 
            // closeExilePaymentReminderContextItem
            // 
            this.closeExilePaymentReminderContextItem.Name = "closeExilePaymentReminderContextItem";
            this.closeExilePaymentReminderContextItem.Size = new System.Drawing.Size(234, 22);
            this.closeExilePaymentReminderContextItem.Text = "Close Exile Payment Reminder";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 496);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Exile Territory Management";
            this.notifyTrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ExilePaymentTrayIcon;
        private System.Windows.Forms.ContextMenuStrip notifyTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem restorePaymentNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreMainWindowContextItem;
        private System.Windows.Forms.ToolStripMenuItem closeExilePaymentReminderContextItem;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
    }
}


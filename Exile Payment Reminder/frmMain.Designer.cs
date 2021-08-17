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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Servers and Territories");
            this.ExilePaymentTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dismissAllNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restorePaymentNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreMainWindowContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeExilePaymentReminderContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mainTree = new System.Windows.Forms.TreeView();
            this.treeViewContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addNewServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTerritoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.picDivider_1 = new System.Windows.Forms.PictureBox();
            this.btnMadePayment = new MetroFramework.Controls.MetroButton();
            this.checkReceiveNotifs = new MetroFramework.Controls.MetroCheckBox();
            this.lblPanelReceiveNotifs = new MetroFramework.Controls.MetroLabel();
            this.btnEditBuildRightsOwners = new MetroFramework.Controls.MetroButton();
            this.lblPanelTerritoryPaymentDue = new MetroFramework.Controls.MetroLabel();
            this.lblPanelTerritoryName = new MetroFramework.Controls.MetroLabel();
            this.lblPanelServerPlayersOnline = new MetroFramework.Controls.MetroLabel();
            this.lblPanelServerStatus = new MetroFramework.Controls.MetroLabel();
            this.lblPanelServerIP = new MetroFramework.Controls.MetroLabel();
            this.lblPanelInfo = new MetroFramework.Controls.MetroLabel();
            this.picExileLogoAboutMe = new System.Windows.Forms.PictureBox();
            this.exileMainMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.loadXMLFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readAboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitBFCForumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNotificationLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipExileLogo = new System.Windows.Forms.ToolTip(this.components);
            this.lblUnsavedChanges = new MetroFramework.Controls.MetroLabel();
            this.viewCreditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyTrayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.treeViewContextMenu.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDivider_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExileLogoAboutMe)).BeginInit();
            this.exileMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExilePaymentTrayIcon
            // 
            this.ExilePaymentTrayIcon.ContextMenuStrip = this.notifyTrayContextMenu;
            this.ExilePaymentTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ExilePaymentTrayIcon.Icon")));
            this.ExilePaymentTrayIcon.Text = "Exile Territory Management";
            this.ExilePaymentTrayIcon.Visible = true;
            this.ExilePaymentTrayIcon.DoubleClick += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            this.ExilePaymentTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowMainForm);
            // 
            // notifyTrayContextMenu
            // 
            this.notifyTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dismissAllNotificationsToolStripMenuItem,
            this.restorePaymentNotificationsToolStripMenuItem,
            this.restoreMainWindowContextItem,
            this.closeExilePaymentReminderContextItem});
            this.notifyTrayContextMenu.Name = "notifyTrayContextMenu";
            this.notifyTrayContextMenu.Size = new System.Drawing.Size(235, 92);
            // 
            // dismissAllNotificationsToolStripMenuItem
            // 
            this.dismissAllNotificationsToolStripMenuItem.Name = "dismissAllNotificationsToolStripMenuItem";
            this.dismissAllNotificationsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.dismissAllNotificationsToolStripMenuItem.Text = "Dismiss All Notifications";
            this.dismissAllNotificationsToolStripMenuItem.Click += new System.EventHandler(this.dismissAllNotificationsToolStripMenuItem_Click);
            // 
            // restorePaymentNotificationsToolStripMenuItem
            // 
            this.restorePaymentNotificationsToolStripMenuItem.Name = "restorePaymentNotificationsToolStripMenuItem";
            this.restorePaymentNotificationsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.restorePaymentNotificationsToolStripMenuItem.Text = "Restore Payment Notifications";
            this.restorePaymentNotificationsToolStripMenuItem.Click += new System.EventHandler(this.restorePaymentNotificationsToolStripMenuItem_Click);
            // 
            // restoreMainWindowContextItem
            // 
            this.restoreMainWindowContextItem.Name = "restoreMainWindowContextItem";
            this.restoreMainWindowContextItem.Size = new System.Drawing.Size(234, 22);
            this.restoreMainWindowContextItem.Text = "Restore Main Window";
            this.restoreMainWindowContextItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // closeExilePaymentReminderContextItem
            // 
            this.closeExilePaymentReminderContextItem.Name = "closeExilePaymentReminderContextItem";
            this.closeExilePaymentReminderContextItem.Size = new System.Drawing.Size(234, 22);
            this.closeExilePaymentReminderContextItem.Text = "Close Exile Payment Reminder";
            this.closeExilePaymentReminderContextItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mainTree
            // 
            this.mainTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mainTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTree.ContextMenuStrip = this.treeViewContextMenu;
            this.mainTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTree.ForeColor = System.Drawing.Color.Red;
            this.mainTree.LineColor = System.Drawing.Color.White;
            this.mainTree.Location = new System.Drawing.Point(23, 63);
            this.mainTree.Name = "mainTree";
            treeNode1.Name = "rootServers";
            treeNode1.Text = "Servers and Territories";
            this.mainTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.mainTree.Size = new System.Drawing.Size(576, 462);
            this.mainTree.TabIndex = 1;
            this.mainTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewSelectionChanged);
            this.mainTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.onTreeNodeDoubleClick);
            this.mainTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_onKeyDown);
            // 
            // treeViewContextMenu
            // 
            this.treeViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewServerToolStripMenuItem,
            this.addNewTerritoryToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeSelectedToolStripMenuItem,
            this.saveListToolStripMenuItem});
            this.treeViewContextMenu.Name = "metroContextMenu1";
            this.treeViewContextMenu.Size = new System.Drawing.Size(172, 114);
            this.treeViewContextMenu.Style = MetroFramework.MetroColorStyle.Red;
            this.treeViewContextMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.treeViewContextMenu.UseCustomBackColor = true;
            this.treeViewContextMenu.UseCustomForeColor = true;
            this.treeViewContextMenu.UseStyleColors = true;
            // 
            // addNewServerToolStripMenuItem
            // 
            this.addNewServerToolStripMenuItem.Name = "addNewServerToolStripMenuItem";
            this.addNewServerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewServerToolStripMenuItem.Text = "Add New Server";
            this.addNewServerToolStripMenuItem.Click += new System.EventHandler(this.AddNewServer);
            // 
            // addNewTerritoryToolStripMenuItem
            // 
            this.addNewTerritoryToolStripMenuItem.Name = "addNewTerritoryToolStripMenuItem";
            this.addNewTerritoryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addNewTerritoryToolStripMenuItem.Text = "Add New Territory";
            this.addNewTerritoryToolStripMenuItem.Click += new System.EventHandler(this.addNewTerritoryToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editToolStripMenuItem.Text = "Edit Selected";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.onEditSelectedClick);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.onRemoveSelectedMenuItemClick);
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveListToolStripMenuItem.Text = "Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.onSaveListMenuClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 532);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(858, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Double click or right click on a server/territory to edit it! You can also access" +
    " more options by right clicking on the Exile logo in the top left corner.";
            this.lblStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblStatus.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.picDivider_1);
            this.metroPanel1.Controls.Add(this.btnMadePayment);
            this.metroPanel1.Controls.Add(this.checkReceiveNotifs);
            this.metroPanel1.Controls.Add(this.lblPanelReceiveNotifs);
            this.metroPanel1.Controls.Add(this.btnEditBuildRightsOwners);
            this.metroPanel1.Controls.Add(this.lblPanelTerritoryPaymentDue);
            this.metroPanel1.Controls.Add(this.lblPanelTerritoryName);
            this.metroPanel1.Controls.Add(this.lblPanelServerPlayersOnline);
            this.metroPanel1.Controls.Add(this.lblPanelServerStatus);
            this.metroPanel1.Controls.Add(this.lblPanelServerIP);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(606, 89);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(383, 436);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // picDivider_1
            // 
            this.picDivider_1.Image = ((System.Drawing.Image)(resources.GetObject("picDivider_1.Image")));
            this.picDivider_1.Location = new System.Drawing.Point(15, 120);
            this.picDivider_1.Name = "picDivider_1";
            this.picDivider_1.Size = new System.Drawing.Size(355, 50);
            this.picDivider_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDivider_1.TabIndex = 11;
            this.picDivider_1.TabStop = false;
            // 
            // btnMadePayment
            // 
            this.btnMadePayment.BackColor = System.Drawing.Color.Red;
            this.btnMadePayment.Enabled = false;
            this.btnMadePayment.ForeColor = System.Drawing.Color.White;
            this.btnMadePayment.Location = new System.Drawing.Point(15, 393);
            this.btnMadePayment.Name = "btnMadePayment";
            this.btnMadePayment.Size = new System.Drawing.Size(355, 40);
            this.btnMadePayment.TabIndex = 10;
            this.btnMadePayment.Text = "Made Payment on Territory";
            this.btnMadePayment.UseCustomBackColor = true;
            this.btnMadePayment.UseCustomForeColor = true;
            this.btnMadePayment.UseSelectable = true;
            this.btnMadePayment.Click += new System.EventHandler(this.btnMadePayment_Click);
            // 
            // checkReceiveNotifs
            // 
            this.checkReceiveNotifs.AutoSize = true;
            this.checkReceiveNotifs.Enabled = false;
            this.checkReceiveNotifs.Location = new System.Drawing.Point(154, 256);
            this.checkReceiveNotifs.Name = "checkReceiveNotifs";
            this.checkReceiveNotifs.Size = new System.Drawing.Size(26, 15);
            this.checkReceiveNotifs.Style = MetroFramework.MetroColorStyle.Red;
            this.checkReceiveNotifs.TabIndex = 9;
            this.checkReceiveNotifs.Text = " ";
            this.checkReceiveNotifs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkReceiveNotifs.UseSelectable = true;
            // 
            // lblPanelReceiveNotifs
            // 
            this.lblPanelReceiveNotifs.AutoSize = true;
            this.lblPanelReceiveNotifs.Location = new System.Drawing.Point(15, 254);
            this.lblPanelReceiveNotifs.Name = "lblPanelReceiveNotifs";
            this.lblPanelReceiveNotifs.Size = new System.Drawing.Size(135, 19);
            this.lblPanelReceiveNotifs.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPanelReceiveNotifs.TabIndex = 8;
            this.lblPanelReceiveNotifs.Text = "Receive Notifications?";
            this.lblPanelReceiveNotifs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPanelReceiveNotifs.UseCustomForeColor = true;
            // 
            // btnEditBuildRightsOwners
            // 
            this.btnEditBuildRightsOwners.BackColor = System.Drawing.Color.Red;
            this.btnEditBuildRightsOwners.Enabled = false;
            this.btnEditBuildRightsOwners.ForeColor = System.Drawing.Color.White;
            this.btnEditBuildRightsOwners.Location = new System.Drawing.Point(15, 347);
            this.btnEditBuildRightsOwners.Name = "btnEditBuildRightsOwners";
            this.btnEditBuildRightsOwners.Size = new System.Drawing.Size(355, 40);
            this.btnEditBuildRightsOwners.TabIndex = 7;
            this.btnEditBuildRightsOwners.Text = "View/Edit Build Rights Owners";
            this.btnEditBuildRightsOwners.UseCustomBackColor = true;
            this.btnEditBuildRightsOwners.UseCustomForeColor = true;
            this.btnEditBuildRightsOwners.UseSelectable = true;
            this.btnEditBuildRightsOwners.Click += new System.EventHandler(this.btnEditBuildRightsOwners_Click);
            // 
            // lblPanelTerritoryPaymentDue
            // 
            this.lblPanelTerritoryPaymentDue.AutoSize = true;
            this.lblPanelTerritoryPaymentDue.Location = new System.Drawing.Point(15, 219);
            this.lblPanelTerritoryPaymentDue.Name = "lblPanelTerritoryPaymentDue";
            this.lblPanelTerritoryPaymentDue.Size = new System.Drawing.Size(144, 19);
            this.lblPanelTerritoryPaymentDue.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPanelTerritoryPaymentDue.TabIndex = 6;
            this.lblPanelTerritoryPaymentDue.Text = "Territory Payment Due:";
            this.lblPanelTerritoryPaymentDue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPanelTerritoryPaymentDue.UseCustomForeColor = true;
            // 
            // lblPanelTerritoryName
            // 
            this.lblPanelTerritoryName.AutoSize = true;
            this.lblPanelTerritoryName.Location = new System.Drawing.Point(15, 184);
            this.lblPanelTerritoryName.Name = "lblPanelTerritoryName";
            this.lblPanelTerritoryName.Size = new System.Drawing.Size(102, 19);
            this.lblPanelTerritoryName.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPanelTerritoryName.TabIndex = 5;
            this.lblPanelTerritoryName.Text = "Territory Name:";
            this.lblPanelTerritoryName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPanelTerritoryName.UseCustomForeColor = true;
            // 
            // lblPanelServerPlayersOnline
            // 
            this.lblPanelServerPlayersOnline.AutoSize = true;
            this.lblPanelServerPlayersOnline.Location = new System.Drawing.Point(15, 85);
            this.lblPanelServerPlayersOnline.Name = "lblPanelServerPlayersOnline";
            this.lblPanelServerPlayersOnline.Size = new System.Drawing.Size(118, 19);
            this.lblPanelServerPlayersOnline.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPanelServerPlayersOnline.TabIndex = 4;
            this.lblPanelServerPlayersOnline.Text = "Players Online: 0/0";
            this.lblPanelServerPlayersOnline.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPanelServerPlayersOnline.UseCustomForeColor = true;
            // 
            // lblPanelServerStatus
            // 
            this.lblPanelServerStatus.AutoSize = true;
            this.lblPanelServerStatus.Location = new System.Drawing.Point(15, 50);
            this.lblPanelServerStatus.Name = "lblPanelServerStatus";
            this.lblPanelServerStatus.Size = new System.Drawing.Size(142, 19);
            this.lblPanelServerStatus.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPanelServerStatus.TabIndex = 3;
            this.lblPanelServerStatus.Text = "Server Status: OFFLINE";
            this.lblPanelServerStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPanelServerStatus.UseCustomForeColor = true;
            // 
            // lblPanelServerIP
            // 
            this.lblPanelServerIP.AutoSize = true;
            this.lblPanelServerIP.Location = new System.Drawing.Point(15, 15);
            this.lblPanelServerIP.Name = "lblPanelServerIP";
            this.lblPanelServerIP.Size = new System.Drawing.Size(68, 19);
            this.lblPanelServerIP.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPanelServerIP.TabIndex = 2;
            this.lblPanelServerIP.Text = "Server IP: ";
            this.lblPanelServerIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPanelServerIP.UseCustomForeColor = true;
            // 
            // lblPanelInfo
            // 
            this.lblPanelInfo.AutoSize = true;
            this.lblPanelInfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPanelInfo.Location = new System.Drawing.Point(621, 59);
            this.lblPanelInfo.Name = "lblPanelInfo";
            this.lblPanelInfo.Size = new System.Drawing.Size(163, 25);
            this.lblPanelInfo.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPanelInfo.TabIndex = 5;
            this.lblPanelInfo.Text = "Server/Territory Info";
            this.lblPanelInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPanelInfo.UseCustomForeColor = true;
            // 
            // picExileLogoAboutMe
            // 
            this.picExileLogoAboutMe.BackgroundImage = global::Exile_Payment_Reminder.Properties.Resources.exile_logo;
            this.picExileLogoAboutMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picExileLogoAboutMe.ContextMenuStrip = this.exileMainMenu;
            this.picExileLogoAboutMe.Location = new System.Drawing.Point(23, 15);
            this.picExileLogoAboutMe.Name = "picExileLogoAboutMe";
            this.picExileLogoAboutMe.Size = new System.Drawing.Size(45, 42);
            this.picExileLogoAboutMe.TabIndex = 6;
            this.picExileLogoAboutMe.TabStop = false;
            // 
            // exileMainMenu
            // 
            this.exileMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLFromFileToolStripMenuItem,
            this.saveXMLToFileToolStripMenuItem,
            this.openSettingsToolStripMenuItem,
            this.readAboutMeToolStripMenuItem,
            this.visitBFCForumsToolStripMenuItem,
            this.viewCreditsToolStripMenuItem,
            this.viewNotificationLogToolStripMenuItem});
            this.exileMainMenu.Name = "exileMainMenu";
            this.exileMainMenu.Size = new System.Drawing.Size(230, 180);
            this.exileMainMenu.Style = MetroFramework.MetroColorStyle.Red;
            this.exileMainMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loadXMLFromFileToolStripMenuItem
            // 
            this.loadXMLFromFileToolStripMenuItem.Name = "loadXMLFromFileToolStripMenuItem";
            this.loadXMLFromFileToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.loadXMLFromFileToolStripMenuItem.Text = "Load XML From File (Ctrl + L)";
            this.loadXMLFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadXMLFromFileToolStripMenuItem_Click);
            // 
            // saveXMLToFileToolStripMenuItem
            // 
            this.saveXMLToFileToolStripMenuItem.Name = "saveXMLToFileToolStripMenuItem";
            this.saveXMLToFileToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.saveXMLToFileToolStripMenuItem.Text = "Save XML To File (Ctrl + S)";
            this.saveXMLToFileToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToFileToolStripMenuItem_Click);
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openSettingsToolStripMenuItem.Text = "Open Settings";
            this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.openSettingsToolStripMenuItem_Click);
            // 
            // readAboutMeToolStripMenuItem
            // 
            this.readAboutMeToolStripMenuItem.Name = "readAboutMeToolStripMenuItem";
            this.readAboutMeToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.readAboutMeToolStripMenuItem.Text = "Read About Me";
            this.readAboutMeToolStripMenuItem.Click += new System.EventHandler(this.readAboutMeToolStripMenuItem_Click);
            // 
            // visitBFCForumsToolStripMenuItem
            // 
            this.visitBFCForumsToolStripMenuItem.Name = "visitBFCForumsToolStripMenuItem";
            this.visitBFCForumsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.visitBFCForumsToolStripMenuItem.Text = "Visit BFC Forums";
            this.visitBFCForumsToolStripMenuItem.Click += new System.EventHandler(this.visitBFCForumsToolStripMenuItem_Click);
            // 
            // viewNotificationLogToolStripMenuItem
            // 
            this.viewNotificationLogToolStripMenuItem.Name = "viewNotificationLogToolStripMenuItem";
            this.viewNotificationLogToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.viewNotificationLogToolStripMenuItem.Text = "View Notification Log";
            this.viewNotificationLogToolStripMenuItem.Click += new System.EventHandler(this.viewNotificationLogToolStripMenuItem_Click);
            // 
            // tipExileLogo
            // 
            this.tipExileLogo.ToolTipTitle = "Help Menu";
            // 
            // lblUnsavedChanges
            // 
            this.lblUnsavedChanges.AutoSize = true;
            this.lblUnsavedChanges.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUnsavedChanges.Location = new System.Drawing.Point(364, 31);
            this.lblUnsavedChanges.Name = "lblUnsavedChanges";
            this.lblUnsavedChanges.Size = new System.Drawing.Size(148, 15);
            this.lblUnsavedChanges.Style = MetroFramework.MetroColorStyle.Red;
            this.lblUnsavedChanges.TabIndex = 7;
            this.lblUnsavedChanges.Text = "You have unsaved changes *";
            this.lblUnsavedChanges.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblUnsavedChanges.Visible = false;
            // 
            // viewCreditsToolStripMenuItem
            // 
            this.viewCreditsToolStripMenuItem.Name = "viewCreditsToolStripMenuItem";
            this.viewCreditsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.viewCreditsToolStripMenuItem.Text = "View Credits";
            this.viewCreditsToolStripMenuItem.Click += new System.EventHandler(this.viewCreditsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1012, 567);
            this.Controls.Add(this.lblUnsavedChanges);
            this.Controls.Add(this.picExileLogoAboutMe);
            this.Controls.Add(this.lblPanelInfo);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.mainTree);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "---- Exile Territory Management";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_onKeyDown);
            this.notifyTrayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.treeViewContextMenu.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDivider_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExileLogoAboutMe)).EndInit();
            this.exileMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ExilePaymentTrayIcon;
        private System.Windows.Forms.ContextMenuStrip notifyTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem restorePaymentNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreMainWindowContextItem;
        private System.Windows.Forms.ToolStripMenuItem closeExilePaymentReminderContextItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroContextMenu treeViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTerritoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblPanelServerIP;
        private MetroFramework.Controls.MetroLabel lblPanelInfo;
        private MetroFramework.Controls.MetroLabel lblPanelTerritoryPaymentDue;
        private MetroFramework.Controls.MetroLabel lblPanelTerritoryName;
        private MetroFramework.Controls.MetroLabel lblPanelServerPlayersOnline;
        private MetroFramework.Controls.MetroLabel lblPanelServerStatus;
        private MetroFramework.Controls.MetroButton btnMadePayment;
        private MetroFramework.Controls.MetroCheckBox checkReceiveNotifs;
        private MetroFramework.Controls.MetroLabel lblPanelReceiveNotifs;
        private MetroFramework.Controls.MetroButton btnEditBuildRightsOwners;
        private System.Windows.Forms.PictureBox picDivider_1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.PictureBox picExileLogoAboutMe;
        private System.Windows.Forms.ToolTip tipExileLogo;
        private MetroFramework.Controls.MetroContextMenu exileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readAboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitBFCForumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblUnsavedChanges;
        protected internal System.Windows.Forms.TreeView mainTree;
        private System.Windows.Forms.ToolStripMenuItem dismissAllNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXMLToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewNotificationLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCreditsToolStripMenuItem;
    }
}


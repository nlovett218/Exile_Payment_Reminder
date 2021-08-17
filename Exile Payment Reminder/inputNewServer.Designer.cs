namespace Exile_Payment_Reminder
{
    partial class inputNewServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputNewServer));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.txtNameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtIPBox = new MetroFramework.Controls.MetroTextBox();
            this.checkGrabServerName = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(386, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelForm);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(260, 232);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 38);
            this.btnOK.Style = MetroFramework.MetroColorStyle.Red;
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.SubmitForm);
            // 
            // txtNameBox
            // 
            // 
            // 
            // 
            this.txtNameBox.CustomButton.Image = null;
            this.txtNameBox.CustomButton.Location = new System.Drawing.Point(461, 1);
            this.txtNameBox.CustomButton.Name = "";
            this.txtNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameBox.CustomButton.TabIndex = 1;
            this.txtNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameBox.CustomButton.UseSelectable = true;
            this.txtNameBox.CustomButton.Visible = false;
            this.txtNameBox.Lines = new string[] {
        "Enter your server name here..."};
            this.txtNameBox.Location = new System.Drawing.Point(23, 104);
            this.txtNameBox.MaxLength = 50;
            this.txtNameBox.Name = "txtNameBox";
            this.txtNameBox.PasswordChar = '\0';
            this.txtNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameBox.SelectedText = "";
            this.txtNameBox.SelectionLength = 0;
            this.txtNameBox.SelectionStart = 0;
            this.txtNameBox.ShortcutsEnabled = true;
            this.txtNameBox.Size = new System.Drawing.Size(483, 23);
            this.txtNameBox.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNameBox.TabIndex = 2;
            this.txtNameBox.Text = "Enter your server name here...";
            this.txtNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNameBox.UseSelectable = true;
            this.txtNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNameBox.Click += new System.EventHandler(this.txtNameBox_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(19, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Name *";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(19, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "IP (x.x.x.x:xxxx)";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtIPBox
            // 
            // 
            // 
            // 
            this.txtIPBox.CustomButton.Image = null;
            this.txtIPBox.CustomButton.Location = new System.Drawing.Point(461, 1);
            this.txtIPBox.CustomButton.Name = "";
            this.txtIPBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIPBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIPBox.CustomButton.TabIndex = 1;
            this.txtIPBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIPBox.CustomButton.UseSelectable = true;
            this.txtIPBox.CustomButton.Visible = false;
            this.txtIPBox.Lines = new string[] {
        "Enter your server IP here..."};
            this.txtIPBox.Location = new System.Drawing.Point(23, 189);
            this.txtIPBox.MaxLength = 50;
            this.txtIPBox.Name = "txtIPBox";
            this.txtIPBox.PasswordChar = '\0';
            this.txtIPBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIPBox.SelectedText = "";
            this.txtIPBox.SelectionLength = 0;
            this.txtIPBox.SelectionStart = 0;
            this.txtIPBox.ShortcutsEnabled = true;
            this.txtIPBox.Size = new System.Drawing.Size(483, 23);
            this.txtIPBox.Style = MetroFramework.MetroColorStyle.Red;
            this.txtIPBox.TabIndex = 4;
            this.txtIPBox.Text = "Enter your server IP here...";
            this.txtIPBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtIPBox.UseSelectable = true;
            this.txtIPBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIPBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIPBox.Click += new System.EventHandler(this.txtIPBox_Click);
            // 
            // checkGrabServerName
            // 
            this.checkGrabServerName.AutoSize = true;
            this.checkGrabServerName.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkGrabServerName.Location = new System.Drawing.Point(23, 133);
            this.checkGrabServerName.Name = "checkGrabServerName";
            this.checkGrabServerName.Size = new System.Drawing.Size(276, 19);
            this.checkGrabServerName.Style = MetroFramework.MetroColorStyle.Red;
            this.checkGrabServerName.TabIndex = 6;
            this.checkGrabServerName.Text = "Automatically get name of server from IP";
            this.checkGrabServerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkGrabServerName.UseSelectable = true;
            // 
            // inputNewServer
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(529, 289);
            this.Controls.Add(this.checkGrabServerName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtIPBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNameBox);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inputNewServer";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Add New Server";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroTextBox txtNameBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtIPBox;
        private MetroFramework.Controls.MetroCheckBox checkGrabServerName;
    }
}
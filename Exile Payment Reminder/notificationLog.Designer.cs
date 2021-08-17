namespace Exile_Payment_Reminder
{
    partial class notificationLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notificationLog));
            this.txtLogs = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txtLogs
            // 
            // 
            // 
            // 
            this.txtLogs.CustomButton.Image = null;
            this.txtLogs.CustomButton.Location = new System.Drawing.Point(14, 2);
            this.txtLogs.CustomButton.Name = "";
            this.txtLogs.CustomButton.Size = new System.Drawing.Size(323, 323);
            this.txtLogs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogs.CustomButton.TabIndex = 1;
            this.txtLogs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogs.CustomButton.UseSelectable = true;
            this.txtLogs.CustomButton.Visible = false;
            this.txtLogs.Lines = new string[0];
            this.txtLogs.Location = new System.Drawing.Point(23, 63);
            this.txtLogs.MaxLength = 32767;
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.PasswordChar = '\0';
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.SelectedText = "";
            this.txtLogs.SelectionLength = 0;
            this.txtLogs.SelectionStart = 0;
            this.txtLogs.ShortcutsEnabled = true;
            this.txtLogs.Size = new System.Drawing.Size(340, 328);
            this.txtLogs.Style = MetroFramework.MetroColorStyle.Red;
            this.txtLogs.TabIndex = 0;
            this.txtLogs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtLogs.UseSelectable = true;
            this.txtLogs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // notificationLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 414);
            this.Controls.Add(this.txtLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "notificationLog";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Notification Log";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.notificationLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtLogs;
    }
}
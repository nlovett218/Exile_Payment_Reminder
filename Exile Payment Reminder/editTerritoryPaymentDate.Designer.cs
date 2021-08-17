namespace Exile_Payment_Reminder
{
    partial class editTerritoryPaymentDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editTerritoryPaymentDate));
            this.dateTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.btnSetDate = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(23, 63);
            this.dateTimePicker.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(237, 29);
            this.dateTimePicker.Style = MetroFramework.MetroColorStyle.Red;
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dateTimePicker.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            // 
            // btnSetDate
            // 
            this.btnSetDate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSetDate.Location = new System.Drawing.Point(23, 98);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(237, 36);
            this.btnSetDate.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSetDate.TabIndex = 1;
            this.btnSetDate.Text = "Set";
            this.btnSetDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSetDate.UseSelectable = true;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // editTerritoryPaymentDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 151);
            this.Controls.Add(this.btnSetDate);
            this.Controls.Add(this.dateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editTerritoryPaymentDate";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Set New Payment Date";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dateTimePicker;
        private MetroFramework.Controls.MetroButton btnSetDate;
    }
}
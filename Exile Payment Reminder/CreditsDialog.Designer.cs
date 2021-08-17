namespace Exile_Payment_Reminder
{
    partial class CreditsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsDialog));
            this.lblCredits = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblCredits
            // 
            this.lblCredits.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCredits.Location = new System.Drawing.Point(23, 72);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(357, 171);
            this.lblCredits.Style = MetroFramework.MetroColorStyle.Red;
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = resources.GetString("lblCredits.Text");
            this.lblCredits.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CreditsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 263);
            this.Controls.Add(this.lblCredits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditsDialog";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Special Thanks To";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCredits;
    }
}
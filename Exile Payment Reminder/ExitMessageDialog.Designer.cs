namespace Exile_Payment_Reminder
{
    partial class ExitMessageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitMessageDialog));
            this.lblText = new MetroFramework.Controls.MetroLabel();
            this.checkDontAskAgain = new MetroFramework.Controls.MetroCheckBox();
            this.btnYesExit = new MetroFramework.Controls.MetroButton();
            this.btnNoExit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblText.Location = new System.Drawing.Point(23, 81);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(252, 25);
            this.lblText.Style = MetroFramework.MetroColorStyle.Red;
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Are you sure you want to exit?";
            this.lblText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // checkDontAskAgain
            // 
            this.checkDontAskAgain.AutoSize = true;
            this.checkDontAskAgain.Location = new System.Drawing.Point(27, 119);
            this.checkDontAskAgain.Name = "checkDontAskAgain";
            this.checkDontAskAgain.Size = new System.Drawing.Size(124, 15);
            this.checkDontAskAgain.Style = MetroFramework.MetroColorStyle.Red;
            this.checkDontAskAgain.TabIndex = 1;
            this.checkDontAskAgain.Text = "Don\'t ask me again";
            this.checkDontAskAgain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checkDontAskAgain.UseSelectable = true;
            // 
            // btnYesExit
            // 
            this.btnYesExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnYesExit.Location = new System.Drawing.Point(23, 150);
            this.btnYesExit.Name = "btnYesExit";
            this.btnYesExit.Size = new System.Drawing.Size(128, 41);
            this.btnYesExit.Style = MetroFramework.MetroColorStyle.Red;
            this.btnYesExit.TabIndex = 2;
            this.btnYesExit.Text = "Yes";
            this.btnYesExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnYesExit.UseSelectable = true;
            this.btnYesExit.Click += new System.EventHandler(this.btnYesExit_Click);
            // 
            // btnNoExit
            // 
            this.btnNoExit.Location = new System.Drawing.Point(157, 150);
            this.btnNoExit.Name = "btnNoExit";
            this.btnNoExit.Size = new System.Drawing.Size(128, 41);
            this.btnNoExit.Style = MetroFramework.MetroColorStyle.Red;
            this.btnNoExit.TabIndex = 3;
            this.btnNoExit.Text = "No";
            this.btnNoExit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNoExit.UseSelectable = true;
            this.btnNoExit.Click += new System.EventHandler(this.btnNoExit_Click);
            // 
            // ExitMessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 214);
            this.Controls.Add(this.btnNoExit);
            this.Controls.Add(this.btnYesExit);
            this.Controls.Add(this.checkDontAskAgain);
            this.Controls.Add(this.lblText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExitMessageDialog";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Exit Application?";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblText;
        private MetroFramework.Controls.MetroCheckBox checkDontAskAgain;
        private MetroFramework.Controls.MetroButton btnYesExit;
        private MetroFramework.Controls.MetroButton btnNoExit;
    }
}
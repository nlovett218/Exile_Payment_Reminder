namespace Exile_Payment_Reminder
{
    partial class InputBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.txtInputText = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(37, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 47);
            this.btnOK.Style = MetroFramework.MetroColorStyle.Red;
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(265, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 47);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtInputText
            // 
            // 
            // 
            // 
            this.txtInputText.CustomButton.Image = null;
            this.txtInputText.CustomButton.Location = new System.Drawing.Point(329, 1);
            this.txtInputText.CustomButton.Name = "";
            this.txtInputText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInputText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInputText.CustomButton.TabIndex = 1;
            this.txtInputText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInputText.CustomButton.UseSelectable = true;
            this.txtInputText.CustomButton.Visible = false;
            this.txtInputText.Lines = new string[0];
            this.txtInputText.Location = new System.Drawing.Point(37, 63);
            this.txtInputText.MaxLength = 60;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.PasswordChar = '\0';
            this.txtInputText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInputText.SelectedText = "";
            this.txtInputText.SelectionLength = 0;
            this.txtInputText.SelectionStart = 0;
            this.txtInputText.ShortcutsEnabled = true;
            this.txtInputText.Size = new System.Drawing.Size(351, 23);
            this.txtInputText.Style = MetroFramework.MetroColorStyle.Red;
            this.txtInputText.TabIndex = 0;
            this.txtInputText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtInputText.UseSelectable = true;
            this.txtInputText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInputText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InputBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(423, 188);
            this.Controls.Add(this.txtInputText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputBox";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroTextBox txtInputText;
    }
}
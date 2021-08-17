namespace Exile_Payment_Reminder
{
    partial class editTerritoryGUIDs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editTerritoryGUIDs));
            this.btnNewGUID = new MetroFramework.Controls.MetroButton();
            this.btnRemoveGUID = new MetroFramework.Controls.MetroButton();
            this.listGUIDs = new System.Windows.Forms.ListView();
            this.contextListGUIDs = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.contextListGUIDs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGUID
            // 
            this.btnNewGUID.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNewGUID.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnNewGUID.Location = new System.Drawing.Point(23, 347);
            this.btnNewGUID.Name = "btnNewGUID";
            this.btnNewGUID.Size = new System.Drawing.Size(425, 45);
            this.btnNewGUID.Style = MetroFramework.MetroColorStyle.Red;
            this.btnNewGUID.TabIndex = 1;
            this.btnNewGUID.Text = "Add New GUID";
            this.btnNewGUID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNewGUID.UseSelectable = true;
            this.btnNewGUID.Click += new System.EventHandler(this.btnNewGUID_Click);
            // 
            // btnRemoveGUID
            // 
            this.btnRemoveGUID.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRemoveGUID.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRemoveGUID.Location = new System.Drawing.Point(23, 398);
            this.btnRemoveGUID.Name = "btnRemoveGUID";
            this.btnRemoveGUID.Size = new System.Drawing.Size(425, 45);
            this.btnRemoveGUID.Style = MetroFramework.MetroColorStyle.Red;
            this.btnRemoveGUID.TabIndex = 2;
            this.btnRemoveGUID.Text = "Remove Selected GUID";
            this.btnRemoveGUID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveGUID.UseSelectable = true;
            this.btnRemoveGUID.Click += new System.EventHandler(this.btnRemoveGUID_Click);
            // 
            // listGUIDs
            // 
            this.listGUIDs.BackColor = System.Drawing.SystemColors.InfoText;
            this.listGUIDs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listGUIDs.ContextMenuStrip = this.contextListGUIDs;
            this.listGUIDs.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGUIDs.ForeColor = System.Drawing.Color.Red;
            this.listGUIDs.LabelWrap = false;
            this.listGUIDs.Location = new System.Drawing.Point(23, 63);
            this.listGUIDs.Name = "listGUIDs";
            this.listGUIDs.ShowGroups = false;
            this.listGUIDs.Size = new System.Drawing.Size(425, 278);
            this.listGUIDs.TabIndex = 3;
            this.listGUIDs.UseCompatibleStateImageBehavior = false;
            this.listGUIDs.View = System.Windows.Forms.View.List;
            // 
            // contextListGUIDs
            // 
            this.contextListGUIDs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextListGUIDs.Name = "contextListGUIDs";
            this.contextListGUIDs.Size = new System.Drawing.Size(103, 26);
            this.contextListGUIDs.Style = MetroFramework.MetroColorStyle.Red;
            this.contextListGUIDs.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(23, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(425, 45);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save and Close";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // editTerritoryGUIDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 510);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listGUIDs);
            this.Controls.Add(this.btnRemoveGUID);
            this.Controls.Add(this.btnNewGUID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "editTerritoryGUIDs";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Edit Build Rights Owners GUIDs";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.editTerritoryGUIDs_Load);
            this.contextListGUIDs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnNewGUID;
        private MetroFramework.Controls.MetroButton btnRemoveGUID;
        private System.Windows.Forms.ListView listGUIDs;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroContextMenu contextListGUIDs;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}
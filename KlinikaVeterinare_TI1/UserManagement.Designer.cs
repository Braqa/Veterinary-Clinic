namespace KlinikaVeterinare_TI1
{
    partial class UserManagement
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.dgvUsers = new Telerik.WinControls.UI.RadGridView();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvUsers.MasterTemplate.AllowAddNewRow = false;
            this.dgvUsers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "UserID";
            gridViewTextBoxColumn1.HeaderText = "UserID";
            gridViewTextBoxColumn1.Name = "UserID";
            gridViewTextBoxColumn1.Width = 189;
            gridViewTextBoxColumn2.FieldName = "Username";
            gridViewTextBoxColumn2.HeaderText = "Username";
            gridViewTextBoxColumn2.Name = "Username";
            gridViewTextBoxColumn2.Width = 273;
            gridViewTextBoxColumn3.FieldName = "RoleId";
            gridViewTextBoxColumn3.HeaderText = "Role";
            gridViewTextBoxColumn3.Name = "RoleId";
            gridViewTextBoxColumn3.Width = 137;
            gridViewTextBoxColumn4.FieldName = "IsActive";
            gridViewTextBoxColumn4.HeaderText = "IsActive";
            gridViewTextBoxColumn4.Name = "IsActive";
            gridViewTextBoxColumn4.Width = 226;
            this.dgvUsers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.dgvUsers.MasterTemplate.EnableFiltering = true;
            this.dgvUsers.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(857, 491);
            this.dgvUsers.TabIndex = 34;
            this.dgvUsers.ThemeName = "CrystalDark";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEdit.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(54, 620);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(325, 31);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.ThemeName = "CrystalDark";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnAdd.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(468, 620);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(325, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.ThemeName = "CrystalDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(857, 663);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagement";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGridView dgvUsers;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
    }
}

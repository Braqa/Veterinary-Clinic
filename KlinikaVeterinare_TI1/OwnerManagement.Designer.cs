namespace KlinikaVeterinare_TI1
{
    partial class OwnerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerManagement));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.dgvOwners = new Telerik.WinControls.UI.RadGridView();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEdit.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(51, 620);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(325, 31);
            this.btnEdit.TabIndex = 40;
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
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(468, 620);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(325, 31);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.ThemeName = "CrystalDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvOwners
            // 
            this.dgvOwners.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOwners.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvOwners.MasterTemplate.AllowAddNewRow = false;
            this.dgvOwners.MasterTemplate.AutoGenerateColumns = false;
            this.dgvOwners.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "OwnerID";
            gridViewTextBoxColumn1.HeaderText = "OwnerID";
            gridViewTextBoxColumn1.Name = "OwnerID";
            gridViewTextBoxColumn1.Width = 90;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 88;
            gridViewTextBoxColumn3.FieldName = "Surname";
            gridViewTextBoxColumn3.HeaderText = "Surname";
            gridViewTextBoxColumn3.Name = "Surname";
            gridViewTextBoxColumn3.Width = 93;
            gridViewTextBoxColumn4.FieldName = "Birthday";
            gridViewTextBoxColumn4.HeaderText = "Birthday";
            gridViewTextBoxColumn4.Name = "Birthday";
            gridViewTextBoxColumn4.Width = 102;
            gridViewTextBoxColumn5.FieldName = "PersonalNo";
            gridViewTextBoxColumn5.HeaderText = "PersonalNo";
            gridViewTextBoxColumn5.Name = "PersonalNo";
            gridViewTextBoxColumn5.Width = 104;
            gridViewTextBoxColumn6.FieldName = "SexID";
            gridViewTextBoxColumn6.HeaderText = "SexID";
            gridViewTextBoxColumn6.Name = "SexID";
            gridViewTextBoxColumn6.Width = 110;
            gridViewTextBoxColumn7.FieldName = "PhoneNo";
            gridViewTextBoxColumn7.HeaderText = "PhoneNo";
            gridViewTextBoxColumn7.Name = "PhoneNo";
            gridViewTextBoxColumn7.Width = 115;
            gridViewTextBoxColumn8.FieldName = "Email";
            gridViewTextBoxColumn8.HeaderText = "Email";
            gridViewTextBoxColumn8.Name = "Email";
            gridViewTextBoxColumn8.Width = 123;
            this.dgvOwners.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.dgvOwners.MasterTemplate.EnableFiltering = true;
            this.dgvOwners.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvOwners.Name = "dgvOwners";
            this.dgvOwners.ReadOnly = true;
            this.dgvOwners.Size = new System.Drawing.Size(857, 491);
            this.dgvOwners.TabIndex = 38;
            this.dgvOwners.ThemeName = "CrystalDark";
            // 
            // OwnerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 663);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvOwners);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerManagement";
            this.Text = "Owner Management";
            this.Load += new System.EventHandler(this.OwnerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGridView dgvOwners;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
    }
}
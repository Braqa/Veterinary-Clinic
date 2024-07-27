namespace KlinikaVeterinare_TI1
{
    partial class VeterinarianManagement
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeterinarianManagement));
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.dgvVeterinarian = new Telerik.WinControls.UI.RadGridView();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarian.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVeterinarian
            // 
            this.dgvVeterinarian.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVeterinarian.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvVeterinarian.MasterTemplate.AllowAddNewRow = false;
            this.dgvVeterinarian.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "VeterinarianID";
            gridViewTextBoxColumn1.HeaderText = "Veterinarian ID";
            gridViewTextBoxColumn1.Name = "VeterinarianID";
            gridViewTextBoxColumn1.Width = 73;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 177;
            gridViewTextBoxColumn3.FieldName = "Surname";
            gridViewTextBoxColumn3.HeaderText = "Surname";
            gridViewTextBoxColumn3.Name = "Surname";
            gridViewTextBoxColumn3.Width = 177;
            gridViewTextBoxColumn4.FieldName = "ClinicID";
            gridViewTextBoxColumn4.HeaderText = "ClinicID";
            gridViewTextBoxColumn4.Name = "ClinicID";
            gridViewTextBoxColumn4.Width = 177;
            gridViewTextBoxColumn5.FieldName = "RankID";
            gridViewTextBoxColumn5.HeaderText = "RankID";
            gridViewTextBoxColumn5.Name = "RankID";
            gridViewTextBoxColumn5.Width = 178;
            gridViewTextBoxColumn6.FieldName = "UserId";
            gridViewTextBoxColumn6.HeaderText = "UserId";
            gridViewTextBoxColumn6.Name = "UserId";
            gridViewTextBoxColumn6.Width = 43;
            this.dgvVeterinarian.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dgvVeterinarian.MasterTemplate.EnableFiltering = true;
            this.dgvVeterinarian.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvVeterinarian.Name = "dgvVeterinarian";
            this.dgvVeterinarian.ReadOnly = true;
            this.dgvVeterinarian.Size = new System.Drawing.Size(857, 491);
            this.dgvVeterinarian.TabIndex = 29;
            this.dgvVeterinarian.ThemeName = "CrystalDark";
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
            this.btnEdit.TabIndex = 9;
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
            this.btnAdd.Location = new System.Drawing.Point(474, 620);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(325, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.ThemeName = "CrystalDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // VeterinarianManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(857, 663);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvVeterinarian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VeterinarianManagement";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Veterinarian Management";
            this.Load += new System.EventHandler(this.VeterinarianManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarian.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeterinarian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGridView dgvVeterinarian;
    }
}

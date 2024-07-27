namespace KlinikaVeterinare_TI1
{
    partial class AnimalManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalManagement));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.dgvAnimals = new Telerik.WinControls.UI.RadGridView();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEdit.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(57, 680);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(325, 31);
            this.btnEdit.TabIndex = 37;
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
            this.btnAdd.Location = new System.Drawing.Point(474, 680);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(325, 31);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.ThemeName = "CrystalDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAnimals.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvAnimals.MasterTemplate.AllowAddNewRow = false;
            this.dgvAnimals.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "AnimalID";
            gridViewTextBoxColumn1.HeaderText = "AnimalID";
            gridViewTextBoxColumn1.Name = "AnimalID";
            gridViewTextBoxColumn1.Width = 118;
            gridViewTextBoxColumn2.FieldName = "OwnerID";
            gridViewTextBoxColumn2.HeaderText = "OwnerID";
            gridViewTextBoxColumn2.Name = "OwnerID";
            gridViewTextBoxColumn2.Width = 152;
            gridViewTextBoxColumn3.FieldName = "Name";
            gridViewTextBoxColumn3.HeaderText = "Name";
            gridViewTextBoxColumn3.Name = "Name";
            gridViewTextBoxColumn3.Width = 134;
            gridViewTextBoxColumn4.FieldName = "FamilyID";
            gridViewTextBoxColumn4.HeaderText = "FamilyID";
            gridViewTextBoxColumn4.Name = "FamilyID";
            gridViewTextBoxColumn4.Width = 134;
            gridViewTextBoxColumn5.FieldName = "RaceID";
            gridViewTextBoxColumn5.HeaderText = "RaceID";
            gridViewTextBoxColumn5.Name = "RaceID";
            gridViewTextBoxColumn5.Width = 137;
            gridViewTextBoxColumn6.FieldName = "Birthday";
            gridViewTextBoxColumn6.HeaderText = "Birthday";
            gridViewTextBoxColumn6.Name = "Birthday";
            gridViewTextBoxColumn6.Width = 166;
            this.dgvAnimals.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dgvAnimals.MasterTemplate.EnableFiltering = true;
            this.dgvAnimals.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.Size = new System.Drawing.Size(873, 491);
            this.dgvAnimals.TabIndex = 34;
            this.dgvAnimals.ThemeName = "CrystalDark";
            // 
            // AnimalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(873, 723);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAnimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimalManagement";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Animal Management";
            this.Load += new System.EventHandler(this.AnimalManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGridView dgvAnimals;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
    }
}

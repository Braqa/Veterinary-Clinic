namespace KlinikaVeterinare_TI1
{
    partial class VisitManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitManagement));
            this.dgvVisits = new Telerik.WinControls.UI.RadGridView();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisits
            // 
            this.dgvVisits.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVisits.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvVisits.MasterTemplate.AllowAddNewRow = false;
            this.dgvVisits.MasterTemplate.AutoGenerateColumns = false;
            this.dgvVisits.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "VisitID";
            gridViewTextBoxColumn1.HeaderText = "VisitID";
            gridViewTextBoxColumn1.Name = "VisitID";
            gridViewTextBoxColumn1.Width = 103;
            gridViewTextBoxColumn2.FieldName = "VisitDate";
            gridViewTextBoxColumn2.HeaderText = "VisitDate";
            gridViewTextBoxColumn2.Name = "VisitDate";
            gridViewTextBoxColumn2.Width = 127;
            gridViewTextBoxColumn3.FieldName = "AnimalID";
            gridViewTextBoxColumn3.HeaderText = "AnimalID";
            gridViewTextBoxColumn3.Name = "AnimalID";
            gridViewTextBoxColumn3.Width = 177;
            gridViewTextBoxColumn4.FieldName = "VeterinarianID";
            gridViewTextBoxColumn4.HeaderText = "VeterinarianID";
            gridViewTextBoxColumn4.Name = "VeterinarianID";
            gridViewTextBoxColumn4.Width = 129;
            gridViewTextBoxColumn5.FieldName = "ClinicID";
            gridViewTextBoxColumn5.HeaderText = "ClinicID";
            gridViewTextBoxColumn5.Name = "ClinicID";
            gridViewTextBoxColumn5.Width = 125;
            gridViewTextBoxColumn6.FieldName = "Diagnosis";
            gridViewTextBoxColumn6.HeaderText = "Diagnosis";
            gridViewTextBoxColumn6.Name = "Diagnosis";
            gridViewTextBoxColumn6.Width = 164;
            this.dgvVisits.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dgvVisits.MasterTemplate.EnableFiltering = true;
            this.dgvVisits.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.ReadOnly = true;
            this.dgvVisits.Size = new System.Drawing.Size(857, 491);
            this.dgvVisits.TabIndex = 41;
            this.dgvVisits.ThemeName = "CrystalDark";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnAdd.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(468, 626);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(325, 31);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.ThemeName = "CrystalDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // VisitManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 663);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvVisits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisitManagement";
            this.Text = "Visit Management";
            this.Load += new System.EventHandler(this.VisitManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGridView dgvVisits;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
    }
}
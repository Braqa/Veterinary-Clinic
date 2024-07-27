namespace KlinikaVeterinare_TI1
{
    partial class VaccineManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccineManagement));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.dgvVaccines = new Telerik.WinControls.UI.RadGridView();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccines.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnAdd.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(504, 650);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(309, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.ThemeName = "CrystalDark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvVaccines
            // 
            this.dgvVaccines.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVaccines.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvVaccines.MasterTemplate.AllowAddNewRow = false;
            this.dgvVaccines.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "VaccineID";
            gridViewTextBoxColumn1.HeaderText = "VaccineID";
            gridViewTextBoxColumn1.Name = "VaccineID";
            gridViewTextBoxColumn1.Width = 376;
            gridViewTextBoxColumn2.FieldName = "SerialNo";
            gridViewTextBoxColumn2.HeaderText = "SerialNo";
            gridViewTextBoxColumn2.Name = "SerialNo";
            gridViewTextBoxColumn2.Width = 457;
            this.dgvVaccines.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.dgvVaccines.MasterTemplate.EnableFiltering = true;
            this.dgvVaccines.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvVaccines.Name = "dgvVaccines";
            this.dgvVaccines.ReadOnly = true;
            this.dgvVaccines.Size = new System.Drawing.Size(865, 491);
            this.dgvVaccines.TabIndex = 39;
            this.dgvVaccines.ThemeName = "CrystalDark";
            // 
            // VaccineManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(865, 693);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvVaccines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VaccineManagement";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Vaccine Management";
            this.Load += new System.EventHandler(this.VaccineManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccines.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        public Telerik.WinControls.UI.RadGridView dgvVaccines;
    }
}

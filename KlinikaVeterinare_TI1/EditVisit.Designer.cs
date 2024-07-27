namespace KlinikaVeterinare_TI1
{
    partial class EditVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVisit));
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlClinicId = new Telerik.WinControls.UI.RadDropDownList();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlVeterinarianId = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlAnimalId = new Telerik.WinControls.UI.RadDropDownList();
            this.dtpVisitDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDiagnose = new Telerik.WinControls.UI.RadRichTextEditor();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.txtVisitId = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ddlOwner = new Telerik.WinControls.UI.RadDropDownList();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClinicId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlVeterinarianId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAnimalId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpVisitDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbDiagnose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitId)).BeginInit();
            this.panelHead.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 92;
            this.label6.Text = "Diagnose";
            // 
            // ddlClinicId
            // 
            this.ddlClinicId.Location = new System.Drawing.Point(237, 282);
            this.ddlClinicId.Name = "ddlClinicId";
            this.ddlClinicId.Size = new System.Drawing.Size(125, 24);
            this.ddlClinicId.TabIndex = 4;
            this.ddlClinicId.ThemeName = "CrystalDark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "Clinic";
            // 
            // ddlVeterinarianId
            // 
            this.ddlVeterinarianId.Location = new System.Drawing.Point(237, 241);
            this.ddlVeterinarianId.Name = "ddlVeterinarianId";
            this.ddlVeterinarianId.Size = new System.Drawing.Size(125, 24);
            this.ddlVeterinarianId.TabIndex = 3;
            this.ddlVeterinarianId.ThemeName = "CrystalDark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Veterinarian";
            // 
            // ddlAnimalId
            // 
            this.ddlAnimalId.Location = new System.Drawing.Point(237, 200);
            this.ddlAnimalId.Name = "ddlAnimalId";
            this.ddlAnimalId.Size = new System.Drawing.Size(125, 24);
            this.ddlAnimalId.TabIndex = 2;
            this.ddlAnimalId.ThemeName = "CrystalDark";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate.Location = new System.Drawing.Point(237, 118);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(125, 24);
            this.dtpVisitDate.TabIndex = 0;
            this.dtpVisitDate.TabStop = false;
            this.dtpVisitDate.Text = "6/10/2020";
            this.dtpVisitDate.ThemeName = "CrystalDark";
            this.dtpVisitDate.Value = new System.DateTime(2020, 6, 10, 13, 45, 33, 827);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Visit Date";
            // 
            // rtbDiagnose
            // 
            this.rtbDiagnose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.rtbDiagnose.Location = new System.Drawing.Point(237, 323);
            this.rtbDiagnose.Name = "rtbDiagnose";
            this.rtbDiagnose.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(28)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.rtbDiagnose.SelectionStroke = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.rtbDiagnose.Size = new System.Drawing.Size(294, 98);
            this.rtbDiagnose.TabIndex = 5;
            this.rtbDiagnose.ThemeName = "CrystalDark";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnUpdate.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(237, 444);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(222, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.ThemeName = "CrystalDark";
            // 
            // txtVisitId
            // 
            this.txtVisitId.Enabled = false;
            this.txtVisitId.Location = new System.Drawing.Point(238, 77);
            this.txtVisitId.Name = "txtVisitId";
            this.txtVisitId.ReadOnly = true;
            this.txtVisitId.Size = new System.Drawing.Size(124, 24);
            this.txtVisitId.TabIndex = 78;
            this.txtVisitId.ThemeName = "CrystalDark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Animal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "Visit ID";
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.White;
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(113, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(442, 54);
            this.panelHead.TabIndex = 81;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Visit";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelSidebar.Controls.Add(this.lblUser);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(113, 501);
            this.panelSidebar.TabIndex = 80;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser.Location = new System.Drawing.Point(4, 425);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 18);
            this.lblUser.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(113, 54);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ddlOwner
            // 
            this.ddlOwner.Location = new System.Drawing.Point(237, 159);
            this.ddlOwner.Name = "ddlOwner";
            this.ddlOwner.Size = new System.Drawing.Size(125, 24);
            this.ddlOwner.TabIndex = 1;
            this.ddlOwner.ThemeName = "CrystalDark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 93;
            this.label7.Text = "Owner";
            // 
            // EditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 501);
            this.Controls.Add(this.ddlOwner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlClinicId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlVeterinarianId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlAnimalId);
            this.Controls.Add(this.dtpVisitDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbDiagnose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtVisitId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelSidebar);
            this.Name = "EditVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ddlClinicId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlVeterinarianId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAnimalId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpVisitDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbDiagnose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisitId)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOwner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadDropDownList ddlClinicId;
        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadDropDownList ddlVeterinarianId;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownList ddlAnimalId;
        private Telerik.WinControls.UI.RadDateTimePicker dtpVisitDate;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadRichTextEditor rtbDiagnose;
        public Telerik.WinControls.UI.RadButton btnUpdate;
        public Telerik.WinControls.UI.RadTextBox txtVisitId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHead;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadDropDownList ddlOwner;
        private System.Windows.Forms.Label label7;
    }
}
namespace KlinikaVeterinare_TI1
{
    partial class AddVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVisit));
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.rtbDiagnose = new Telerik.WinControls.UI.RadRichTextEditor();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpVisitDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.ddlAnimalId = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlVeterinarianId = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlClinicId = new Telerik.WinControls.UI.RadDropDownList();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlOwner = new Telerik.WinControls.UI.RadDropDownList();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddNewOwner = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPersonalNo = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOwnerSurname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rtbDiagnose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.panelHead.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpVisitDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAnimalId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlVeterinarianId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClinicId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDiagnose
            // 
            this.rtbDiagnose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.rtbDiagnose.Location = new System.Drawing.Point(233, 259);
            this.rtbDiagnose.Name = "rtbDiagnose";
            this.rtbDiagnose.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(28)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.rtbDiagnose.SelectionStroke = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(131)))), ((int)(((byte)(255)))));
            this.rtbDiagnose.Size = new System.Drawing.Size(382, 98);
            this.rtbDiagnose.TabIndex = 68;
            this.rtbDiagnose.ThemeName = "CrystalDark";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnSave.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(233, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 31);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "CrystalDark";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Animal";
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.White;
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(113, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(514, 54);
            this.panelHead.TabIndex = 65;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Visit";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelSidebar.Controls.Add(this.lblUser);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(113, 440);
            this.panelSidebar.TabIndex = 64;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser.Location = new System.Drawing.Point(4, 364);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Visit Date";
            // 
            // dtpVisitDate
            // 
            this.dtpVisitDate.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate.Location = new System.Drawing.Point(233, 69);
            this.dtpVisitDate.Name = "dtpVisitDate";
            this.dtpVisitDate.Size = new System.Drawing.Size(125, 24);
            this.dtpVisitDate.TabIndex = 71;
            this.dtpVisitDate.TabStop = false;
            this.dtpVisitDate.Text = "6/10/2020";
            this.dtpVisitDate.ThemeName = "CrystalDark";
            this.dtpVisitDate.Value = new System.DateTime(2020, 6, 10, 13, 45, 33, 827);
            // 
            // ddlAnimalId
            // 
            this.ddlAnimalId.Location = new System.Drawing.Point(233, 145);
            this.ddlAnimalId.Name = "ddlAnimalId";
            this.ddlAnimalId.Size = new System.Drawing.Size(125, 24);
            this.ddlAnimalId.TabIndex = 72;
            this.ddlAnimalId.ThemeName = "CrystalDark";
            // 
            // ddlVeterinarianId
            // 
            this.ddlVeterinarianId.Location = new System.Drawing.Point(233, 183);
            this.ddlVeterinarianId.Name = "ddlVeterinarianId";
            this.ddlVeterinarianId.Size = new System.Drawing.Size(125, 24);
            this.ddlVeterinarianId.TabIndex = 74;
            this.ddlVeterinarianId.ThemeName = "CrystalDark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Veterinarian";
            // 
            // ddlClinicId
            // 
            this.ddlClinicId.Location = new System.Drawing.Point(233, 221);
            this.ddlClinicId.Name = "ddlClinicId";
            this.ddlClinicId.Size = new System.Drawing.Size(125, 24);
            this.ddlClinicId.TabIndex = 76;
            this.ddlClinicId.ThemeName = "CrystalDark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Clinic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Diagnose";
            // 
            // ddlOwner
            // 
            this.ddlOwner.Location = new System.Drawing.Point(233, 107);
            this.ddlOwner.Name = "ddlOwner";
            this.ddlOwner.Size = new System.Drawing.Size(125, 24);
            this.ddlOwner.TabIndex = 79;
            this.ddlOwner.ThemeName = "CrystalDark";
            this.ddlOwner.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlOwner_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "Owner";
            // 
            // btnAddNewOwner
            // 
            this.btnAddNewOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnAddNewOwner.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnAddNewOwner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewOwner.Location = new System.Drawing.Point(364, 107);
            this.btnAddNewOwner.Name = "btnAddNewOwner";
            this.btnAddNewOwner.Size = new System.Drawing.Size(34, 24);
            this.btnAddNewOwner.TabIndex = 80;
            this.btnAddNewOwner.Text = "+";
            this.btnAddNewOwner.ThemeName = "CrystalDark";
            this.btnAddNewOwner.Click += new System.EventHandler(this.btnAddNewOwner_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.label8);
            this.radGroupBox1.Controls.Add(this.lblPersonalNo);
            this.radGroupBox1.Controls.Add(this.lblOwnerName);
            this.radGroupBox1.Controls.Add(this.label9);
            this.radGroupBox1.Controls.Add(this.lblOwnerSurname);
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(1);
            this.radGroupBox1.HeaderText = "Owner Info";
            this.radGroupBox1.Location = new System.Drawing.Point(404, 107);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(216, 132);
            this.radGroupBox1.TabIndex = 81;
            this.radGroupBox1.Text = "Owner Info";
            this.radGroupBox1.ThemeName = "CrystalDark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Owner name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 66;
            this.label8.Text = "Owner surname:";
            // 
            // lblPersonalNo
            // 
            this.lblPersonalNo.AutoSize = true;
            this.lblPersonalNo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalNo.Location = new System.Drawing.Point(132, 101);
            this.lblPersonalNo.Name = "lblPersonalNo";
            this.lblPersonalNo.Size = new System.Drawing.Size(33, 17);
            this.lblPersonalNo.TabIndex = 71;
            this.lblPersonalNo.Text = "N/A";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerName.Location = new System.Drawing.Point(132, 33);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(33, 17);
            this.lblOwnerName.TabIndex = 67;
            this.lblOwnerName.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 70;
            this.label9.Text = "Personal no:";
            // 
            // lblOwnerSurname
            // 
            this.lblOwnerSurname.AutoSize = true;
            this.lblOwnerSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerSurname.Location = new System.Drawing.Point(132, 67);
            this.lblOwnerSurname.Name = "lblOwnerSurname";
            this.lblOwnerSurname.Size = new System.Drawing.Size(33, 17);
            this.lblOwnerSurname.TabIndex = 69;
            this.lblOwnerSurname.Text = "N/A";
            // 
            // AddVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 440);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnAddNewOwner);
            this.Controls.Add(this.btnSave);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelSidebar);
            this.Name = "AddVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.rtbDiagnose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpVisitDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAnimalId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlVeterinarianId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClinicId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.UI.RadRichTextEditor rtbDiagnose;
        public Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelHead;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDateTimePicker dtpVisitDate;
        private Telerik.WinControls.UI.RadDropDownList ddlAnimalId;
        private Telerik.WinControls.UI.RadDropDownList ddlVeterinarianId;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownList ddlClinicId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Telerik.WinControls.UI.RadDropDownList ddlOwner;
        private System.Windows.Forms.Label label7;
        public Telerik.WinControls.UI.RadButton btnAddNewOwner;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPersonalNo;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOwnerSurname;
    }
}
namespace KlinikaVeterinare_TI1
{
    partial class AddOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOwner));
            this.ddlSex = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtPhoneno = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonalno = new Telerik.WinControls.UI.RadTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ddlSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            this.panelHead.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalno)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlSex
            // 
            this.ddlSex.Location = new System.Drawing.Point(235, 144);
            this.ddlSex.Name = "ddlSex";
            this.ddlSex.Size = new System.Drawing.Size(124, 24);
            this.ddlSex.TabIndex = 2;
            this.ddlSex.ThemeName = "CrystalDark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Sex";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(235, 106);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(124, 24);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.ThemeName = "CrystalDark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 24);
            this.txtName.TabIndex = 0;
            this.txtName.ThemeName = "CrystalDark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name";
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.White;
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(113, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(266, 54);
            this.panelHead.TabIndex = 41;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Owner";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelSidebar.Controls.Add(this.lblUser);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(113, 404);
            this.panelSidebar.TabIndex = 40;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser.Location = new System.Drawing.Point(4, 328);
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnSave.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(235, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Add";
            this.btnSave.ThemeName = "CrystalDark";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPhoneno
            // 
            this.txtPhoneno.Location = new System.Drawing.Point(235, 182);
            this.txtPhoneno.Name = "txtPhoneno";
            this.txtPhoneno.Size = new System.Drawing.Size(124, 24);
            this.txtPhoneno.TabIndex = 3;
            this.txtPhoneno.ThemeName = "CrystalDark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Phone no";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(235, 220);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(124, 24);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.ThemeName = "CrystalDark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "E-mail";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(235, 258);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(124, 24);
            this.dtpDOB.TabIndex = 5;
            this.dtpDOB.TabStop = false;
            this.dtpDOB.Text = "5/5/2020";
            this.dtpDOB.ThemeName = "CrystalDark";
            this.dtpDOB.Value = new System.DateTime(2020, 5, 5, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Birthday";
            // 
            // txtPersonalno
            // 
            this.txtPersonalno.Location = new System.Drawing.Point(235, 296);
            this.txtPersonalno.Name = "txtPersonalno";
            this.txtPersonalno.Size = new System.Drawing.Size(124, 24);
            this.txtPersonalno.TabIndex = 6;
            this.txtPersonalno.ThemeName = "CrystalDark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Personal no";
            // 
            // AddOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 404);
            this.Controls.Add(this.txtPersonalno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhoneno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.ddlSex);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Name = "AddOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ddlSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonalno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Telerik.WinControls.UI.RadDropDownList ddlSex;
        public Telerik.WinControls.UI.RadButton btnSave;
        public Telerik.WinControls.UI.RadTextBox txtSurname;
        public Telerik.WinControls.UI.RadTextBox txtName;
        private System.Windows.Forms.Panel panelHead;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        public Telerik.WinControls.UI.RadTextBox txtPhoneno;
        private System.Windows.Forms.Label label1;
        public Telerik.WinControls.UI.RadTextBox txtEmail;
        private System.Windows.Forms.Label label5;
        public Telerik.WinControls.UI.RadDateTimePicker dtpDOB;
        private System.Windows.Forms.Label label6;
        public Telerik.WinControls.UI.RadTextBox txtPersonalno;
        private System.Windows.Forms.Label label7;
    }
}
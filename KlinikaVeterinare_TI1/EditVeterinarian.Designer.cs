namespace KlinikaVeterinare_TI1
{
    partial class EditVeterinarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVeterinarian));
            this.ddlRanks = new Telerik.WinControls.UI.RadDropDownList();
            this.txtSurname = new Telerik.WinControls.UI.RadTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlClinics = new Telerik.WinControls.UI.RadDropDownList();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVeterinarianId = new Telerik.WinControls.UI.RadTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClinics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVeterinarianId)).BeginInit();
            this.panelHead.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlRanks
            // 
            this.ddlRanks.Location = new System.Drawing.Point(242, 252);
            this.ddlRanks.Name = "ddlRanks";
            this.ddlRanks.Size = new System.Drawing.Size(125, 24);
            this.ddlRanks.TabIndex = 5;
            this.ddlRanks.ThemeName = "CrystalDark";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(242, 180);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(124, 24);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.ThemeName = "CrystalDark";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "Surname";
            // 
            // ddlClinics
            // 
            this.ddlClinics.Location = new System.Drawing.Point(242, 216);
            this.ddlClinics.Name = "ddlClinics";
            this.ddlClinics.Size = new System.Drawing.Size(125, 24);
            this.ddlClinics.TabIndex = 4;
            this.ddlClinics.ThemeName = "CrystalDark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 79;
            this.label5.Text = "Rank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 80;
            this.label4.Text = "Clinic";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 24);
            this.txtName.TabIndex = 2;
            this.txtName.ThemeName = "CrystalDark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(242, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(124, 24);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.ThemeName = "CrystalDark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Password";
            // 
            // txtVeterinarianId
            // 
            this.txtVeterinarianId.Enabled = false;
            this.txtVeterinarianId.Location = new System.Drawing.Point(242, 72);
            this.txtVeterinarianId.Name = "txtVeterinarianId";
            this.txtVeterinarianId.ReadOnly = true;
            this.txtVeterinarianId.Size = new System.Drawing.Size(124, 24);
            this.txtVeterinarianId.TabIndex = 0;
            this.txtVeterinarianId.ThemeName = "CrystalDark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "VeterinarianID";
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.White;
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(113, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(294, 54);
            this.panelHead.TabIndex = 69;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Veterinarian";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelSidebar.Controls.Add(this.lblUser);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(113, 360);
            this.panelSidebar.TabIndex = 68;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser.Location = new System.Drawing.Point(4, 284);
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnUpdate.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(243, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.ThemeName = "CrystalDark";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EditVeterinarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 360);
            this.Controls.Add(this.ddlRanks);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlClinics);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVeterinarianId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.btnUpdate);
            this.Name = "EditVeterinarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ddlRanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlClinics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVeterinarianId)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Telerik.WinControls.UI.RadDropDownList ddlRanks;
        public Telerik.WinControls.UI.RadTextBox txtSurname;
        private System.Windows.Forms.Label label6;
        public Telerik.WinControls.UI.RadDropDownList ddlClinics;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public Telerik.WinControls.UI.RadTextBox txtName;
        private System.Windows.Forms.Label label3;
        public Telerik.WinControls.UI.RadTextBox txtPassword;
        private System.Windows.Forms.Label label2;
        public Telerik.WinControls.UI.RadTextBox txtVeterinarianId;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHead;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Telerik.WinControls.UI.RadButton btnUpdate;
    }
}
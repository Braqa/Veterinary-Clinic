namespace KlinikaVeterinare_TI1
{
    partial class AddUser
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.ddlActive = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlRole = new Telerik.WinControls.UI.RadDropDownList();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            ((System.ComponentModel.ISupportInitialize)(this.ddlActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.panelHead.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlActive
            // 
            radListDataItem1.Text = "True";
            radListDataItem2.Text = "False";
            this.ddlActive.Items.Add(radListDataItem1);
            this.ddlActive.Items.Add(radListDataItem2);
            this.ddlActive.Location = new System.Drawing.Point(236, 188);
            this.ddlActive.Name = "ddlActive";
            this.ddlActive.Size = new System.Drawing.Size(125, 24);
            this.ddlActive.TabIndex = 3;
            this.ddlActive.ThemeName = "CrystalDark";
            // 
            // ddlRole
            // 
            this.ddlRole.Location = new System.Drawing.Point(235, 152);
            this.ddlRole.Name = "ddlRole";
            this.ddlRole.Size = new System.Drawing.Size(125, 24);
            this.ddlRole.TabIndex = 2;
            this.ddlRole.ThemeName = "CrystalDark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "IsActive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Role";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(235, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(124, 24);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.ThemeName = "CrystalDark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(235, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(124, 24);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.ThemeName = "CrystalDark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Username";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnSave.BackgroundImage = global::KlinikaVeterinare_TI1.Properties.Resources.icons8_details_30px_1;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(235, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "CrystalDark";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.White;
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(113, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(285, 54);
            this.panelHead.TabIndex = 41;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add User";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelSidebar.Controls.Add(this.lblUser);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(113, 314);
            this.panelSidebar.TabIndex = 40;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser.Location = new System.Drawing.Point(4, 238);
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
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 314);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.ddlActive);
            this.Controls.Add(this.ddlRole);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ddlActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Telerik.WinControls.UI.RadDropDownList ddlActive;
        public Telerik.WinControls.UI.RadDropDownList ddlRole;
        public Telerik.WinControls.UI.RadButton btnSave;
        public Telerik.WinControls.UI.RadTextBox txtPassword;
        public Telerik.WinControls.UI.RadTextBox txtUsername;
        private System.Windows.Forms.Panel panelHead;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
    }
}
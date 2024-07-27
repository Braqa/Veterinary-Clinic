namespace KlinikaVeterinare_TI1
{
    partial class EditAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAnimal));
            this.ddlOwner = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlRace = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlFamily = new Telerik.WinControls.UI.RadDropDownList();
            this.dtpDOB = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.ddlOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            this.panelHead.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlOwner
            // 
            this.ddlOwner.Location = new System.Drawing.Point(235, 76);
            this.ddlOwner.Name = "ddlOwner";
            this.ddlOwner.Size = new System.Drawing.Size(124, 24);
            this.ddlOwner.TabIndex = 0;
            this.ddlOwner.ThemeName = "CrystalDark";
            // 
            // ddlRace
            // 
            this.ddlRace.Location = new System.Drawing.Point(234, 228);
            this.ddlRace.Name = "ddlRace";
            this.ddlRace.Size = new System.Drawing.Size(125, 24);
            this.ddlRace.TabIndex = 4;
            this.ddlRace.ThemeName = "CrystalDark";
            // 
            // ddlFamily
            // 
            this.ddlFamily.Location = new System.Drawing.Point(235, 190);
            this.ddlFamily.Name = "ddlFamily";
            this.ddlFamily.Size = new System.Drawing.Size(124, 24);
            this.ddlFamily.TabIndex = 3;
            this.ddlFamily.ThemeName = "CrystalDark";
            this.ddlFamily.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlFamily_SelectedIndexChanged);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarSize = new System.Drawing.Size(290, 320);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(235, 152);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(124, 24);
            this.dtpDOB.TabIndex = 2;
            this.dtpDOB.TabStop = false;
            this.dtpDOB.Text = "5/5/2020";
            this.dtpDOB.ThemeName = "CrystalDark";
            this.dtpDOB.Value = new System.DateTime(2020, 5, 5, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Family";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Date of birth";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 24);
            this.txtName.TabIndex = 1;
            this.txtName.ThemeName = "CrystalDark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "OwnerID";
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.White;
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(113, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(310, 54);
            this.panelHead.TabIndex = 69;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(23, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Animal";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelSidebar.Controls.Add(this.lblUser);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(113, 343);
            this.panelSidebar.TabIndex = 68;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser.Location = new System.Drawing.Point(4, 267);
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
            this.btnUpdate.Location = new System.Drawing.Point(234, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.ThemeName = "CrystalDark";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EditAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 343);
            this.Controls.Add(this.ddlOwner);
            this.Controls.Add(this.ddlRace);
            this.Controls.Add(this.ddlFamily);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.btnUpdate);
            this.Name = "EditAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAnimal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAnimal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ddlOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
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
        public Telerik.WinControls.UI.RadDropDownList ddlOwner;
        public Telerik.WinControls.UI.RadDropDownList ddlRace;
        public Telerik.WinControls.UI.RadDropDownList ddlFamily;
        public Telerik.WinControls.UI.RadDateTimePicker dtpDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public Telerik.WinControls.UI.RadTextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHead;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Telerik.WinControls.UI.RadButton btnUpdate;
    }
}
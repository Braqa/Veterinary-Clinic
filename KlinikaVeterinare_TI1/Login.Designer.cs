using System.Drawing;

namespace KlinikaVeterinare_TI1
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelHead = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panelHead.Controls.Add(this.btnCancel);
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Controls.Add(this.iconPictureBox1);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(400, 70);
            this.panelHead.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCancel.IconSize = 25;
            this.btnCancel.Location = new System.Drawing.Point(320, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rotation = 0D;
            this.btnCancel.Size = new System.Drawing.Size(78, 70);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(73, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 67);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fauna Jone";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Dog;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.iconPictureBox1.IconSize = 62;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 5);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(76, 62);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(111, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please Login First";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.iconPictureBox2.IconSize = 62;
            this.iconPictureBox2.Location = new System.Drawing.Point(165, 99);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(62, 76);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 7;
            this.iconPictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(83, 277);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 35);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(83, 227);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(237, 35);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(83, 321);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(237, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(400, 464);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
    }
}


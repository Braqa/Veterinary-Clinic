using System;
using System.Windows.Forms;
using KlinikaVeterinare.BLL;
using KlinikaVeterinare.BO;
using KlinikaVeterinare_TI1.App_Code;

namespace KlinikaVeterinare_TI1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            string hashedpassword = UserBLL.ComputeHash256(password);

            if (txtUsername.Text.Trim() != "" && password.Trim() != "")
            {
                User logginguser = UserBLL.LogIn(txtUsername.Text, hashedpassword);

                if (logginguser != null)
                {
                    UserSession.CurrentUser = logginguser;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect!");
                }
            }
            else
            {
                MessageBox.Show("Ju lutem shkruani kredencialet per tu loguar", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserSession.CurrentUser == null)
            {
                Application.Exit();
            }
        }
        private void enter_click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this,new EventArgs());
            }
        }

    }
}

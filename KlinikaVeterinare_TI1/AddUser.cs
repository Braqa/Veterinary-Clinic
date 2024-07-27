using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlinikaVeterinare.BLL;
using KlinikaVeterinare_TI1.App_Code;

namespace KlinikaVeterinare_TI1
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KlinikaVeterinare.BO.User user = new KlinikaVeterinare.BO.User();

            if (txtPassword.Text == null || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password!");
                return;
            }

            string hashedpassword = UserBLL.ComputeHash256(txtPassword.Text);

            user.Username = txtUsername.Text;
            user.Password = hashedpassword;

            if (UserBLL.Add(user, UserSession.CurrentUser) == true)
                MessageBox.Show("Success!");
            else 
                MessageBox.Show("Error!");
        }
    }
}

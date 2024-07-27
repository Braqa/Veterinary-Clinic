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
using KlinikaVeterinare.BO;
using System.Linq.Expressions;

namespace KlinikaVeterinare_TI1
{
    public partial class EditUser : Form
    {
        public static User updateduser = new User();

        public EditUser(User user)
        {
            InitializeComponent();
            updateduser = user;

            ddlRole.DataSource = RoleBLL.GetAll();
            ddlRole.ValueMember = "RoleID";
            ddlRole.DisplayMember = "Name";

            txtUserID.Text = user.UserID.ToString();
            txtUserID.ReadOnly = true;
            txtUsername.Text = user.Username;
            txtUsername.ReadOnly = true;

            ddlActive.SelectedIndex = 0;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            User user = new User() { UserID = updateduser.UserID, Username = updateduser.Username };
            if (ddlActive.SelectedIndex==0)
            {
                user.IsActive = true;
            }
            else
            {
                user.IsActive = false;
            }

            int roleid;
            int.TryParse(ddlRole.SelectedValue.ToString(), out roleid);

            user.RoleId = roleid;

           
            bool changepassword = false;
            if((txtPassword.Text == null || txtPassword.Text == "") && (txtConfirmPassword.Text == null || txtConfirmPassword.Text == ""))
            {
                if (UserBLL.Update(user, UserSession.CurrentUser, changepassword))
                {
                    MessageBox.Show("Updated INFO successfully!");
                }
            }
            else
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    user.Password = UserBLL.ComputeHash256(txtPassword.Text);
                    changepassword = true;

                    if (UserBLL.Update(user, UserSession.CurrentUser, changepassword))
                    {
                        MessageBox.Show("Updated 'INFO + Password' successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match!");
                }
            }
            
        }
    }
}

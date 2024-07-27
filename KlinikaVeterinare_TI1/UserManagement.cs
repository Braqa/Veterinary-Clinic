using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KlinikaVeterinare.BLL;
using KlinikaVeterinare_TI1.App_Code;
using Telerik.WinControls;
using KlinikaVeterinare.BO;

namespace KlinikaVeterinare_TI1
{
    public partial class UserManagement : Telerik.WinControls.UI.RadForm
    {
        private readonly UserBLL userBll;
        private bool edit;
        public UserManagement()
        {
            InitializeComponent();
            userBll = new UserBLL();
            dgvUsers.AutoGenerateColumns = false;
        }

        public void InitData()
        {
            var users = UserBLL.UsersList();
            dgvUsers.DataSource = users;
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            InitData();
            dgvUsers.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

      

        private void btnEdit_Click(object sender, EventArgs e)
        {

            

            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userid =Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());

                User user = UserBLL.GetUser(userid);

                EditUser editUser = new EditUser(user);

                //editUser.txtUserID.Text = 
                //editUser.txtUsername.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                //editUser.ddlRole.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
                //editUser.ddlActive.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();

                editUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selektoni rreshtin qe deshironi ta editoni!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Windows.Forms;
using KlinikaVeterinare.BLL;
using KlinikaVeterinare.BO;

namespace KlinikaVeterinare_TI1.AdministrationForms
{
    public partial class RoleForm : Form
    {
        private readonly RoleBLL roleBll;
        public RoleForm()
        {
            InitializeComponent();
            roleBll = new RoleBLL();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            //var roles = roleBll.GetAll();
            //dgvRoles.DataSource = roles;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Ju lutem plotesoni emrin!");
                txtName.Focus();
            }

            if (txtId.Text.Trim() == "")
            {
                Role role = new Role();

                role.Name = txtName.Text;
                role.Description = rtbDescription.Text;

                int registered = roleBll.Add(role);

                if (registered >= 1)
                {
                    InitData();
                    ClearControls();
                }
                else if (registered <= 0)
                {
                    MessageBox.Show("Insertimi deshtoi, Kontrollo nese egziston roli!");
                }
            }
        }


        private void ClearControls()
        {
            txtId.Text = txtName.Text = rtbDescription.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() != "" || txtName.Text.Trim() != "" || rtbDescription.Text.Trim() != "")
            {
                if (MessageBox.Show("Keni te shkruar dicka", "A jeni sigurt", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ClearControls();
                }
            }
        }
    }
}

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

namespace KlinikaVeterinare_TI1
{
    public partial class OwnerManagement : Form
    {
        public OwnerManagement()
        {
            InitializeComponent();
        }

        private void InitData()
        {
            var owners = OwnerBLL.GetAll();
            dgvOwners.DataSource = owners;
        }
        private void OwnerManagement_Load(object sender, EventArgs e)
        {
            InitData();
            dgvOwners.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOwner addOwner = new AddOwner();
            addOwner.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvOwners.SelectedRows.Count > 0)
            {
                
                EditOwner editOwner = new EditOwner(OwnerBLL.Get(Convert.ToInt32(dgvOwners.CurrentRow.Cells[0].Value.ToString())));

                //editOwner.txtName.Text = dgvOwners.CurrentRow.Cells[1].Value.ToString();
                //editOwner.txtSurname.Text = dgvOwners.CurrentRow.Cells[2].Value.ToString();
                //editOwner.dtpDOB.Text = dgvOwners.CurrentRow.Cells[3].Value.ToString();
                //editOwner.txtPersonalno.Text = dgvOwners.CurrentRow.Cells[4].Value.ToString();
                //editOwner.ddlSex.Text = dgvOwners.CurrentRow.Cells[5].Value.ToString();
                //editOwner.txtPhoneno.Text = dgvOwners.CurrentRow.Cells[6].Value.ToString();
                //editOwner.txtEmail.Text = dgvOwners.CurrentRow.Cells[7].Value.ToString();
                editOwner.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selektoni rreshtin qe deshironi ta editoni!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KlinikaVeterinare.BLL;
using KlinikaVeterinare.BO;
using KlinikaVeterinare_TI1.App_Code;
using Telerik.WinControls;

namespace KlinikaVeterinare_TI1
{
    public partial class VeterinarianManagement : Telerik.WinControls.UI.RadForm
    {
        private bool edit;
        public VeterinarianManagement()
        {
            InitializeComponent();

            //ddlClinics.DataSource = ClinicBLL.GetClinics();
            //ddlClinics.ValueMember = "ClinicID";
            //ddlClinics.DisplayMember = "Name";

            //ddlRanks.DataSource = VeterinarianRankBLL.GetVetRanks();
            //ddlRanks.ValueMember = "VeterinarianRankID";
            //ddlRanks.DisplayMember = "Rank_AL";
        }

        private void InitData()
        {
            var veterinarians = VeterinarianBLL.GetAllVeterinarians();
            dgvVeterinarian.DataSource = veterinarians;
        }

        private void VeterinarianManagement_Load(object sender, EventArgs e)
        {
            InitData();
            dgvVeterinarian.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddVeterinarian addVeterinarian = new AddVeterinarian();
            addVeterinarian.ShowDialog();

            //ClearControls();
            //panelVeterinarianData.Visible = true;
            //txtUsername.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            InitData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            

            if (dgvVeterinarian.SelectedRows.Count > 0)
            {
                int userid = Convert.ToInt32(dgvVeterinarian.CurrentRow.Cells[5].Value.ToString());

                EditVeterinarian editVeterinarian = new EditVeterinarian(VeterinarianBLL.GetById(userid));

                //editVeterinarian.txtVeterinarianId.Text = dgvVeterinarian.CurrentRow.Cells[0].Value.ToString();
                //editVeterinarian.txtName.Text = dgvVeterinarian.CurrentRow.Cells[1].Value.ToString();
                //editVeterinarian.txtSurname.Text = dgvVeterinarian.CurrentRow.Cells[2].Value.ToString();
                //editVeterinarian.ddlClinics.Text = dgvVeterinarian.CurrentRow.Cells[3].Value.ToString();
                //editVeterinarian.ddlRanks.Text = dgvVeterinarian.CurrentRow.Cells[4].Value.ToString();

                editVeterinarian.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selektoni rreshtin qe deshironi ta editoni!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearControls()
        {
        }
    }
}

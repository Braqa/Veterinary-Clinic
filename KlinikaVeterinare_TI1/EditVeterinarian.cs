using KlinikaVeterinare.BLL;
using KlinikaVeterinare.BO;
using KlinikaVeterinare_TI1.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace KlinikaVeterinare_TI1
{
    public partial class EditVeterinarian : Form
    {
        public static Veterinarian updatedveterinarian = null;
        public EditVeterinarian(Veterinarian veterinarian)
        {
            InitializeComponent();

            updatedveterinarian = veterinarian;

            ddlRanks.DataSource = VeterinarianRankBLL.GetVetRanks();
            ddlRanks.ValueMember = "VeterinarianRankID";
            ddlRanks.DisplayMember = "Rank_AL";
            ddlRanks.SelectedValue = veterinarian.RankID;

            ddlClinics.DataSource = ClinicBLL.GetClinics();
            ddlClinics.ValueMember = "ClinicID";
            ddlClinics.DisplayMember = "Name";
            ddlClinics.SelectedValue = veterinarian.ClinicID;

            txtVeterinarianId.Text = veterinarian.VeterinarianID;
            txtVeterinarianId.ReadOnly = true;
            txtName.Text = veterinarian.Name;
            txtName.ReadOnly = true;
            txtSurname.Text = veterinarian.Surname;
            txtSurname.ReadOnly = true;
            txtPassword.Text = veterinarian.Password;
            txtPassword.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = new User() { UserID = updatedveterinarian.UserID};

            updatedveterinarian.Name = txtName.Text;
            updatedveterinarian.Surname = txtSurname.Text;
            updatedveterinarian.ClinicID = ddlClinics.SelectedValue.ToString();
            updatedveterinarian.RankID = Convert.ToInt32(ddlRanks.SelectedValue.ToString());


            Veterinarian vet = VeterinarianBLL.UpdateVeterinarian(updatedveterinarian, user, UserSession.CurrentUser);

            if (vet!=null)
            {
                MessageBox.Show($"Veterinarian with Vet ID:{vet.VeterinarianID} has been updated!");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}

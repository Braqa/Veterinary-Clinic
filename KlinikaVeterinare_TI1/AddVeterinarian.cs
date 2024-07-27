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

namespace KlinikaVeterinare_TI1
{
    public partial class AddVeterinarian : Form
    {
        public AddVeterinarian()
        {
            InitializeComponent();

            ddlClinics.DataSource = ClinicBLL.GetClinics();
            ddlClinics.ValueMember = "ClinicID";
            ddlClinics.DisplayMember = "Name";

            ddlRanks.DataSource = VeterinarianRankBLL.GetVetRanks();
            ddlRanks.ValueMember = "VeterinarianRankID";
            ddlRanks.DisplayMember = "Rank_AL";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Veterinarian vet = new Veterinarian();
            User vetuser = new User();

            string hashedpassword = UserBLL.ComputeHash256(txtPassword.Text);

            vet.VeterinarianID = txtUsername.Text;
            vet.Name = txtName.Text;
            vet.Surname = txtSurname.Text;
            vet.ClinicID = ddlClinics.SelectedValue.ToString();
            vet.RankID = Convert.ToInt32(ddlRanks.SelectedValue);
            vetuser.Username = txtUsername.Text;
            vetuser.Password = hashedpassword;
            if( ddlRanks.SelectedItem.ToString()=="Asistent")
            {
                vetuser.RoleId = 5;
            }
            else
            {
                vetuser.RoleId = 4;
            }
           
            
       
            if (VeterinarianBLL.AddVeterinarian(vet, vetuser, UserSession.CurrentUser) != null)
                MessageBox.Show("Added successfully");
            else
                MessageBox.Show("Error!");
        }
    }
}

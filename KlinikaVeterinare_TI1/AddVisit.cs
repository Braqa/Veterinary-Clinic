using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.BLL;
using KlinikaVeterinare_TI1.App_Code;

namespace KlinikaVeterinare_TI1
{
    public partial class AddVisit : Form
    {
        public static List<Owner> owners = OwnerBLL.GetAll();
        public static List<Veterinarian> veterinarians = VeterinarianBLL.GetAllVeterinarians();
        public static List<Animal> animals = AnimalBLL.GetAll();
        public static List<Clinic> clinics = ClinicBLL.GetClinics();
        public AddVisit()
        {
            InitializeComponent();

            ddlOwner.DataSource = owners;
            ddlOwner.DisplayMember = "OwnerID";
            ddlOwner.ValueMember = "OwnerID";

            ddlVeterinarianId.DataSource = veterinarians;
            ddlVeterinarianId.DisplayMember = "Name " + "Surname"; 
            ddlVeterinarianId.ValueMember ="VeterinarianID";
            
            ddlAnimalId.DataSource = animals;
            ddlAnimalId.DisplayMember = "AnimalID";
            ddlAnimalId.ValueMember = "AnimalID";

            ddlClinicId.DataSource = clinics;
            ddlClinicId.DisplayMember = "Name";
            ddlClinicId.ValueMember = "ClinicID";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string animalid = ddlAnimalId.SelectedValue.ToString();
            string vetid = ddlVeterinarianId.SelectedValue.ToString();
            string clinicid = ddlClinicId.SelectedValue.ToString();


            Visit visit = new Visit() { VisitDate = dtpVisitDate.Value, Diagnosis = rtbDiagnose.Text, AnimalID = animalid, VeterinarianID = vetid, ClinicID = clinicid };

            bool added = VisitBLL.AddVisit(visit, UserSession.CurrentUser);

            if(added)
            {
                MessageBox.Show("Visit added successfully!");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }

            VisitManagement visitManagement = new VisitManagement();
            visitManagement.InitData();
        }
        private void btnAddNewOwner_Click(object sender, EventArgs e)
        {
            AddOwner addOwner = new AddOwner();
            addOwner.ShowDialog();
        }
        private void refreshOwnerData()
        {

            int ownerid;

            int.TryParse(ddlOwner.SelectedValue.ToString(), out ownerid);

            var owner = owners.Single(x => x.OwnerID == ownerid);
            lblOwnerName.Text = owner.Name;
            lblOwnerSurname.Text = owner.Surname;
            lblPersonalNo.Text = owner.PersonalNo.ToString();
        }

        private void ddlOwner_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            refreshOwnerData();
        }
    }
}

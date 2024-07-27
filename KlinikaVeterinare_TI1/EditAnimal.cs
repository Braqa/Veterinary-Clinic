using KlinikaVeterinare.BLL;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.DAL;
using KlinikaVeterinare_TI1.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikaVeterinare_TI1
{
    public partial class EditAnimal : Form
    {
        public static Animal pet = new Animal();
        public static List<Owner> owners = OwnerBLL.GetAll();
        public EditAnimal(Animal animal)
        {
            InitializeComponent();
            InitData();

            pet = animal;

            txtName.Text = animal.Name;
            dtpDOB.Value = animal.Birthday;
            ddlFamily.SelectedValue = animal.FamilyID;
            ddlRace.SelectedValue = animal.RaceID;
            ddlOwner.SelectedValue = animal.OwnerID;
        }
        private void InitData()
        {

            ddlRace.DataSource = null;
            ddlFamily.DataSource = null;
            ddlOwner.DataSource = null;

            ddlFamily.DataSource = FamiliesBLL.GetAllFamilies();
            ddlFamily.DisplayMember = "Family_AL";
            ddlFamily.ValueMember = "FamilyID".ToString();

            int familyID;
            int.TryParse(ddlFamily.SelectedValue.ToString(), out familyID);
            ddlRace.DataSource = RacesBLL.GetAllRaces().Where(x => x.FamilyID == familyID).ToList();
            ddlRace.DisplayMember = "Race_AL";
            ddlRace.ValueMember = "RaceID";


            ddlOwner.DataSource = owners;
            ddlOwner.DisplayMember = "OwnerID";
            ddlOwner.ValueMember = "OwnerID";

        }

        private void ddlFamily_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            int familyID;
            if (ddlFamily.SelectedValue != null)
            {
                int.TryParse(ddlFamily.SelectedValue.ToString(), out familyID);
            }
            else familyID = 1;
            
            ddlRace.DataSource = RacesBLL.GetAllRaces().Where(x => x.FamilyID == familyID).ToList();
            ddlRace.DisplayMember = "Race_AL";
            ddlRace.ValueMember = "RaceID";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int familyID;
            int.TryParse(ddlFamily.SelectedValue.ToString(), out familyID);
            int raceID;
            int.TryParse(ddlRace.SelectedValue.ToString(), out raceID);
            int ownerid;
            int.TryParse(ddlOwner.SelectedValue.ToString(), out ownerid);

            DateTime dob = dtpDOB.Value;

            Animal animal = new Animal() { AnimalID = pet.AnimalID, Name = txtName.Text, FamilyID = familyID, RaceID = raceID, Birthday = dob };

            Owner owner = new Owner() { OwnerID = ownerid};

            if(AnimalBLL.Edit(animal, owner, UserSession.CurrentUser))
            {
                MessageBox.Show("Successfully updated!");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }

            
        }

        private void EditAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            InitData();
        }
    }
}

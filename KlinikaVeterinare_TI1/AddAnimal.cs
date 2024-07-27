using KlinikaVeterinare.BLL;
using KlinikaVeterinare.BO;
using KlinikaVeterinare.DAL;
using KlinikaVeterinare_TI1.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikaVeterinare_TI1
{
    public partial class AddAnimal : Form
    {
        public static List<Owner> owners = OwnerBLL.GetAll();

        public AddAnimal()
        {
            InitializeComponent();

            ddlRace.DataSource = null;
            ddlFamily.DataSource = null;
            ddlOwner.DataSource = null;

            ddlFamily.DataSource = FamiliesBLL.GetAllFamilies();
            ddlFamily.DisplayMember = "Family_AL";
            ddlFamily.ValueMember = "FamilyID".ToString();

            ddlRace.DataSource = RacesBLL.GetAllRaces().Where(x => x.FamilyID == 1).ToList();
           
            ddlRace.DisplayMember = "Race_AL".ToString();
            ddlRace.ValueMember = "RaceID".ToString();


            ddlOwner.DataSource = owners;

            ddlOwner.DisplayMember = "OwnerID";
            ddlOwner.ValueMember = "OwnerID";

        }

        private void Refreshddls()
        {
            ddlRace.DataSource = null;

            int familyID = 0;
            int.TryParse(ddlFamily.SelectedValue.ToString(),out familyID);
            ddlRace.DataSource = RacesBLL.GetAllRaces().Where(x => x.FamilyID == familyID).ToList();
            ddlRace.DisplayMember = "Race_AL";
            ddlRace.ValueMember = "RaceID";

            owners = OwnerBLL.GetAll();
            ddlOwner.DisplayMember = "OwnerID";
            ddlOwner.ValueMember = "OwnerID";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int familyid;
            int raceid;

            int.TryParse(ddlFamily.SelectedValue.ToString(), out familyid);
            int.TryParse(ddlRace.SelectedValue.ToString(), out raceid);

            Animal animal = new Animal() { Name = txtName.Text, RaceID = raceid, FamilyID = familyid, Birthday = dtpDOB.Value };

            int ownerid;
            int.TryParse(ddlOwner.SelectedValue.ToString(), out ownerid);

            Owner owner = new Owner() { OwnerID = ownerid};

            bool animalAdded =  AnimalBLL.Add(animal,owner, UserSession.CurrentUser);

            if(animalAdded)
            {
                MessageBox.Show("Added successfully");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }

            Refreshddls();

        }

        private void ddlFamily_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Refreshddls();
        }

        private void ddlOwner_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            refreshOwnerData();
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

        private void btnAddNewOwner_Click(object sender, EventArgs e)
        {
            AddOwner addOwner = new AddOwner();
            addOwner.ShowDialog();
        }
    }
}

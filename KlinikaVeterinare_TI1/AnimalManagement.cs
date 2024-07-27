using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using KlinikaVeterinare.BLL;
using KlinikaVeterinare.BO;
using KlinikaVeterinare_TI1.App_Code;
using Telerik.WinControls;

namespace KlinikaVeterinare_TI1
{
    public partial class AnimalManagement : Telerik.WinControls.UI.RadForm
    {
        private bool edit;
        private readonly AnimalBLL animalBll;
        public AnimalManagement()
        {
            InitializeComponent();
            animalBll = new AnimalBLL();
        }

        private void AnimalManagement_Load(object sender, EventArgs e)
        {
            InitData();
            dgvAnimals.ClearSelection();
            //panelAnimalData.Enabled = false;
        }

        private void InitData()
        {
            var animals = AnimalBLL.GetAll();
            dgvAnimals.DataSource = animals;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimal = new AddAnimal();
            addAnimal.ShowDialog();
            //edit = false;
            //panelAnimalData.Enabled = true;
            //CleanFormFields();
            //txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count > 0)
            {
                string animalid = dgvAnimals.CurrentRow.Cells[0].Value.ToString();

                EditAnimal editAnimal = new EditAnimal(AnimalBLL.Get(animalid));

                //editAnimal.ddlOwner.Text = dgvAnimals.CurrentRow.Cells[0].Value.ToString();
                //editAnimal.txtName.Text = dgvAnimals.CurrentRow.Cells[1].Value.ToString();
                //editAnimal.ddlFamily.Text = dgvAnimals.CurrentRow.Cells[2].Value.ToString();
                //editAnimal.ddlRace.Text = dgvAnimals.CurrentRow.Cells[3].Value.ToString();
                //editAnimal.dtpDOB.Text = dgvAnimals.CurrentRow.Cells[4].Value.ToString();

                editAnimal.ShowDialog();

                
            }
            else
            {
                MessageBox.Show("Selektoni rreshtin qe deshironi ta editoni!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Animal GetAnimalFromDataGrid(int index)
        {
            if (index < 0)
            {
                return null;
            }

            return (Animal)dgvAnimals.Rows[index].DataBoundItem;
        }

    }
}

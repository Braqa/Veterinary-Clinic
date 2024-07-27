using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KlinikaVeterinare.BLL;
using KlinikaVeterinare.BO;
using KlinikaVeterinare_TI1.App_Code;

namespace KlinikaVeterinare_TI1
{
    public partial class VaccineManagement : Telerik.WinControls.UI.RadForm
    {
        private readonly VaccineBLL vaccineBll;

        private bool edit;

        public VaccineManagement()
        {
            InitializeComponent();
            vaccineBll = new VaccineBLL();
        }
        
        private void InitData()
        {
            var vaccines = VaccineBLL.GetAllVaccines();
            dgvVaccines.DataSource = vaccines;
        }

        private void VaccineManagement_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddVaccine addVaccine = new AddVaccine();
            addVaccine.ShowDialog();
            //addVaccine.txtVaccineID.Focus();
        }


    }
}

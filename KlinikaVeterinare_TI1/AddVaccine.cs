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
using KlinikaVeterinare.BLL;

namespace KlinikaVeterinare_TI1
{
    public partial class AddVaccine : Form
    {
        public static List<VaccineInfo> vaccines = new List<VaccineInfo>();
       

        public AddVaccine()
        {
            InitializeComponent();
            vaccines = VaccineInfoBLL.GetVaccineInfoAll();

            ddlVaccineId.DataSource = vaccines;
            ddlVaccineId.ValueMember = "VaccineID";
            ddlVaccineId.DisplayMember = "Name_EN";
            ddlVaccineId.SelectedValue = 1;
        }
        
        public void InitData()
        {
            VaccineManagement vaccineManagement = new VaccineManagement();
            var vaccines = VaccineBLL.GetAllVaccines();
            vaccineManagement.dgvVaccines.DataSource = vaccines;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KlinikaVeterinare.BO.Vaccine vaccine = new KlinikaVeterinare.BO.Vaccine();

            vaccine.VaccineID = Convert.ToInt32(ddlVaccineId.SelectedValue);
            vaccine.SerialNo = txtVaccineSerialno.Text;

            bool vaccineAdded = VaccineBLL.Add(vaccine, UserSession.CurrentUser);

            if (vaccineAdded)
            {
                MessageBox.Show("Added succesfully!");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }

            InitData();
        }

        private void ddlVaccineId_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //int vaccid;
            //int.TryParse(ddlVaccineId.SelectedValue.ToString(), out vaccid);

            //string vaccineinfo = vaccines.Where(x => x.VaccineID == vaccid).FirstOrDefault().Name_EN;

            //rtbInfo.Text = vaccineinfo;
        }
    }
}

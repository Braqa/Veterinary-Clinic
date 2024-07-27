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
    public partial class AddOwner : Form
    {

        public AddOwner()
        {
            InitializeComponent();
            ddlSex.DataSource = SexBLL.GetSexes();
            ddlSex.DisplayMember = "Sex_AL";
            ddlSex.ValueMember = "SexID";
  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int sex;

            int.TryParse(ddlSex.SelectedValue.ToString(), out sex);

            Owner owner = new Owner() { Name = txtName.Text, Surname = txtSurname.Text, Email = txtEmail.Text, Birthday = dtpDOB.Value, SexID = sex, PersonalNo = Convert.ToInt32(txtPersonalno.Text),PhoneNo=txtPhoneno.Text };

            if (OwnerBLL.Add(owner, UserSession.CurrentUser))
            {
                MessageBox.Show("Added successfully!");
            }
            else MessageBox.Show("Something went wrong!");

           
        }
    }
}

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
    public partial class EditOwner : Form
    {
        public static Owner updatedOwner = new Owner();

        public EditOwner(Owner owner)
        {
            InitializeComponent();

            ddlSex.DataSource = SexBLL.GetSexes();
            ddlSex.DataMember = "Sex_AL";
            ddlSex.ValueMember = "SexID";

            txtName.Text = owner.Name;
            txtSurname.Text = owner.Surname;
            txtPhoneno.Text = owner.PhoneNo;
            txtEmail.Text = owner.Email;
            txtPersonalno.Text = owner.PersonalNo.ToString();
            dtpDOB.Value = owner.Birthday;
            ddlSex.SelectedValue = owner.SexID;

            updatedOwner.OwnerID = owner.OwnerID;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int sex;
            int.TryParse(ddlSex.SelectedValue.ToString(), out sex);

            updatedOwner.Name = txtName.Text;
            updatedOwner.Surname = txtSurname.Text;
            updatedOwner.SexID = sex;
            updatedOwner.PhoneNo = txtPhoneno.Text;
            updatedOwner.Email = txtEmail.Text;
            updatedOwner.Birthday = dtpDOB.Value;
            updatedOwner.PersonalNo = Convert.ToInt32(txtPersonalno.Text);

            if(OwnerBLL.Modify(updatedOwner,UserSession.CurrentUser))
            {
                MessageBox.Show("Updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong!");
                
            }
        }
    }
}

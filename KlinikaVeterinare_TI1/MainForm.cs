using System;
using System.Drawing;
using System.Windows.Forms;
using KlinikaVeterinare_TI1.App_Code;

namespace KlinikaVeterinare_TI1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region ButtonsToManipulateSizeOfMainForm
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int lx, ly;
        private int sw, sh;

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;
            btnMaximize.Visible = false;
            btnResetDefault.Visible = true;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnResetDefault_Click(object sender, EventArgs e)
        {
            btnMaximize.Visible = true;
            btnResetDefault.Visible = false;
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();

            if (UserSession.CurrentUser != null)
                lblUser.Text = $"Pershendetje: {UserSession.CurrentUser.Username}";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
        }

        private void btnVaccine_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VaccineManagement());
        }

        private void btnVeterinarian_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VeterinarianManagement());

        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserManagement());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                UserSession.CurrentUser = null;
                lblUser.Text = "";
                Login li = new Login();
                li.ShowDialog();
                if (UserSession.CurrentUser != null)
                    lblUser.Text = $"Pershendetje: {UserSession.CurrentUser.Username}";
            }
        }
        private void btnManageAnimal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AnimalManagement());
        }

        private void btnManageOwner_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OwnerManagement());
        }

        private void btnManageVisit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VisitManagement());
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleOfChildForm.Text = childForm.Text;
        }
    }
}

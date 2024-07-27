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
    public partial class VisitManagement : Form
    {
        public VisitManagement()
        {
            InitializeComponent();
        }

        public void InitData()
        {
            var visits = VisitBLL.GetAll();
            dgvVisits.DataSource = visits;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddVisit addVisit = new AddVisit();
            addVisit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditVisit editVisit = new EditVisit();
            editVisit.ShowDialog();
        }

        private void VisitManagement_Load(object sender, EventArgs e)
        {
            InitData();
            dgvVisits.ClearSelection();
        }
    }
}

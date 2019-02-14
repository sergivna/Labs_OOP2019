using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_ado_net
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }
        private void препаратиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void містаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitiesForm cityForm = new CitiesForm();
            cityForm.Show();
            cityForm.MdiParent = this;
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void аптекиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugstoreForm drugstoreForm = new DrugstoreForm();
            drugstoreForm.Show();
            drugstoreForm.MdiParent = this;
        }

        private void табліциToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void постачальникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugstoreForm drugstoreForm = new DrugstoreForm();
            drugstoreForm.Show();
            drugstoreForm.MdiParent = this;

        }
    }
}

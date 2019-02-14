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
    public partial class AddDrugstoreForm : Form
    {
        public AddDrugstoreForm()
        {
            InitializeComponent();
        }

        private void AddDrugstoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drugstoresDataSet.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.drugstoresDataSet.Cities);

        }
    }
}

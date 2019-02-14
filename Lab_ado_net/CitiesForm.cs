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
    public partial class CitiesForm : Form
    {
        public CitiesForm()
        {
            InitializeComponent();
        }

        private void CitiesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drugstoresDataSet.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.drugstoresDataSet.Cities);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.citiesTableAdapter.Update(this.drugstoresDataSet.Cities);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //
         

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int? count = queriesTableAdapter1.GetCountProvisionersQuery(id) + queriesTableAdapter1.GetCountDrugstoresQuery(id);
            if (count == 0)
                citiesBindingSource.RemoveCurrent();
            else
                MessageBox.Show("Не можна видалити місто поки в ньому є аптеки чи постачальники");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

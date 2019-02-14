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
    public partial class CreateDrugstoreForm : Form
    {
        public CreateDrugstoreForm()
        {
            InitializeComponent();
        }

        private void CreateDrugstoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drugstoresDataSet.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.drugstoresDataSet.Cities);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drugstoresWithCitiesTableAdapter1.InsertQuery(textBox1.Text, (int)comboBox1.SelectedValue, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            this.Close();
        }
    }
}

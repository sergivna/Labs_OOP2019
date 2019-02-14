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
    public partial class DrugstoreForm : Form
    {
        public DrugstoreForm()
        {
            InitializeComponent();
        }

        private void AddDrugstoreForm_Load(object sender, EventArgs e)
        {
          
            this.drugstoresWithCitiesTableAdapter.Fill(this.drugstoresDataSet.DrugstoresWithCities);
          


        }

        private void Зберегти_Click(object sender, EventArgs e)
        {
            CreateDrugstoreForm createForm = new CreateDrugstoreForm();
            createForm.ShowDialog();
            this.drugstoresWithCitiesTableAdapter.Fill(this.drugstoresDataSet.DrugstoresWithCities);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Drugstore_Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int? count = queriesTableAdapter1.GetCountRelationsDrugstore(Drugstore_Id);
            if (count == 0)
            {
                //drugstoresWithCitiesBindingSource.RemoveCurrent();
                drugstoresWithCitiesTableAdapter.DeleteQuery(Drugstore_Id);
                this.drugstoresWithCitiesTableAdapter.Fill(this.drugstoresDataSet.DrugstoresWithCities);
            }
            else
            { 
                MessageBox.Show("Не можна видалити аптеку поки в ній є аптекарі чи медикаменти");
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

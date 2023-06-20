using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using UniCatalog.Clase;

namespace UniCatalog.Formulare
{
    public partial class Cicluri : Form
    {
        public Cicluri()
        {
            InitializeComponent();
            LoadCicluriInvatamant();
        }

        private void LoadCicluriInvatamant()
        {
            string query = @"Select Nume from CicluriInvatamant";
            SqlDataAdapter da = new SqlDataAdapter(query, Conector.ConSir());
            DataSet ds = new DataSet();
            da.Fill(ds, "CicluriInvatamant");
            dataGridView1.DataSource = ds.Tables["CicluriInvatamant"].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_adaugaCicluClick(object sender, EventArgs e)
        {
            if (txt_numeCiclu.Text == "")
            {
                MessageBox.Show("Nu ati completat numele ciclului!");
            }
            else
            {
                string query = @"insert into CicluriInvatamant values(@Nume)";
                using (SqlConnection cnn = new SqlConnection(Conector.ConSir()))
                {

                    string nume = txt_numeCiclu.Text;
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", nume);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    txt_numeCiclu.Text = "";
                }

            }
            LoadCicluriInvatamant();
        }

        private void btn_StergeCicluClick(object sender, EventArgs e)
        {


            // Check if any rows are selected
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Iterate over the selected rows and remove them

                // Remove the row from the DataGridView
                var cell = dataGridView1.SelectedCells[0];
                string nume = (string)cell.Value;
                string query = @"delete from CicluriInvatamant where Nume=@Nume";
                using (SqlConnection cnn = new SqlConnection(Conector.ConSir()))
                {

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", nume);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    dataGridView1.Rows.RemoveAt(cell.RowIndex);
                }

                // Refresh the DataGridView display
                dataGridView1.Refresh();

            }
        }

        private void Cicluri_Load(object sender, EventArgs e)
        {

        }
    }
}

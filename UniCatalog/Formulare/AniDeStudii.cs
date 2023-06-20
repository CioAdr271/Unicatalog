using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniCatalog.Clase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniCatalog.Formulare
{
    public partial class AniDeStudii : Form
    {
        public AniDeStudii()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection connection = new SqlConnection(Conector.ConSir()))
                {
                    connection.Open();

                    string query = "SELECT nume_program FROM ProgrameStudii";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string value = reader.GetString(0); // Assuming the column type is string

                        // Add the value to the ComboBox
                        cbx_program.Items.Add(value);
                    }

                    reader.Close();
                }
            }
            catch
            {

            }
            cbx_an.Items.Add("1");
            cbx_an.Items.Add("2");
            cbx_an.Items.Add("3");
            cbx_an.Items.Add("4");
            cbx_an.Items.Add("5");
            cbx_an.Items.Add("6");
            cbx_semestru.Items.Add("1");
            cbx_semestru.Items.Add("2");
            cbx_semestru.Items.Add("3");
            LoadAnSem();

        }
        private void LoadAnSem()
        {
            string query = @"Select id_an_studiu, id_semestru from an_studiu_semestru";

            SqlDataAdapter da = new SqlDataAdapter(query, Conector.ConSir());
            DataSet dp = new DataSet();
            da.Fill(dp, "an_studiu_semestru");
            dgv_an_semestru.DataSource = dp.Tables["an_studiu_semestru"].DefaultView;
        }

        private void btn_adaugaSemestru_Click(object sender, EventArgs e)
        {
            if (cbx_an.Text == "" || cbx_program.Text == "" || cbx_semestru.Text == "")
            {
                MessageBox.Show("Nu ati completat numele ciclului!");
            }
            else
            {
                string an = cbx_an.Text;
                string semestru = cbx_semestru.Text;
                string numeprogram = cbx_program.Text;

                using (SqlConnection con = new SqlConnection(Conector.ConSir()))
                {
                    con.Open();

                    string quernume = "SELECT id_program FROM ProgrameStudii WHERE nume_program = @Nume";
                    SqlCommand commandnume = new SqlCommand(quernume, con);
                    commandnume.Parameters.AddWithValue("@Nume", numeprogram);

                    int idansemestru = -1;
                    object result = commandnume.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idansemestru = Convert.ToInt32(result);
                    }

                    string query = "INSERT INTO an_studiu_semestru VALUES (@id_an_studiu, @id_semestru, @id_program_studiu)";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@id_an_studiu", an);
                    command.Parameters.AddWithValue("@id_semestru", semestru);
                    command.Parameters.AddWithValue("@id_program_studiu", idansemestru);
                    command.ExecuteNonQuery();
                }

            }
            LoadAnSem();
        }

        private void btn_stergeSemestru_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected
            if (dgv_an_semestru.SelectedCells.Count > 0)
            {
                // Iterate over the selected rows and remove them

                // Remove the row from the DataGridView
                var cell = dgv_an_semestru.SelectedCells[0];
                var cell1 = dgv_an_semestru.SelectedCells[0];
                string nume = (string)cell.Value;
                string semestru = (string)cell1.Value;
                string query = @"delete from an_studiu_semestru where id_an_studiu=@Nume AND id_semestru=@Semestru";
                using (SqlConnection cnn = new SqlConnection(Conector.ConSir()))
                {

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", nume);
                        cmd.Parameters.AddWithValue("@Semestru", semestru);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    dgv_an_semestru.Rows.RemoveAt(cell.RowIndex);
                }

                // Refresh the DataGridView display
                dgv_an_semestru.Refresh();
            }
        }

        private void AniDeStudii_Load(object sender, EventArgs e)
        {

        }
    }
}

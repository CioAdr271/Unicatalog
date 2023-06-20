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
    public partial class ProgrameStudii : Form
    {
        public ProgrameStudii()
        {
            InitializeComponent();
            LoadProgrameDeStudii();
        }

        private void LoadProgrameDeStudii()
        {
            string query = @"Select nume_program from ProgrameStudii";

            SqlDataAdapter da = new SqlDataAdapter(query, Conector.ConSir());
            DataSet dp = new DataSet();
            da.Fill(dp, "ProgrameStudii");
            dgv_programe.DataSource = dp.Tables["ProgrameStudii"].DefaultView;
        }

        private void ProgrameStudii_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conector.ConSir()))
                {
                    connection.Open();

                    string query = "SELECT Nume FROM CicluriInvatamant";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string value = reader.GetString(0); // Assuming the column type is string

                        // Add the value to the ComboBox
                        cbx_programestudii.Items.Add(value);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }

        private void btn_adaugaProgramClick(object sender, EventArgs e)
        {
            if (txt_numeprog.Text == "" || cbx_programestudii.Text == " ")
            {
                MessageBox.Show("Nu ati completat toate campurile");
            }
            else
            {
                int idProgramStudiu = -1;
                string numecicluinvatamant = cbx_programestudii.Text;
                string numeprogram = txt_numeprog.Text;
                using (SqlConnection con = new SqlConnection(Conector.ConSir()))
                {
                    con.Open();

                    string query = "SELECT ID_Ciclu FROM CicluriInvatamant WHERE nume = @Nume";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Nume", numecicluinvatamant);


                    // Executați interogarea și obțineți ID-ul programului de studiu
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idProgramStudiu = Convert.ToInt32(result);
                    }
                }

                using (SqlConnection con = new SqlConnection(Conector.ConSir()))
                {
                    con.Open();

                    string query = "INSERT INTO ProgrameStudii VALUES (@nume_program, @ID_ciclu_invatamant)";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@nume_program", numeprogram);
                    command.Parameters.AddWithValue("@ID_ciclu_invatamant", idProgramStudiu);

                    command.ExecuteNonQuery();
                }
            }

            LoadProgrameDeStudii();

        }

        private void btn_stergeProgramClick(object sender, EventArgs e)
        {
            // Check if any rows are selected
            if (dgv_programe.SelectedCells.Count > 0)
            {
                // Iterate over the selected rows and remove them

                // Remove the row from the DataGridView
                var cell = dgv_programe.SelectedCells[0];
                string nume = (string)cell.Value;
                string query = @"delete from ProgrameStudii where nume_program=@Nume";
                using (SqlConnection cnn = new SqlConnection(Conector.ConSir()))
                {

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", nume);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    dgv_programe.Rows.RemoveAt(cell.RowIndex);
                }

                // Refresh the DataGridView display
                dgv_programe.Refresh();
            }
        }
    }
}

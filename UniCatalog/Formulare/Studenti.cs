using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniCatalog.Clase;

namespace UniCatalog.Formulare
{
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
            Loadstudenti();
        }
        private void Loadstudenti()
        {
            string query = @"Select NrMatricol, Nume, Prenume, CNP from Studenti";

            SqlDataAdapter da = new SqlDataAdapter(query, Conector.ConSir());
            DataSet dp = new DataSet();
            da.Fill(dp, "Studenti");
            dataGridView1.DataSource = dp.Tables["Studenti"].DefaultView;
        }
        private void Studenti_Load(object sender, EventArgs e)
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
                        cbx_ciclu2.Items.Add(value);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }

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
                        cbx_program2.Items.Add(value);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }

        }

        private void btn_adaugaProgram_Click(object sender, EventArgs e)
        {
            if (txt_cnp.Text == "" || txt_datainscriere.Text == "" || txt_initiala.Text == "" || txt_nume.Text == "" || txt_prenume.Text == "" || cbx_ciclu2.Text == "" || cbx_program2.Text == "")
            {
                MessageBox.Show("Nu ati completat toate campurile");
            }
            else
            {
                int idCiclu2 = -1;
                string numecicluinvatamant = cbx_ciclu2.Text;
                using (SqlConnection con = new SqlConnection(Conector.ConSir()))
                {
                    con.Open();

                    string query = "SELECT ID_Ciclu FROM CicluriInvatamant WHERE Nume = @Nume";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Nume", numecicluinvatamant);


                    // Executați interogarea și obțineți ID-ul programului de studiu
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idCiclu2 = Convert.ToInt32(result);
                    }
                }

                int idProgram2 = -1;
                string numeprogram = cbx_program2.Text;
                using (SqlConnection con1 = new SqlConnection(Conector.ConSir()))
                {
                    con1.Open();

                    string query1 = "SELECT id_program FROM ProgrameStudii WHERE nume_program = @Nume";
                    SqlCommand command1 = new SqlCommand(query1, con1);
                    command1.Parameters.AddWithValue("@Nume", numeprogram);


                    // Executați interogarea și obțineți ID-ul programului de studiu
                    object result1 = command1.ExecuteScalar();
                    if (result1 != null && result1 != DBNull.Value)
                    {
                        idProgram2 = Convert.ToInt32(result1);
                    }
                }

                string numestudent = txt_nume.Text;
                string prenumestudent = txt_prenume.Text;
                string initialatatalui = txt_initiala.Text;
                string cnp = txt_cnp.Text;
                string datainscriere = txt_datainscriere.Text;


                // Create an SQL INSERT statement with parameters to prevent SQL injection
                string sqlInsert = "INSERT INTO Studenti VALUES (@Nume, @Prenume, @InitialaTata, @CNP, @DataInscrierii, @IdProgram, @IdCiclu)";
                // Create a SqlCommand object with the INSERT statement and the connection
                using (SqlConnection con = new SqlConnection(Conector.ConSir()))
                {
                    con.Open();
                    // Add parameter values to the SqlCommand object
                    SqlCommand command = new SqlCommand(sqlInsert, con);
                    command.Parameters.AddWithValue("@Nume", numestudent);
                    command.Parameters.AddWithValue("@Prenume", prenumestudent);
                    command.Parameters.AddWithValue("@InitialaTata", initialatatalui);
                    command.Parameters.AddWithValue("@CNP", cnp);
                    command.Parameters.AddWithValue("@DataInscrierii", datainscriere);
                    command.Parameters.AddWithValue("@IdCiclu", idCiclu2);
                    command.Parameters.AddWithValue("@IdProgram", idProgram2);

                    // Execute the SQL command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the INSERT was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student information added to the database successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student information to the database.");
                    }

                }

            }
            Loadstudenti();
        }

        private void btn_stergeProgram_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Iterate over the selected rows and remove them

                // Remove the row from the DataGridView
                var cell = dataGridView1.SelectedCells[0];
                int nrmat = (int)cell.Value;
                string query = @"delete from Studenti where NrMatricol= @NrMatricol";
                using (SqlConnection cnn = new SqlConnection(Conector.ConSir()))
                {

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@NrMatricol", nrmat);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    dataGridView1.Rows.RemoveAt(cell.RowIndex);
                }

                // Refresh the DataGridView display
                dataGridView1.Refresh();
            }
        }
    }
}


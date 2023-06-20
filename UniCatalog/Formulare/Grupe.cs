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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniCatalog.Formulare
{
    public partial class Grupe : Form
    {
        public Grupe()
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
                        cbx_prggr.Items.Add(value);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }

        private void Grupe_Load(object sender, EventArgs e)
        {
            cbx_ML.Items.Add("L");
            cbx_ML.Items.Add("M");

            string query = @"Select NrMatricol, Nume, Prenume, CNP from Studenti";

            SqlDataAdapter da = new SqlDataAdapter(query, Conector.ConSir());
            DataSet dp = new DataSet();
            da.Fill(dp, "Studenti");
            dataGridView1.DataSource = dp.Tables["Studenti"].DefaultView;
        }

        private void btn_generare_Click(object sender, EventArgs e)
        {
            if (cbx_ML.Text == "" || cbx_prggr.Text == "" || txt_an.Text == "" || txt_an.Text == "" || txt_grupe.Text == "")
            {
                MessageBox.Show("Nu ati completat toate campurile");
            }
            else
            {
                string ciclu = cbx_ML.Text;
                int idprogramgr = -1;
                string forma_invatamant = "F";
                string program = cbx_prggr.Text;
                string query2 = "SELECT id_program from ProgrameStudii WHERE nume_program = @Nume";
                int ultim;
                string contor;
                using (SqlConnection con = new SqlConnection(Conector.ConSir()))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(query2, con);
                    command.Parameters.AddWithValue("@Nume", program);


                    // Executați interogarea și obțineți ID-ul programului de studiu
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idprogramgr = Convert.ToInt32(result);
                    }

                    string query3 = "SELECT MAX(IdGrupa) FROM Grupa";
                    command = new SqlCommand(query3, con);

                    ultim = (int)command.ExecuteScalar();
                    contor = Convert.ToString(ultim);
                }

                char lastc = txt_an.Text[txt_an.Text.Length - 1];
                string lastchar = Convert.ToString(lastc);

                int nrgrupe = int.Parse(txt_grupe.Text);
                cbx_grupa.Items.Clear();
                for (int i = 0; i < nrgrupe; i++)
                {
                    string grupa = ciclu + forma_invatamant + idprogramgr + lastchar + contor;
                    cbx_grupa.Items.Add(grupa);
                    int cont = int.Parse(contor);
                    cont++;
                    contor = Convert.ToString(cont);
                }

                string insertQuery = "INSERT INTO Grupa VALUES (@Nume)";
                using (SqlConnection con = new SqlConnection(Conector.ConSir()))
                {

                    con.Open();
                    SqlCommand command = new SqlCommand(insertQuery, con);
                    foreach (var item in cbx_grupa.Items)
                    {
                        string selectedValue = item.ToString();
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Nume", selectedValue);
                        command.ExecuteNonQuery();

                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Conector.ConSir()))
            {
                con.Open();
                string tableName = "Studenti";
                string columnName = "grupa";
                string query = $"UPDATE {tableName} SET {columnName} = @Value";

                using (SqlCommand command = new SqlCommand(query, con))
                {

                    command.Parameters.AddWithValue("@Value", cbx_grupa.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Value updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No rows were updated.");
                    }
                }
            }
            MessageBox.Show("Grupa atribuita!");
        }
    }
}

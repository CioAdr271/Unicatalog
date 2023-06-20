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
    public partial class CadreDidactice : Form
    {
        public CadreDidactice()
        {
            InitializeComponent();
            LoadProfesori();
        }
        private void LoadProfesori()
        {
            string query = @"Select Nume,Prenume from CadreDidactice";

            SqlDataAdapter da = new SqlDataAdapter(query, Conector.ConSir());
            DataSet dp = new DataSet();
            da.Fill(dp, "CadreDidactice");
            dataGridView1.DataSource = dp.Tables["CadreDidactice"].DefaultView;
        }

        private void CadreDidactice_Load(object sender, EventArgs e)
        {
            cbx_post.Items.Add("Asistent universitar");
            cbx_post.Items.Add("Sef lucrari");
            cbx_post.Items.Add("Conferentiar universitar");
            cbx_post.Items.Add("Profesor universitar");
            cbx_post.Items.Add("CDA");

            cbx_titlu.Items.Add("dr.");
            cbx_titlu.Items.Add("dr. ing.");
            cbx_titlu.Items.Add("ing.");

            try
            {
                using (SqlConnection connection = new SqlConnection(Conector.ConSir()))
                {
                    connection.Open();

                    string query = "SELECT nume_disciplina FROM discipline";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string value = reader.GetString(0); // Assuming the column type is string

                        // Add the value to the ComboBox
                        cbx_discipline.Items.Add(value);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message);
            }
        }
        public int GetIdDIsciplina()
        {

            int idDisciplina = -1;
            string numeDisciplina = cbx_discipline.Text;
            using (SqlConnection con = new SqlConnection(Conector.ConSir()))
            {
                con.Open();

                string query = "SELECT cod FROM discipline where nume_disciplina = @Nume";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Nume", numeDisciplina);


                // Executați interogarea și obțineți ID-ul programului de studiu
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    idDisciplina = Convert.ToInt32(result);
                }
            }
            return idDisciplina;

        }
        private void btn_Adauga_Click(object sender, EventArgs e)
        {
            if (txt_numeProf.Text == "" || txt_prenumeProf.Text == "" || cbx_discipline.Text == "" || cbx_post.Text == "" || cbx_titlu.Text == "")
            {
                MessageBox.Show("Nu ati completat toate campurile!");
            }
            else
            {
                Guid guid = Guid.NewGuid();
                string marca = guid.ToString();
                using (SqlConnection connection = new SqlConnection(Conector.ConSir()))
                {

                    string nume = txt_numeProf.Text;
                    string prenume = txt_prenumeProf.Text;
                    string titlu = cbx_titlu.Text;
                    string post = cbx_post.Text;
                    int iddisc = GetIdDIsciplina();
                    connection.Open();

                    string query = "INSERT INTO CadreDidactice VALUES (@marca, @nume, @prenume, @titlu, @post, @disciplina)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@nume", nume);
                    command.Parameters.AddWithValue("@prenume", prenume);
                    command.Parameters.AddWithValue("@titlu", titlu);
                    command.Parameters.AddWithValue("@post", post);
                    command.Parameters.AddWithValue("@disciplina", iddisc);

                    command.ExecuteNonQuery();

                }
            }


            LoadProfesori();
        }

        private void btn_stergeCiclu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {

                var cell = dataGridView1.SelectedCells[0];
                var cell1 = dataGridView1.SelectedCells[1];
                string nume = (string)cell.Value;
                string prenume = (string)cell1.Value;
                string query = @"delete from CadreDidactice where Nume = @Nume AND Prenume = @Prenume";
                using (SqlConnection cnn = new SqlConnection(Conector.ConSir()))
                {

                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Nume", nume);
                        cmd.Parameters.AddWithValue("@Prenume", prenume);
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
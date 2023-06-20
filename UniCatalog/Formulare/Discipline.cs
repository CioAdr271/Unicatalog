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
    public partial class Discipline : Form
    {
        public Discipline()
        {
            InitializeComponent();

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
                    cbx_prog_disc.Items.Add(value);
                }

                reader.Close();
            }

            cbx_an_disc.Items.Add("1");
            cbx_an_disc.Items.Add("2");
            cbx_an_disc.Items.Add("3");
            cbx_an_disc.Items.Add("4");
            cbx_an_disc.Items.Add("5");
            cbx_an_disc.Items.Add("6");
            cbx_sem_disc.Items.Add("1");
            cbx_sem_disc.Items.Add("2");
            cbx_sem_disc.Items.Add("3");
            LoadDiscipline();
        }
        private void LoadDiscipline()
        {
            string query = @"Select nume_disciplina from discipline";

            SqlDataAdapter da = new SqlDataAdapter(query, Conector.ConSir());
            DataSet dp = new DataSet();
            da.Fill(dp, "discipline");
            dgv_discipline.DataSource = dp.Tables["discipline"].DefaultView;
        }

        private void btn_adaugareDisciplinaClick(object sender, EventArgs e)
        {
            if (cbx_an_disc.Text == "" || cbx_prog_disc.Text == "" || cbx_sem_disc.Text == "" || txt_acronimDisciplina.Text == "" || txt_nrCredite.Text == " " || txt_numeDisciplina.Text == "")
            {
                MessageBox.Show("Nu ati completat toate campurile!");
            }
            else
            {
                string numeprogram = cbx_prog_disc.Text;
                int an = int.Parse(cbx_an_disc.Text);
                int semestru = int.Parse(cbx_sem_disc.Text);
                string numedisciplina = txt_numeDisciplina.Text;
                string acronimdisciplina = txt_acronimDisciplina.Text;
                int credite = int.Parse(txt_nrCredite.Text);

                using (SqlConnection con = new SqlConnection(Conector.ConSir()))
                {
                    con.Open();

                    string quernume = "SELECT id_program FROM ProgrameStudii WHERE nume_program = @Nume";
                    SqlCommand commandnume = new SqlCommand(quernume, con);
                    commandnume.Parameters.AddWithValue("@Nume", numeprogram);

                    int idansemestru = -1;
                    object result1 = commandnume.ExecuteScalar();
                    if (result1 != null && result1 != DBNull.Value)
                    {
                        idansemestru = Convert.ToInt32(result1);
                    }

                    string selectQuery = "SELECT idunic FROM an_studiu_semestru WHERE( id_an_studiu= @a AND id_semestru = @semestru)";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                    selectCommand.Parameters.AddWithValue("@a", an);
                    selectCommand.Parameters.AddWithValue("@semestru", semestru);

                    object result = selectCommand.ExecuteScalar();
                    int idunic = Convert.ToInt32(result);

                    string query = "INSERT INTO discipline VALUES (@nume_disciplina, @acronim, @credite, @semestru, @program_studii_id, @semestru_id)";

                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@nume_disciplina", numedisciplina);
                    command.Parameters.AddWithValue("@acronim", acronimdisciplina);
                    command.Parameters.AddWithValue("@credite", credite);
                    command.Parameters.AddWithValue("@semestru", semestru);
                    command.Parameters.AddWithValue("@program_studii_id", idansemestru);
                    command.Parameters.AddWithValue("@semestru_id", idunic);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data.");
                    }
                }

                LoadDiscipline();
            }
        }

    }
}

using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniCatalog.Clase;

namespace UniCatalog.Formulare
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();


        }
        private void Loadstudenti()
        {
            string query = @"Select NrMatricol, Nume, Prenume, CNP from Studenti";

            SqlDataAdapter da = new SqlDataAdapter(query, Conector.ConSir());
            DataSet dp = new DataSet();
            da.Fill(dp, "Studenti");
            dgv_studenti.DataSource = dp.Tables["Studenti"].DefaultView;
        }

        private void Catalog_Load(object sender, EventArgs e)
        {


            using (SqlConnection connection = new SqlConnection(Conector.ConSir()))
            {
                connection.Open();

                string query = "SELECT Nume FROM CadreDidactice";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value = reader.GetString(0); // Assuming the column type is string

                    // Add the value to the ComboBox
                    cbx_profesor.Items.Add(value);
                }

                reader.Close();
            }
            Loadstudenti();
            LOADNOTE();

        }

        private void LOADNOTE()
        {
            string selectQuery = @"
                SELECT s.Nume, s.Prenume, c.Nota, d.nume_disciplina
                FROM Catalog AS c
                INNER JOIN Studenti AS s ON c.IdStudent = s.NrMatricol
                INNER JOIN CadreDidactice AS cd ON c.IdProfesor = cd.MarcaAngajat
                INNER JOIN Discipline AS d ON cd.id_Disciplina = d.cod";

            using (SqlConnection connection = new SqlConnection(Conector.ConSir()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_rezultate.DataSource = dataTable;
                }

                connection.Close();
            }
        }

        private void btn_adaugaSemestru_Click(object sender, EventArgs e)
        {
            if (txt_nota.Text == "" || cbx_profesor.Text == "")
            {
                MessageBox.Show("Nu ati completat toate campurile!");
            }
            else
            {
                int nrmatricol = 0;
                string idProf = null;
                string numeprof = cbx_profesor.Text;
                using (SqlConnection con = new SqlConnection(Conector.ConSir()))
                {
                    con.Open();

                    string query = "SELECT MarcaAngajat FROM CadreDidactice WHERE nume = @Nume";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@Nume", numeprof);


                    // Executați interogarea și obțineți ID-ul programului de studiu
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idProf = Convert.ToString(result);
                    }



                    int nota = int.Parse(txt_nota.Text);
                    DateTime dateTime = DateTime.Now;

                    using (SqlConnection con1 = new SqlConnection(Conector.ConSir()))
                    {
                        con1.Open();


                        if (dgv_studenti.SelectedCells.Count > 0)
                        {
                            var selectedCell = dgv_studenti.SelectedCells[0];
                            nrmatricol = Convert.ToInt32(selectedCell.Value);
                        }

                    }

                    string insertQuery = "INSERT INTO Catalog VALUES(@Nota, @Data, @IdStudent, @IdProfesor)";
                    using (SqlConnection con2 = new SqlConnection(Conector.ConSir()))
                    {
                        con2.Open();
                        SqlCommand command2 = new SqlCommand(insertQuery, con2);
                        command2.Parameters.AddWithValue("@Nota", nota);
                        command2.Parameters.AddWithValue("@Data", dateTime);
                        command2.Parameters.AddWithValue("@IdStudent", nrmatricol);
                        command2.Parameters.AddWithValue("@IdProfesor", idProf);


                        // Execute the SQL command
                        int rowsAffected = command2.ExecuteNonQuery();

                        // Check if the INSERT was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Nota adaugat cu succes!");
                        }
                        else
                        {
                            MessageBox.Show("Eroare la salvarea notei!");
                        }
                    }
                }
               
            }
            LOADNOTE();
        }

        private void btn_REZ_Click(object sender, EventArgs e)
        {

            // Create a new Excel workbook and worksheet
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Data");

            // Get the column headers from the DataGridView and write them to the worksheet
            for (int col = 0; col < dgv_rezultate.Columns.Count; col++)
            {
                worksheet.Cell(1, col + 1).Value = dgv_rezultate.Columns[col].HeaderText;
            }

            // Get the data rows from the DataGridView and write them to the worksheet
            for (int row = 0; row < dgv_rezultate.Rows.Count; row++)
            {
                for (int col = 0; col < dgv_rezultate.Columns.Count; col++)
                {
                    var value = dgv_rezultate.Rows[row].Cells[col].Value;
                    worksheet.Cell(row + 2, col + 1).Value = value != null ? value.ToString() : "";
                }
            }

            // Save the workbook to a file
            string fileName = Path.Combine(ConfigurationManager.AppSettings["GradesPath"], $"Data-{DateTime.Today.ToString("yyyy-MM-dd")}.xlsx");
            workbook.SaveAs(fileName);

            MessageBox.Show("Data exported to Excel successfully!");
        }

        private void btn_medie_Click(object sender, EventArgs e)
        {
            int nrmatricol = 0;
            List<int> note = new List<int>();
            if (dgv_studenti.SelectedCells.Count > 0)
            {
                var selectedCell = dgv_studenti.SelectedCells[0];
                nrmatricol = Convert.ToInt32(selectedCell.Value);
            }

            const string query = "SELECT Nota from Catalog WHERE IdStudent=@idStudent";

            using (SqlConnection con = new SqlConnection(Conector.ConSir()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idStudent", nrmatricol);
                    con.Open();
                    using(SqlDataReader  reader = cmd.ExecuteReader()) 
                    {
                        while(reader.Read()) 
                        {
                            note.Add(reader.GetInt32(0));
                        }
                    }
                }
            }

            foreach(var item in note)
            {
                if(item < 5)
                {
                    MessageBox.Show("Elevul selectat este restantier, nu i se poate calcula media!", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show($"Elevul selectat are media: {note.Sum() / note.Count}", "Medie", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
    }
}



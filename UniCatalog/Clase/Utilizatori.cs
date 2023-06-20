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

namespace UniCatalog.Clase
{
    public partial class Utilizatori : Form
    {
        public Utilizatori()
        {
            InitializeComponent();
        }

        private void Utilizatori_Load(object sender, EventArgs e)
        {
            string query = @"Select Admin, Parola, functia from Admin";

            SqlDataAdapter da = new SqlDataAdapter(query, Conector.ConSir());
            DataSet dp = new DataSet();
            da.Fill(dp, "Admin");
            dataGridView1.DataSource = dp.Tables["Admin"].DefaultView;
        }

        private void btn_adaugaUtiliz_Click(object sender, EventArgs e)
        {
            if (txt_functia.Text == "" || txt_parola.Text == "" || txt_username.Text == "")
            {
                MessageBox.Show("Nu ati completat toate campurile!");
            }
            else
            {
                string username = txt_username.Text;
                string parola = txt_parola.Text;
                string functia = txt_functia.Text;

                string query = "INSERT INTO admin VALUES (@Username, @Parola, @Functia)";
                using (SqlConnection connection = new SqlConnection(Conector.ConSir()))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Parola", parola);
                        command.Parameters.AddWithValue("@Functia", functia);

                        connection.Open();


                        command.ExecuteNonQuery();

                        connection.Close();
                    }
                }
                MessageBox.Show("Utilizator adaugat cu succes!");

                string query2 = @"Select Admin, Parola, functia from Admin";

                SqlDataAdapter da = new SqlDataAdapter(query2, Conector.ConSir());
                DataSet dp = new DataSet();
                da.Fill(dp, "Admin");
                dataGridView1.DataSource = dp.Tables["Admin"].DefaultView;
            }
        }

        private void btn_stergeUtiliz_Click(object sender, EventArgs e)
        {
            string selectedCellValue = dataGridView1.SelectedCells[0].Value.ToString();


            string query = "DELETE FROM Admin WHERE Admin= @SelectedCellValue";

            using (SqlConnection connection = new SqlConnection(Conector.ConSir()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@SelectedCellValue", selectedCellValue);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            MessageBox.Show("Utilizator sters cu succes!");
            dataGridView1.Refresh();
        }
    }
}

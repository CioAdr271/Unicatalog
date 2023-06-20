using Microsoft.Data.SqlClient;
using System.Drawing;
using UniCatalog.Formulare;
using UniCatalog.Clase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UniCatalog
{
    public partial class Login : Form
    {
        public delegate void LoginSuccess(string functie);
        public event LoginSuccess LoginEvent;
        public Login()
        {
            InitializeComponent();
        }

  


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btn_ShowPsw(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(Conector.ConSir());
            
            string username = txtUsername.Text; 
            string password = txtPassword.Text;

            try
            {
                cnn.Open();
                string query2 = "SELECT functia FROM Admin WHERE Admin = @Admin AND Parola = @Parola";
                SqlCommand command2 = new SqlCommand(query2, cnn);
                command2.Parameters.AddWithValue("@Admin", username);
                command2.Parameters.AddWithValue("@Parola", password);
                object functia = command2.ExecuteScalar();
                string func = functia != null ? functia.ToString() : string.Empty;

               

                // Interogarea pentru verificarea username-ului și parolei
                string query = "SELECT COUNT(*) FROM Admin WHERE Admin = @Admin AND Parola = @Parola";
                SqlCommand command = new SqlCommand(query, cnn);
                command.Parameters.AddWithValue("@Admin", username);
                command.Parameters.AddWithValue("@Parola", password);


                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    // Alte acțiuni după autentificare
                    this.Hide();
                    Meniu menu = new Meniu(this);
                    LoginEvent?.Invoke(func);
                    menu.Show();
                }
                else
                {
                    // Autentificarea a eșuat
                    MessageBox.Show("Nume de utilizator sau parolă incorecte!");
                }
            }
            catch (Exception ex)
            {
                // Tratați orice excepție care poate apărea în timpul conexiunii sau interogării
                MessageBox.Show("Eroare: " + ex.Message);
            }
            cnn.Close();


        }
    }
}
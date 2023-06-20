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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UniCatalog.Formulare
{
    public partial class Meniu : Form
    {
        public Meniu(Login login)
        {
            InitializeComponent();
            login.LoginEvent += Handle_LoggedIn;
        }

        private void Handle_LoggedIn(string functie)
        {
            if (functie == "secretar")
            {
                btn_utilizatori.Enabled = false;
            }
            else if(functie == "profesor")
            {
                btn_utilizatori.Enabled = false;
                btn_Studenti.Enabled = false;
                btn_CicluInvatamant.Enabled = false;
                btn_ProgrameStudii.Enabled = false; 
                btn_AniStudii.Enabled = false;
                btn_Discipline.Enabled = false;
                btn_CadreDid.Enabled = false;
                btn_Grupe.Enabled = false;
            }
            
        }

        public string StringFromForm1 { get; set; }
        
        static   private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_Discipline_Click(object sender, EventArgs e)
        {
            Discipline discipline = new Discipline();
            discipline.Show();
        }

        private void btn_Cicluri_Click(object sender, EventArgs e)
        {
            Cicluri discipline = new Cicluri();
            discipline.Show();
        }

        private void btn_programestudiiClick(object sender, EventArgs e)
        {
            ProgrameStudii pro = new ProgrameStudii();
            pro.Show();
        }

        private void btn_AniStudiiClick(object sender, EventArgs e)
        {
            AniDeStudii ani = new AniDeStudii();
            ani.Show();
        }

        private void btn_Studenti_Click(object sender, EventArgs e)
        {
            Studenti stud = new Studenti();
            stud.Show();
        }

        private void btn_Grupe_Click(object sender, EventArgs e)
        {
            Grupe grupe = new Grupe();
            grupe.Show();
        }

        private void btn_CadreDid_Click(object sender, EventArgs e)
        {
            CadreDidactice cadre = new CadreDidactice();
            cadre.Show();
        }

        private void btn_Cataloage_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
        }

        private void btn_utilizatori_Click(object sender, EventArgs e)
        {
            Utilizatori utilizatori = new Utilizatori();
            utilizatori.Show();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
        }
    }

}

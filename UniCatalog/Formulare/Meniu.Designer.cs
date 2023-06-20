using System.ComponentModel;

namespace UniCatalog.Formulare
{
    partial class Meniu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Meniu));
            dateTimePicker1 = new DateTimePicker();
            btn_CicluInvatamant = new Button();
            btn_ProgrameStudii = new Button();
            btn_AniStudii = new Button();
            btn_Discipline = new Button();
            btn_Studenti = new Button();
            btn_LogOUT = new Button();
            btn_Grupe = new Button();
            btn_CadreDid = new Button();
            btn_Cataloage = new Button();
            btn_utilizatori = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dateTimePicker1.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Italic, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(1, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 34);
            dateTimePicker1.TabIndex = 0;
            // 
            // btn_CicluInvatamant
            // 
            btn_CicluInvatamant.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CicluInvatamant.Location = new Point(75, 94);
            btn_CicluInvatamant.Name = "btn_CicluInvatamant";
            btn_CicluInvatamant.Size = new Size(328, 49);
            btn_CicluInvatamant.TabIndex = 1;
            btn_CicluInvatamant.Text = "Cicluri de învățământ";
            btn_CicluInvatamant.UseVisualStyleBackColor = true;
            btn_CicluInvatamant.Click += btn_Cicluri_Click;
            // 
            // btn_ProgrameStudii
            // 
            btn_ProgrameStudii.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ProgrameStudii.Location = new Point(75, 189);
            btn_ProgrameStudii.Name = "btn_ProgrameStudii";
            btn_ProgrameStudii.Size = new Size(328, 49);
            btn_ProgrameStudii.TabIndex = 2;
            btn_ProgrameStudii.Text = "Programe de studii";
            btn_ProgrameStudii.UseVisualStyleBackColor = true;
            btn_ProgrameStudii.Click += btn_programestudiiClick;
            // 
            // btn_AniStudii
            // 
            btn_AniStudii.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AniStudii.Location = new Point(75, 275);
            btn_AniStudii.Name = "btn_AniStudii";
            btn_AniStudii.Size = new Size(328, 49);
            btn_AniStudii.TabIndex = 3;
            btn_AniStudii.Text = "Ani de studii";
            btn_AniStudii.UseVisualStyleBackColor = true;
            btn_AniStudii.Click += btn_AniStudiiClick;
            // 
            // btn_Discipline
            // 
            btn_Discipline.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Discipline.Location = new Point(75, 351);
            btn_Discipline.Name = "btn_Discipline";
            btn_Discipline.Size = new Size(328, 49);
            btn_Discipline.TabIndex = 4;
            btn_Discipline.Text = "Discipline";
            btn_Discipline.UseVisualStyleBackColor = true;
            btn_Discipline.Click += btn_Discipline_Click;
            // 
            // btn_Studenti
            // 
            btn_Studenti.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Studenti.Location = new Point(480, 94);
            btn_Studenti.Name = "btn_Studenti";
            btn_Studenti.Size = new Size(328, 49);
            btn_Studenti.TabIndex = 5;
            btn_Studenti.Text = "Studenti";
            btn_Studenti.UseVisualStyleBackColor = true;
            btn_Studenti.Click += btn_Studenti_Click;
            // 
            // btn_LogOUT
            // 
            btn_LogOUT.AutoSize = true;
            btn_LogOUT.BackColor = Color.LightCyan;
            btn_LogOUT.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LogOUT.Image = (Image)resources.GetObject("btn_LogOUT.Image");
            btn_LogOUT.ImageAlign = ContentAlignment.TopCenter;
            btn_LogOUT.Location = new Point(811, 2);
            btn_LogOUT.Margin = new Padding(0);
            btn_LogOUT.Name = "btn_LogOUT";
            btn_LogOUT.Size = new Size(96, 100);
            btn_LogOUT.TabIndex = 6;
            btn_LogOUT.TabStop = false;
            btn_LogOUT.Text = "\r\n\r\n\r\nLog out";
            btn_LogOUT.UseVisualStyleBackColor = false;
            btn_LogOUT.Click += btnLogOut_Click;
            // 
            // btn_Grupe
            // 
            btn_Grupe.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Grupe.Location = new Point(480, 189);
            btn_Grupe.Name = "btn_Grupe";
            btn_Grupe.Size = new Size(328, 49);
            btn_Grupe.TabIndex = 7;
            btn_Grupe.Text = "Grupe";
            btn_Grupe.UseVisualStyleBackColor = true;
            btn_Grupe.Click += btn_Grupe_Click;
            // 
            // btn_CadreDid
            // 
            btn_CadreDid.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CadreDid.Location = new Point(480, 275);
            btn_CadreDid.Name = "btn_CadreDid";
            btn_CadreDid.Size = new Size(328, 49);
            btn_CadreDid.TabIndex = 9;
            btn_CadreDid.Text = "Cadre didactice";
            btn_CadreDid.UseVisualStyleBackColor = true;
            btn_CadreDid.Click += btn_CadreDid_Click;
            // 
            // btn_Cataloage
            // 
            btn_Cataloage.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cataloage.Location = new Point(480, 351);
            btn_Cataloage.Name = "btn_Cataloage";
            btn_Cataloage.Size = new Size(328, 49);
            btn_Cataloage.TabIndex = 10;
            btn_Cataloage.Text = "Cataloage";
            btn_Cataloage.UseVisualStyleBackColor = true;
            btn_Cataloage.Click += btn_Cataloage_Click;
            // 
            // btn_utilizatori
            // 
            btn_utilizatori.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_utilizatori.Location = new Point(285, 442);
            btn_utilizatori.Name = "btn_utilizatori";
            btn_utilizatori.Size = new Size(328, 49);
            btn_utilizatori.TabIndex = 11;
            btn_utilizatori.Text = "Utilizatori";
            btn_utilizatori.UseVisualStyleBackColor = true;
            btn_utilizatori.Click += btn_utilizatori_Click;
            // 
            // Meniu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightCyan;
            ClientSize = new Size(906, 523);
            Controls.Add(btn_utilizatori);
            Controls.Add(btn_Cataloage);
            Controls.Add(btn_CadreDid);
            Controls.Add(btn_Grupe);
            Controls.Add(btn_LogOUT);
            Controls.Add(btn_Studenti);
            Controls.Add(btn_Discipline);
            Controls.Add(btn_AniStudii);
            Controls.Add(btn_ProgrameStudii);
            Controls.Add(btn_CicluInvatamant);
            Controls.Add(dateTimePicker1);
            Name = "Meniu";
            Text = "Meniu";
            FormClosing += MainForm_FormClosing;
            Load += Meniu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btn_CicluInvatamant;
        private Button btn_ProgrameStudii;
        private Button btn_AniStudii;
        private Button btn_Discipline;
        private Button btn_Studenti;
        private Button btn_LogOUT;
        private Button btn_Grupe;
        private Button btn_CadreDid;
        private Button btn_Cataloage;
        private Button btn_utilizatori;
    }
}
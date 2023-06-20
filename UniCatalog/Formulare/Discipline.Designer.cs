namespace UniCatalog.Formulare
{
    partial class Discipline
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
            cbx_prog_disc = new ComboBox();
            lblsprog = new Label();
            cbx_an_disc = new ComboBox();
            lblsa = new Label();
            cbx_sem_disc = new ComboBox();
            lblss = new Label();
            txt_numeDisciplina = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_acronimDisciplina = new TextBox();
            txt_nrCredite = new TextBox();
            btn_stergeSemestru = new Button();
            btn_adaugaSemestru = new Button();
            dgv_discipline = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_discipline).BeginInit();
            SuspendLayout();
            // 
            // cbx_prog_disc
            // 
            cbx_prog_disc.BackColor = Color.White;
            cbx_prog_disc.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_prog_disc.FormattingEnabled = true;
            cbx_prog_disc.Location = new Point(668, 44);
            cbx_prog_disc.Name = "cbx_prog_disc";
            cbx_prog_disc.Size = new Size(255, 30);
            cbx_prog_disc.TabIndex = 5;
            // 
            // lblsprog
            // 
            lblsprog.AutoSize = true;
            lblsprog.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblsprog.Location = new Point(364, 52);
            lblsprog.Name = "lblsprog";
            lblsprog.Size = new Size(298, 22);
            lblsprog.TabIndex = 4;
            lblsprog.Text = "Selectati programul de studiu dorit:";
            // 
            // cbx_an_disc
            // 
            cbx_an_disc.BackColor = Color.White;
            cbx_an_disc.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_an_disc.FormattingEnabled = true;
            cbx_an_disc.Location = new Point(668, 88);
            cbx_an_disc.Name = "cbx_an_disc";
            cbx_an_disc.Size = new Size(255, 30);
            cbx_an_disc.TabIndex = 7;
            // 
            // lblsa
            // 
            lblsa.AutoSize = true;
            lblsa.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblsa.Location = new Point(364, 96);
            lblsa.Name = "lblsa";
            lblsa.Size = new Size(169, 22);
            lblsa.TabIndex = 6;
            lblsa.Text = "Selectati anul dorit:";
            // 
            // cbx_sem_disc
            // 
            cbx_sem_disc.BackColor = Color.White;
            cbx_sem_disc.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_sem_disc.FormattingEnabled = true;
            cbx_sem_disc.Location = new Point(668, 137);
            cbx_sem_disc.Name = "cbx_sem_disc";
            cbx_sem_disc.Size = new Size(255, 30);
            cbx_sem_disc.TabIndex = 9;
            // 
            // lblss
            // 
            lblss.AutoSize = true;
            lblss.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblss.Location = new Point(364, 145);
            lblss.Name = "lblss";
            lblss.Size = new Size(212, 22);
            lblss.TabIndex = 8;
            lblss.Text = "Selectati semestrul dorit:";
            // 
            // txt_numeDisciplina
            // 
            txt_numeDisciplina.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_numeDisciplina.Location = new Point(668, 195);
            txt_numeDisciplina.Name = "txt_numeDisciplina";
            txt_numeDisciplina.Size = new Size(255, 29);
            txt_numeDisciplina.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(364, 202);
            label1.Name = "label1";
            label1.Size = new Size(254, 22);
            label1.TabIndex = 11;
            label1.Text = "Introduceti numele disciplinei:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(364, 243);
            label2.Name = "label2";
            label2.Size = new Size(278, 22);
            label2.TabIndex = 12;
            label2.Text = "Introduceti acronimul disciplinei:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(364, 281);
            label3.Name = "label3";
            label3.Size = new Size(369, 22);
            label3.TabIndex = 13;
            label3.Text = "Introduceti numarul de credite al disciplinei:";
            // 
            // txt_acronimDisciplina
            // 
            txt_acronimDisciplina.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_acronimDisciplina.Location = new Point(668, 236);
            txt_acronimDisciplina.Name = "txt_acronimDisciplina";
            txt_acronimDisciplina.Size = new Size(255, 29);
            txt_acronimDisciplina.TabIndex = 14;
            // 
            // txt_nrCredite
            // 
            txt_nrCredite.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_nrCredite.Location = new Point(739, 274);
            txt_nrCredite.Name = "txt_nrCredite";
            txt_nrCredite.Size = new Size(184, 29);
            txt_nrCredite.TabIndex = 15;
            // 
            // btn_stergeSemestru
            // 
            btn_stergeSemestru.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stergeSemestru.ForeColor = SystemColors.ControlText;
            btn_stergeSemestru.Location = new Point(774, 325);
            btn_stergeSemestru.Name = "btn_stergeSemestru";
            btn_stergeSemestru.Size = new Size(197, 67);
            btn_stergeSemestru.TabIndex = 17;
            btn_stergeSemestru.Text = "Stergere";
            btn_stergeSemestru.UseVisualStyleBackColor = true;
            // 
            // btn_adaugaSemestru
            // 
            btn_adaugaSemestru.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adaugaSemestru.ForeColor = SystemColors.ControlText;
            btn_adaugaSemestru.Location = new Point(483, 325);
            btn_adaugaSemestru.Name = "btn_adaugaSemestru";
            btn_adaugaSemestru.Size = new Size(197, 67);
            btn_adaugaSemestru.TabIndex = 16;
            btn_adaugaSemestru.Text = "Adaugare";
            btn_adaugaSemestru.UseVisualStyleBackColor = true;
            btn_adaugaSemestru.Click += btn_adaugareDisciplinaClick;
            // 
            // dgv_discipline
            // 
            dgv_discipline.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_discipline.BackgroundColor = Color.MediumPurple;
            dgv_discipline.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_discipline.Location = new Point(12, 44);
            dgv_discipline.Name = "dgv_discipline";
            dgv_discipline.RowTemplate.Height = 25;
            dgv_discipline.Size = new Size(346, 362);
            dgv_discipline.TabIndex = 18;
            // 
            // Discipline
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1005, 450);
            Controls.Add(dgv_discipline);
            Controls.Add(btn_stergeSemestru);
            Controls.Add(btn_adaugaSemestru);
            Controls.Add(txt_nrCredite);
            Controls.Add(txt_acronimDisciplina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_numeDisciplina);
            Controls.Add(cbx_sem_disc);
            Controls.Add(lblss);
            Controls.Add(cbx_an_disc);
            Controls.Add(lblsa);
            Controls.Add(cbx_prog_disc);
            Controls.Add(lblsprog);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Discipline";
            Text = "Discipline";
            ((System.ComponentModel.ISupportInitialize)dgv_discipline).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_prog_disc;
        private Label lblsprog;
        private ComboBox cbx_an_disc;
        private Label lblsa;
        private ComboBox cbx_sem_disc;
        private Label lblss;
        private TextBox txt_numeDisciplina;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_acronimDisciplina;
        private TextBox txt_nrCredite;
        private Button btn_stergeSemestru;
        private Button btn_adaugaSemestru;
        private DataGridView dgv_discipline;
    }
}
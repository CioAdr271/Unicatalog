namespace UniCatalog.Formulare
{
    partial class Studenti
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
            lblsprog = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_datainscriere = new TextBox();
            cbx_ciclu2 = new ComboBox();
            cbx_program2 = new ComboBox();
            txt_cnp = new TextBox();
            txt_initiala = new TextBox();
            txt_prenume = new TextBox();
            txt_nume = new TextBox();
            btn_stergeProgram = new Button();
            btn_adaugaProgram = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblsprog
            // 
            lblsprog.AutoSize = true;
            lblsprog.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblsprog.Location = new Point(449, 103);
            lblsprog.Name = "lblsprog";
            lblsprog.Size = new Size(63, 22);
            lblsprog.TabIndex = 5;
            lblsprog.Text = "Nume:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(449, 146);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 6;
            label1.Text = "Prenume:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(449, 189);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 7;
            label2.Text = "Initiala tatalui:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(408, 446);
            dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(449, 230);
            label3.Name = "label3";
            label3.Size = new Size(55, 22);
            label3.TabIndex = 9;
            label3.Text = "CNP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(449, 274);
            label4.Name = "label4";
            label4.Size = new Size(132, 22);
            label4.TabIndex = 10;
            label4.Text = "Data inscrierii:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(449, 319);
            label5.Name = "label5";
            label5.Size = new Size(183, 22);
            label5.TabIndex = 11;
            label5.Text = "Ciclul de invatamant:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(449, 358);
            label6.Name = "label6";
            label6.Size = new Size(161, 22);
            label6.TabIndex = 12;
            label6.Text = "Program de studii:";
            // 
            // txt_datainscriere
            // 
            txt_datainscriere.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_datainscriere.Location = new Point(662, 267);
            txt_datainscriere.Name = "txt_datainscriere";
            txt_datainscriere.Size = new Size(300, 29);
            txt_datainscriere.TabIndex = 14;
            // 
            // cbx_ciclu2
            // 
            cbx_ciclu2.BackColor = Color.White;
            cbx_ciclu2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_ciclu2.FormattingEnabled = true;
            cbx_ciclu2.Location = new Point(662, 311);
            cbx_ciclu2.Name = "cbx_ciclu2";
            cbx_ciclu2.Size = new Size(300, 30);
            cbx_ciclu2.TabIndex = 13;
            // 
            // cbx_program2
            // 
            cbx_program2.BackColor = Color.White;
            cbx_program2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_program2.FormattingEnabled = true;
            cbx_program2.Location = new Point(662, 350);
            cbx_program2.Name = "cbx_program2";
            cbx_program2.Size = new Size(300, 30);
            cbx_program2.TabIndex = 15;
            // 
            // txt_cnp
            // 
            txt_cnp.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_cnp.Location = new Point(662, 228);
            txt_cnp.Name = "txt_cnp";
            txt_cnp.Size = new Size(300, 29);
            txt_cnp.TabIndex = 16;
            // 
            // txt_initiala
            // 
            txt_initiala.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_initiala.Location = new Point(662, 187);
            txt_initiala.Name = "txt_initiala";
            txt_initiala.Size = new Size(300, 29);
            txt_initiala.TabIndex = 17;
            // 
            // txt_prenume
            // 
            txt_prenume.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_prenume.Location = new Point(662, 144);
            txt_prenume.Name = "txt_prenume";
            txt_prenume.Size = new Size(300, 29);
            txt_prenume.TabIndex = 18;
            // 
            // txt_nume
            // 
            txt_nume.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_nume.Location = new Point(662, 96);
            txt_nume.Name = "txt_nume";
            txt_nume.Size = new Size(300, 29);
            txt_nume.TabIndex = 19;
            // 
            // btn_stergeProgram
            // 
            btn_stergeProgram.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stergeProgram.ForeColor = SystemColors.ControlText;
            btn_stergeProgram.Location = new Point(733, 405);
            btn_stergeProgram.Name = "btn_stergeProgram";
            btn_stergeProgram.Size = new Size(200, 67);
            btn_stergeProgram.TabIndex = 21;
            btn_stergeProgram.Text = "Stergere";
            btn_stergeProgram.UseVisualStyleBackColor = true;
            btn_stergeProgram.Click += btn_stergeProgram_Click;
            // 
            // btn_adaugaProgram
            // 
            btn_adaugaProgram.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adaugaProgram.ForeColor = SystemColors.ControlText;
            btn_adaugaProgram.Location = new Point(500, 405);
            btn_adaugaProgram.Name = "btn_adaugaProgram";
            btn_adaugaProgram.Size = new Size(200, 67);
            btn_adaugaProgram.TabIndex = 20;
            btn_adaugaProgram.Text = "Adaugare";
            btn_adaugaProgram.UseVisualStyleBackColor = true;
            btn_adaugaProgram.Click += btn_adaugaProgram_Click;
            // 
            // Studenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1005, 511);
            Controls.Add(btn_stergeProgram);
            Controls.Add(btn_adaugaProgram);
            Controls.Add(txt_nume);
            Controls.Add(txt_prenume);
            Controls.Add(txt_initiala);
            Controls.Add(txt_cnp);
            Controls.Add(cbx_program2);
            Controls.Add(txt_datainscriere);
            Controls.Add(cbx_ciclu2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblsprog);
            Name = "Studenti";
            Text = "Studenti";
            Load += Studenti_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsprog;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_datainscriere;
        private ComboBox cbx_ciclu2;
        private ComboBox cbx_program2;
        private TextBox txt_cnp;
        private TextBox txt_initiala;
        private TextBox txt_prenume;
        private TextBox txt_nume;
        private Button btn_stergeProgram;
        private Button btn_adaugaProgram;
    }
}
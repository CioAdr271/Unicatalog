namespace UniCatalog.Formulare
{
    partial class Catalog
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
            lblinfo2 = new Label();
            txt_nota = new TextBox();
            cbx_profesor = new ComboBox();
            label4 = new Label();
            btn_adaugaSemestru = new Button();
            label2 = new Label();
            dgv_studenti = new DataGridView();
            btn_REZ = new Button();
            dgv_rezultate = new DataGridView();
            label1 = new Label();
            btn_medie = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_studenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_rezultate).BeginInit();
            SuspendLayout();
            // 
            // lblinfo2
            // 
            lblinfo2.AutoSize = true;
            lblinfo2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblinfo2.Location = new Point(29, 26);
            lblinfo2.Name = "lblinfo2";
            lblinfo2.Size = new Size(59, 24);
            lblinfo2.TabIndex = 9;
            lblinfo2.Text = "Nota:";
            // 
            // txt_nota
            // 
            txt_nota.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_nota.Location = new Point(162, 21);
            txt_nota.Name = "txt_nota";
            txt_nota.Size = new Size(247, 29);
            txt_nota.TabIndex = 8;
            // 
            // cbx_profesor
            // 
            cbx_profesor.BackColor = Color.White;
            cbx_profesor.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_profesor.FormattingEnabled = true;
            cbx_profesor.Location = new Point(162, 64);
            cbx_profesor.Name = "cbx_profesor";
            cbx_profesor.Size = new Size(247, 30);
            cbx_profesor.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(29, 65);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 16;
            label4.Text = "Profesor:";
            // 
            // btn_adaugaSemestru
            // 
            btn_adaugaSemestru.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adaugaSemestru.ForeColor = SystemColors.ControlText;
            btn_adaugaSemestru.Location = new Point(465, 407);
            btn_adaugaSemestru.Name = "btn_adaugaSemestru";
            btn_adaugaSemestru.Size = new Size(197, 67);
            btn_adaugaSemestru.TabIndex = 17;
            btn_adaugaSemestru.Text = "Adauga nota";
            btn_adaugaSemestru.UseVisualStyleBackColor = true;
            btn_adaugaSemestru.Click += btn_adaugaSemestru_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(29, 107);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 19;
            label2.Text = "Student:";
            // 
            // dgv_studenti
            // 
            dgv_studenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_studenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_studenti.Location = new Point(162, 107);
            dgv_studenti.Name = "dgv_studenti";
            dgv_studenti.RowTemplate.Height = 25;
            dgv_studenti.Size = new Size(247, 272);
            dgv_studenti.TabIndex = 21;
            // 
            // btn_REZ
            // 
            btn_REZ.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_REZ.ForeColor = SystemColors.ControlText;
            btn_REZ.Location = new Point(749, 407);
            btn_REZ.Name = "btn_REZ";
            btn_REZ.Size = new Size(197, 67);
            btn_REZ.TabIndex = 22;
            btn_REZ.Text = "Raport";
            btn_REZ.UseVisualStyleBackColor = true;
            btn_REZ.Click += btn_REZ_Click;
            // 
            // dgv_rezultate
            // 
            dgv_rezultate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_rezultate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_rezultate.Location = new Point(448, 107);
            dgv_rezultate.Name = "dgv_rezultate";
            dgv_rezultate.RowTemplate.Height = 25;
            dgv_rezultate.Size = new Size(520, 272);
            dgv_rezultate.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(448, 65);
            label1.Name = "label1";
            label1.Size = new Size(144, 24);
            label1.TabIndex = 24;
            label1.Text = "Note obtionute:";
            // 
            // btn_medie
            // 
            btn_medie.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_medie.ForeColor = SystemColors.ControlText;
            btn_medie.Location = new Point(162, 407);
            btn_medie.Name = "btn_medie";
            btn_medie.Size = new Size(247, 67);
            btn_medie.TabIndex = 25;
            btn_medie.Text = "Calculeaza media";
            btn_medie.UseVisualStyleBackColor = true;
            btn_medie.Click += btn_medie_Click;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 516);
            Controls.Add(btn_medie);
            Controls.Add(label1);
            Controls.Add(dgv_rezultate);
            Controls.Add(btn_REZ);
            Controls.Add(dgv_studenti);
            Controls.Add(label2);
            Controls.Add(btn_adaugaSemestru);
            Controls.Add(label4);
            Controls.Add(cbx_profesor);
            Controls.Add(lblinfo2);
            Controls.Add(txt_nota);
            Name = "Catalog";
            Text = " ";
            Load += Catalog_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_studenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_rezultate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblinfo2;
        private TextBox txt_nota;
        private ComboBox cbx_profesor;
        private Label label4;
        private Button btn_stergeSemestru;
        private Button btn_adaugaSemestru;
        private Label label2;
        private DataGridView dgv_studenti;
        private Button btn_REZ;
        private DataGridView dgv_rezultate;
        private Label label1;
        private Button btn_medie;
    }
}
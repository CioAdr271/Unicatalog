namespace UniCatalog.Formulare
{
    partial class AniDeStudii
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
            cbx_program = new ComboBox();
            lblselectare = new Label();
            dgv_an_semestru = new DataGridView();
            lbl_an = new Label();
            label2 = new Label();
            btn_stergeSemestru = new Button();
            btn_adaugaSemestru = new Button();
            cbx_an = new ComboBox();
            cbx_semestru = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_an_semestru).BeginInit();
            SuspendLayout();
            // 
            // cbx_program
            // 
            cbx_program.BackColor = Color.White;
            cbx_program.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_program.FormattingEnabled = true;
            cbx_program.Location = new Point(340, 24);
            cbx_program.Name = "cbx_program";
            cbx_program.Size = new Size(255, 30);
            cbx_program.TabIndex = 3;
            // 
            // lblselectare
            // 
            lblselectare.AutoSize = true;
            lblselectare.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblselectare.Location = new Point(36, 32);
            lblselectare.Name = "lblselectare";
            lblselectare.Size = new Size(298, 22);
            lblselectare.TabIndex = 2;
            lblselectare.Text = "Selectati programul de studiu dorit:";
            // 
            // dgv_an_semestru
            // 
            dgv_an_semestru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_an_semestru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_an_semestru.Location = new Point(36, 83);
            dgv_an_semestru.Name = "dgv_an_semestru";
            dgv_an_semestru.RowTemplate.Height = 25;
            dgv_an_semestru.Size = new Size(381, 325);
            dgv_an_semestru.TabIndex = 4;
            // 
            // lbl_an
            // 
            lbl_an.AutoSize = true;
            lbl_an.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_an.Location = new Point(452, 98);
            lbl_an.Name = "lbl_an";
            lbl_an.Size = new Size(38, 22);
            lbl_an.TabIndex = 6;
            lbl_an.Text = "An:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(452, 159);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 7;
            label2.Text = "Semestru:\r\n";
            // 
            // btn_stergeSemestru
            // 
            btn_stergeSemestru.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stergeSemestru.ForeColor = SystemColors.ControlText;
            btn_stergeSemestru.Location = new Point(496, 324);
            btn_stergeSemestru.Name = "btn_stergeSemestru";
            btn_stergeSemestru.Size = new Size(197, 67);
            btn_stergeSemestru.TabIndex = 10;
            btn_stergeSemestru.Text = "Stergere";
            btn_stergeSemestru.UseVisualStyleBackColor = true;
            btn_stergeSemestru.Click += btn_stergeSemestru_Click;
            // 
            // btn_adaugaSemestru
            // 
            btn_adaugaSemestru.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adaugaSemestru.ForeColor = SystemColors.ControlText;
            btn_adaugaSemestru.Location = new Point(496, 227);
            btn_adaugaSemestru.Name = "btn_adaugaSemestru";
            btn_adaugaSemestru.Size = new Size(197, 67);
            btn_adaugaSemestru.TabIndex = 9;
            btn_adaugaSemestru.Text = "Adaugare";
            btn_adaugaSemestru.UseVisualStyleBackColor = true;
            btn_adaugaSemestru.Click += btn_adaugaSemestru_Click;
            // 
            // cbx_an
            // 
            cbx_an.BackColor = Color.White;
            cbx_an.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_an.FormattingEnabled = true;
            cbx_an.Location = new Point(496, 95);
            cbx_an.Name = "cbx_an";
            cbx_an.Size = new Size(192, 30);
            cbx_an.TabIndex = 11;
            // 
            // cbx_semestru
            // 
            cbx_semestru.BackColor = Color.White;
            cbx_semestru.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_semestru.FormattingEnabled = true;
            cbx_semestru.Location = new Point(549, 151);
            cbx_semestru.Name = "cbx_semestru";
            cbx_semestru.Size = new Size(192, 30);
            cbx_semestru.TabIndex = 14;
            // 
            // AniDeStudii
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(cbx_semestru);
            Controls.Add(cbx_an);
            Controls.Add(btn_stergeSemestru);
            Controls.Add(btn_adaugaSemestru);
            Controls.Add(label2);
            Controls.Add(lbl_an);
            Controls.Add(dgv_an_semestru);
            Controls.Add(cbx_program);
            Controls.Add(lblselectare);
            ForeColor = SystemColors.ControlText;
            Name = "AniDeStudii";
            Text = "Form1";
            Load += AniDeStudii_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_an_semestru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_programestudii;
        private Label lblselectare;
        private ComboBox cbx_program;
        private DataGridView dataGridView1;
        private Label lbl_an;
        private Label label2;
        private Button btn_stergeSemestru;
        private Button btn_adaugaSemestru;
        private ComboBox cbx_an;
        private ComboBox cbx_semestru;
        private DataGridView gdv_an_semestru;
        private DataGridView dgv_an_semestru;
    }
}
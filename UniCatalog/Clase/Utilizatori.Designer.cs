namespace UniCatalog.Clase
{
    partial class Utilizatori
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
            txt_username = new TextBox();
            label1 = new Label();
            txt_parola = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txt_functia = new TextBox();
            btn_stergeUtiliz = new Button();
            btn_adaugaUtiliz = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblinfo2
            // 
            lblinfo2.AutoSize = true;
            lblinfo2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblinfo2.Location = new Point(38, 63);
            lblinfo2.Name = "lblinfo2";
            lblinfo2.Size = new Size(233, 24);
            lblinfo2.TabIndex = 9;
            lblinfo2.Text = "Introduceti un username:";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_username.Location = new Point(277, 58);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(228, 29);
            txt_username.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(38, 110);
            label1.Name = "label1";
            label1.Size = new Size(191, 24);
            label1.TabIndex = 11;
            label1.Text = "Introduceti o parola:";
            // 
            // txt_parola
            // 
            txt_parola.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_parola.Location = new Point(277, 110);
            txt_parola.Name = "txt_parola";
            txt_parola.Size = new Size(228, 29);
            txt_parola.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(565, 63);
            label2.Name = "label2";
            label2.Size = new Size(215, 24);
            label2.TabIndex = 12;
            label2.Text = "Utilizatori inregristrati:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.PaleGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(574, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(438, 226);
            dataGridView1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(38, 159);
            label3.Name = "label3";
            label3.Size = new Size(180, 24);
            label3.TabIndex = 14;
            label3.Text = "introduceti functia:";
            // 
            // txt_functia
            // 
            txt_functia.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_functia.Location = new Point(277, 159);
            txt_functia.Name = "txt_functia";
            txt_functia.Size = new Size(228, 29);
            txt_functia.TabIndex = 15;
            // 
            // btn_stergeUtiliz
            // 
            btn_stergeUtiliz.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stergeUtiliz.ForeColor = SystemColors.ControlText;
            btn_stergeUtiliz.Location = new Point(308, 242);
            btn_stergeUtiliz.Name = "btn_stergeUtiliz";
            btn_stergeUtiliz.Size = new Size(197, 67);
            btn_stergeUtiliz.TabIndex = 17;
            btn_stergeUtiliz.Text = "Stergere";
            btn_stergeUtiliz.UseVisualStyleBackColor = true;
            btn_stergeUtiliz.Click += btn_stergeUtiliz_Click;
            // 
            // btn_adaugaUtiliz
            // 
            btn_adaugaUtiliz.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adaugaUtiliz.ForeColor = SystemColors.ControlText;
            btn_adaugaUtiliz.Location = new Point(58, 242);
            btn_adaugaUtiliz.Name = "btn_adaugaUtiliz";
            btn_adaugaUtiliz.Size = new Size(197, 67);
            btn_adaugaUtiliz.TabIndex = 16;
            btn_adaugaUtiliz.Text = "Adaugare";
            btn_adaugaUtiliz.UseVisualStyleBackColor = true;
            btn_adaugaUtiliz.Click += btn_adaugaUtiliz_Click;
            // 
            // Utilizatori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1070, 428);
            Controls.Add(btn_stergeUtiliz);
            Controls.Add(btn_adaugaUtiliz);
            Controls.Add(txt_functia);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_parola);
            Controls.Add(lblinfo2);
            Controls.Add(txt_username);
            Name = "Utilizatori";
            Text = "Utilizatori";
            Load += Utilizatori_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblinfo2;
        private TextBox txt_username;
        private Label label1;
        private TextBox txt_parola;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txt_functia;
        private Button btn_stergeSemestru;
        private Button btn_adaugaSemestru;
        private Button btn_stergeUtiliz;
        private Button btn_adaugaUtiliz;
    }
}
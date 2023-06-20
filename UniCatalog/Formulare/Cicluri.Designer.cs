namespace UniCatalog.Formulare
{
    partial class Cicluri
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
            dataGridView1 = new DataGridView();
            btn_stergeCiclu = new Button();
            lblinfo = new Label();
            txt_numeCiclu = new TextBox();
            lblinfo2 = new Label();
            btn_Adauga = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Thistle;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(316, 167);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_stergeCiclu
            // 
            btn_stergeCiclu.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stergeCiclu.Location = new Point(501, 147);
            btn_stergeCiclu.Name = "btn_stergeCiclu";
            btn_stergeCiclu.Size = new Size(100, 46);
            btn_stergeCiclu.TabIndex = 2;
            btn_stergeCiclu.Text = "Sterge";
            btn_stergeCiclu.UseVisualStyleBackColor = true;
            btn_stergeCiclu.Click += btn_StergeCicluClick;
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblinfo.Location = new Point(34, 33);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new Size(316, 28);
            lblinfo.TabIndex = 3;
            lblinfo.Text = "Cicluri de invatamant actuale:";
            // 
            // txt_numeCiclu
            // 
            txt_numeCiclu.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_numeCiclu.Location = new Point(451, 94);
            txt_numeCiclu.Name = "txt_numeCiclu";
            txt_numeCiclu.Size = new Size(150, 29);
            txt_numeCiclu.TabIndex = 4;
            // 
            // lblinfo2
            // 
            lblinfo2.AutoSize = true;
            lblinfo2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblinfo2.Location = new Point(376, 99);
            lblinfo2.Name = "lblinfo2";
            lblinfo2.Size = new Size(69, 24);
            lblinfo2.TabIndex = 5;
            lblinfo2.Text = "Nume:";
            // 
            // btn_Adauga
            // 
            btn_Adauga.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Adauga.Location = new Point(376, 147);
            btn_Adauga.Name = "btn_Adauga";
            btn_Adauga.Size = new Size(100, 46);
            btn_Adauga.TabIndex = 6;
            btn_Adauga.Text = "Adauga";
            btn_Adauga.UseVisualStyleBackColor = true;
            btn_Adauga.Click += btn_adaugaCicluClick;
            // 
            // Cicluri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(626, 304);
            Controls.Add(btn_Adauga);
            Controls.Add(lblinfo2);
            Controls.Add(txt_numeCiclu);
            Controls.Add(lblinfo);
            Controls.Add(btn_stergeCiclu);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Cicluri";
            Text = "Cicluri";
            Load += Cicluri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_stergeCiclu;
        private Label lblinfo;
        private TextBox txt_numeCiclu;
        private Label lblinfo2;
        private Button btn_Adauga;
    }
}
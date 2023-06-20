namespace UniCatalog.Formulare
{
    partial class CadreDidactice
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
            lblinfo2 = new Label();
            txt_numeProf = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_prenumeProf = new TextBox();
            label3 = new Label();
            cbx_titlu = new ComboBox();
            cbx_post = new ComboBox();
            btn_Adauga = new Button();
            btn_stergeCiclu = new Button();
            label4 = new Label();
            cbx_discipline = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(331, 272);
            dataGridView1.TabIndex = 0;
            // 
            // lblinfo2
            // 
            lblinfo2.AutoSize = true;
            lblinfo2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblinfo2.Location = new Point(396, 27);
            lblinfo2.Name = "lblinfo2";
            lblinfo2.Size = new Size(69, 24);
            lblinfo2.TabIndex = 7;
            lblinfo2.Text = "Nume:";
            // 
            // txt_numeProf
            // 
            txt_numeProf.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_numeProf.Location = new Point(509, 27);
            txt_numeProf.Name = "txt_numeProf";
            txt_numeProf.Size = new Size(228, 29);
            txt_numeProf.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(396, 70);
            label1.Name = "label1";
            label1.Size = new Size(96, 24);
            label1.TabIndex = 8;
            label1.Text = "Prenume:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(396, 112);
            label2.Name = "label2";
            label2.Size = new Size(59, 24);
            label2.TabIndex = 9;
            label2.Text = "Titlu:";
            // 
            // txt_prenumeProf
            // 
            txt_prenumeProf.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_prenumeProf.Location = new Point(509, 65);
            txt_prenumeProf.Name = "txt_prenumeProf";
            txt_prenumeProf.Size = new Size(228, 29);
            txt_prenumeProf.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(396, 155);
            label3.Name = "label3";
            label3.Size = new Size(54, 24);
            label3.TabIndex = 12;
            label3.Text = "Post:";
            // 
            // cbx_titlu
            // 
            cbx_titlu.BackColor = Color.White;
            cbx_titlu.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_titlu.FormattingEnabled = true;
            cbx_titlu.Location = new Point(509, 106);
            cbx_titlu.Name = "cbx_titlu";
            cbx_titlu.Size = new Size(228, 30);
            cbx_titlu.TabIndex = 13;
            // 
            // cbx_post
            // 
            cbx_post.BackColor = Color.White;
            cbx_post.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_post.FormattingEnabled = true;
            cbx_post.Location = new Point(509, 149);
            cbx_post.Name = "cbx_post";
            cbx_post.Size = new Size(228, 30);
            cbx_post.TabIndex = 14;
            // 
            // btn_Adauga
            // 
            btn_Adauga.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Adauga.Location = new Point(423, 245);
            btn_Adauga.Name = "btn_Adauga";
            btn_Adauga.Size = new Size(123, 66);
            btn_Adauga.TabIndex = 16;
            btn_Adauga.Text = "Adauga";
            btn_Adauga.UseVisualStyleBackColor = true;
            btn_Adauga.Click += btn_Adauga_Click;
            // 
            // btn_stergeCiclu
            // 
            btn_stergeCiclu.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stergeCiclu.Location = new Point(598, 244);
            btn_stergeCiclu.Name = "btn_stergeCiclu";
            btn_stergeCiclu.Size = new Size(123, 67);
            btn_stergeCiclu.TabIndex = 15;
            btn_stergeCiclu.Text = "Sterge";
            btn_stergeCiclu.UseVisualStyleBackColor = true;
            btn_stergeCiclu.Click += btn_stergeCiclu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(396, 194);
            label4.Name = "label4";
            label4.Size = new Size(105, 48);
            label4.TabIndex = 17;
            label4.Text = "Disciplina \r\npredata:";
            // 
            // cbx_discipline
            // 
            cbx_discipline.BackColor = Color.White;
            cbx_discipline.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_discipline.FormattingEnabled = true;
            cbx_discipline.Location = new Point(509, 193);
            cbx_discipline.Name = "cbx_discipline";
            cbx_discipline.Size = new Size(226, 30);
            cbx_discipline.TabIndex = 18;
            // 
            // CadreDidactice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(780, 351);
            Controls.Add(cbx_discipline);
            Controls.Add(label4);
            Controls.Add(btn_Adauga);
            Controls.Add(btn_stergeCiclu);
            Controls.Add(cbx_post);
            Controls.Add(cbx_titlu);
            Controls.Add(label3);
            Controls.Add(txt_prenumeProf);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblinfo2);
            Controls.Add(txt_numeProf);
            Controls.Add(dataGridView1);
            Name = "CadreDidactice";
            Text = "Form1";
            Load += CadreDidactice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblinfo2;
        private TextBox txt_numeProf;
        private Label label1;
        private Label label2;
        private TextBox txt_prenumeProf;
        private Label label3;
        private ComboBox cbx_titlu;
        private ComboBox cbx_post;
        private Button btn_Adauga;
        private Button btn_stergeCiclu;
        private Label label4;
        private ComboBox cbx_discipline;
    }
}
namespace UniCatalog.Formulare
{
    partial class Grupe
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
            cbx_ML = new ComboBox();
            lblselectare = new Label();
            label1 = new Label();
            label2 = new Label();
            cbx_prggr = new ComboBox();
            label3 = new Label();
            txt_an = new TextBox();
            label4 = new Label();
            txt_grupe = new TextBox();
            btn_generare = new Button();
            label5 = new Label();
            cbx_grupa = new ComboBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbx_ML
            // 
            cbx_ML.BackColor = Color.White;
            cbx_ML.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_ML.FormattingEnabled = true;
            cbx_ML.Location = new Point(209, 32);
            cbx_ML.Name = "cbx_ML";
            cbx_ML.Size = new Size(134, 30);
            cbx_ML.TabIndex = 3;
            // 
            // lblselectare
            // 
            lblselectare.AutoSize = true;
            lblselectare.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblselectare.Location = new Point(45, 40);
            lblselectare.Name = "lblselectare";
            lblselectare.Size = new Size(158, 22);
            lblselectare.TabIndex = 2;
            lblselectare.Text = "Selectati M sau L:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(418, 32);
            label1.Name = "label1";
            label1.Size = new Size(103, 44);
            label1.TabIndex = 4;
            label1.Text = "M - Master\r\nL - Licenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 100);
            label2.Name = "label2";
            label2.Size = new Size(251, 22);
            label2.TabIndex = 5;
            label2.Text = "Selectati Programul de studii:";
            // 
            // cbx_prggr
            // 
            cbx_prggr.BackColor = Color.White;
            cbx_prggr.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_prggr.FormattingEnabled = true;
            cbx_prggr.Location = new Point(302, 92);
            cbx_prggr.Name = "cbx_prggr";
            cbx_prggr.Size = new Size(242, 30);
            cbx_prggr.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 141);
            label3.Name = "label3";
            label3.Size = new Size(223, 22);
            label3.TabIndex = 7;
            label3.Text = "Introduceti anul admiterii:";
            // 
            // txt_an
            // 
            txt_an.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_an.Location = new Point(302, 134);
            txt_an.Name = "txt_an";
            txt_an.Size = new Size(242, 29);
            txt_an.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 181);
            label4.Name = "label4";
            label4.Size = new Size(298, 22);
            label4.TabIndex = 9;
            label4.Text = "Introduceti numarul de grupe dorit:";
            // 
            // txt_grupe
            // 
            txt_grupe.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_grupe.Location = new Point(344, 174);
            txt_grupe.Name = "txt_grupe";
            txt_grupe.Size = new Size(242, 29);
            txt_grupe.TabIndex = 10;
            // 
            // btn_generare
            // 
            btn_generare.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_generare.ForeColor = SystemColors.ControlText;
            btn_generare.Location = new Point(45, 226);
            btn_generare.Name = "btn_generare";
            btn_generare.Size = new Size(200, 67);
            btn_generare.TabIndex = 21;
            btn_generare.Text = "Genereaza grupa";
            btn_generare.UseVisualStyleBackColor = true;
            btn_generare.Click += btn_generare_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(45, 334);
            label5.Name = "label5";
            label5.Size = new Size(215, 22);
            label5.TabIndex = 22;
            label5.Text = "Selectati grupa generata:";
            // 
            // cbx_grupa
            // 
            cbx_grupa.BackColor = Color.White;
            cbx_grupa.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_grupa.FormattingEnabled = true;
            cbx_grupa.Location = new Point(279, 334);
            cbx_grupa.Name = "cbx_grupa";
            cbx_grupa.Size = new Size(242, 30);
            cbx_grupa.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(45, 385);
            label6.Name = "label6";
            label6.Size = new Size(164, 22);
            label6.TabIndex = 24;
            label6.Text = "Selectati studentul:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(215, 385);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(306, 157);
            dataGridView1.TabIndex = 25;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(45, 560);
            button1.Name = "button1";
            button1.Size = new Size(200, 67);
            button1.TabIndex = 26;
            button1.Text = "Atribuiti grupa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Grupe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(699, 639);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(cbx_grupa);
            Controls.Add(label5);
            Controls.Add(btn_generare);
            Controls.Add(txt_grupe);
            Controls.Add(label4);
            Controls.Add(txt_an);
            Controls.Add(label3);
            Controls.Add(cbx_prggr);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbx_ML);
            Controls.Add(lblselectare);
            Name = "Grupe";
            Load += Grupe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_ML;
        private Label lblselectare;
        private Label label1;
        private Label label2;
        private ComboBox cbx_prggr;
        private Label label3;
        private TextBox txt_an;
        private Label label4;
        private TextBox txt_grupe;
        private Button btn_generare;
        private Label label5;
        private ComboBox cbx_grupa;
        private Label label6;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
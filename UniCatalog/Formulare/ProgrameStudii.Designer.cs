namespace UniCatalog.Formulare
{
    partial class ProgrameStudii
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
            lblselectare = new Label();
            cbx_programestudii = new ComboBox();
            label1 = new Label();
            txt_numeprog = new TextBox();
            btn_adaugaProgram = new Button();
            btn_stergeProgram = new Button();
            dgv_programe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_programe).BeginInit();
            SuspendLayout();
            // 
            // lblselectare
            // 
            lblselectare.AutoSize = true;
            lblselectare.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblselectare.Location = new Point(46, 46);
            lblselectare.Name = "lblselectare";
            lblselectare.Size = new Size(297, 22);
            lblselectare.TabIndex = 0;
            lblselectare.Text = "Selectati ciclul de invatamant dorit:";
            // 
            // cbx_programestudii
            // 
            cbx_programestudii.BackColor = Color.White;
            cbx_programestudii.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_programestudii.FormattingEnabled = true;
            cbx_programestudii.Location = new Point(349, 38);
            cbx_programestudii.Name = "cbx_programestudii";
            cbx_programestudii.Size = new Size(134, 30);
            cbx_programestudii.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 93);
            label1.Name = "label1";
            label1.Size = new Size(352, 22);
            label1.TabIndex = 2;
            label1.Text = "Introduceti numele programului de studiu:";
            // 
            // txt_numeprog
            // 
            txt_numeprog.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt_numeprog.Location = new Point(404, 86);
            txt_numeprog.Name = "txt_numeprog";
            txt_numeprog.Size = new Size(289, 29);
            txt_numeprog.TabIndex = 3;
            // 
            // btn_adaugaProgram
            // 
            btn_adaugaProgram.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adaugaProgram.ForeColor = SystemColors.ControlText;
            btn_adaugaProgram.Location = new Point(461, 158);
            btn_adaugaProgram.Name = "btn_adaugaProgram";
            btn_adaugaProgram.Size = new Size(200, 67);
            btn_adaugaProgram.TabIndex = 4;
            btn_adaugaProgram.Text = "Adaugare";
            btn_adaugaProgram.UseVisualStyleBackColor = true;
            btn_adaugaProgram.Click += btn_adaugaProgramClick;
            // 
            // btn_stergeProgram
            // 
            btn_stergeProgram.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_stergeProgram.ForeColor = SystemColors.ControlText;
            btn_stergeProgram.Location = new Point(461, 250);
            btn_stergeProgram.Name = "btn_stergeProgram";
            btn_stergeProgram.Size = new Size(200, 67);
            btn_stergeProgram.TabIndex = 5;
            btn_stergeProgram.Text = "Stergere";
            btn_stergeProgram.UseVisualStyleBackColor = true;
            btn_stergeProgram.Click += btn_stergeProgramClick;
            // 
            // dgv_programe
            // 
            dgv_programe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_programe.BackgroundColor = Color.PeachPuff;
            dgv_programe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_programe.Location = new Point(46, 158);
            dgv_programe.Name = "dgv_programe";
            dgv_programe.RowTemplate.Height = 25;
            dgv_programe.Size = new Size(371, 159);
            dgv_programe.TabIndex = 6;
            // 
            // ProgrameStudii
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(736, 355);
            Controls.Add(dgv_programe);
            Controls.Add(btn_stergeProgram);
            Controls.Add(btn_adaugaProgram);
            Controls.Add(txt_numeprog);
            Controls.Add(label1);
            Controls.Add(cbx_programestudii);
            Controls.Add(lblselectare);
            Name = "ProgrameStudii";
            Text = "ProgrameStudii";
            Load += ProgrameStudii_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_programe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblselectare;
        private ComboBox cbx_programestudii;
        private Label label1;
        private TextBox textBox1;
        private Button btn_adaugaProgram;
        private Button btn_stergeProgram;
        private DataGridView dgv_programe;
        private TextBox txt_numeprog;
    }
}
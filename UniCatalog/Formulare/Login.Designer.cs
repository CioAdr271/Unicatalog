using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UniCatalog
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            chkPassword = new CheckBox();
            lblPassword = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(123, 313);
            button1.Name = "button1";
            button1.Size = new Size(170, 44);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLogin_Click;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point);
            chkPassword.Location = new Point(265, 265);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(127, 23);
            chkPassword.TabIndex = 1;
            chkPassword.Text = "Show password";
            chkPassword.UseVisualStyleBackColor = true;
            chkPassword.CheckedChanged += btn_ShowPsw;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(46, 218);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 22);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(46, 180);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 22);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(149, 173);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 29);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(147, 215);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 29);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(417, 393);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(chkPassword);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox chkPassword;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
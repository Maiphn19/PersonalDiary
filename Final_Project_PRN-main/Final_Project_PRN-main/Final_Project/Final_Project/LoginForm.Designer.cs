namespace Final_Project
{
    partial class LoginForm
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnSignin = new Button();
            btnLogin = new Button();
            label8 = new Label();
            panel4 = new Panel();
            txtPassword = new TextBox();
            panel3 = new Panel();
            txtUsername = new TextBox();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 526);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(152, 481);
            label5.Name = "label5";
            label5.Size = new Size(138, 18);
            label5.TabIndex = 6;
            label5.Text = "Pham Ha Ngoc Mai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(203, 449);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 5;
            label4.Text = "Create By";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(175, 306);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 4;
            label1.Text = "System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 258);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 3;
            label3.Text = "Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 208);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 2;
            label2.Text = "Personal Diary";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.diary;
            pictureBox1.Location = new Point(87, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSignin);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(302, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(587, 526);
            panel2.TabIndex = 1;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = SystemColors.Control;
            btnSignin.FlatAppearance.BorderSize = 0;
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignin.ForeColor = Color.FromArgb(51, 51, 76);
            btnSignin.Location = new Point(127, 435);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(272, 47);
            btnSignin.TabIndex = 10;
            btnSignin.Text = "Create a new account";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(51, 51, 76);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(32, 382);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(468, 47);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(51, 51, 76);
            label8.Location = new Point(32, 265);
            label8.Name = "label8";
            label8.Size = new Size(98, 25);
            label8.TabIndex = 7;
            label8.Text = "Password";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtPassword);
            panel4.Location = new Point(32, 294);
            panel4.Name = "panel4";
            panel4.Size = new Size(468, 54);
            panel4.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(51, 51, 76);
            txtPassword.Location = new Point(3, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(462, 23);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtUsername);
            panel3.Location = new Point(32, 188);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 54);
            panel3.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(51, 51, 76);
            txtUsername.Location = new Point(3, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(462, 23);
            txtUsername.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(51, 51, 76);
            label7.Location = new Point(32, 151);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 4;
            label7.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(51, 51, 76);
            label6.Location = new Point(32, 96);
            label6.Name = "label6";
            label6.Size = new Size(285, 32);
            label6.TabIndex = 3;
            label6.Text = "Login to your account";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 526);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label8;
        private Panel panel4;
        private TextBox txtPassword;
        private Panel panel3;
        private TextBox txtUsername;
        private Label label7;
        private Label label6;
        private Button btnSignin;
        private Button btnLogin;
    }
}
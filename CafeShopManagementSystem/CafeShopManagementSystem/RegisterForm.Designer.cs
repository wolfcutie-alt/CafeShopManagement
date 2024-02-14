namespace CafeShopManagementSystem
{
    partial class RegisterForm
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
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            register_loginBtn = new Button();
            register_btn = new Button();
            register_showPass = new CheckBox();
            register_password = new TextBox();
            label4 = new Label();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            close = new Label();
            register_cPassword = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 99, 102);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(register_loginBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 484);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 202);
            label6.Name = "label6";
            label6.Size = new Size(305, 22);
            label6.TabIndex = 9;
            label6.Text = "Cafe Shop Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_Cafe_100px_6;
            pictureBox1.Location = new Point(108, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(60, 410);
            label5.Name = "label5";
            label5.Size = new Size(208, 19);
            label5.TabIndex = 9;
            label5.Text = "Already have an Account?";
            // 
            // register_loginBtn
            // 
            register_loginBtn.BackColor = Color.FromArgb(7, 99, 102);
            register_loginBtn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_loginBtn.ForeColor = Color.White;
            register_loginBtn.Location = new Point(12, 432);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(296, 40);
            register_loginBtn.TabIndex = 9;
            register_loginBtn.Text = "SIGN IN";
            register_loginBtn.UseVisualStyleBackColor = false;
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(7, 99, 102);
            register_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(363, 376);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(118, 40);
            register_btn.TabIndex = 17;
            register_btn.Text = "SIGNUP";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(363, 338);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(139, 22);
            register_showPass.TabIndex = 16;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // register_password
            // 
            register_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(363, 224);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(288, 26);
            register_password.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(363, 203);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // register_username
            // 
            register_username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.Location = new Point(363, 158);
            register_username.Name = "register_username";
            register_username.Size = new Size(288, 26);
            register_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(363, 137);
            label3.Name = "label3";
            label3.Size = new Size(84, 18);
            label3.TabIndex = 12;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(363, 86);
            label2.Name = "label2";
            label2.Size = new Size(108, 22);
            label2.TabIndex = 11;
            label2.Text = "REGISTER";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(659, 9);
            close.Name = "close";
            close.Size = new Size(20, 19);
            close.TabIndex = 10;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // register_cPassword
            // 
            register_cPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_cPassword.Location = new Point(363, 284);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(288, 26);
            register_cPassword.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(363, 263);
            label7.Name = "label7";
            label7.Size = new Size(141, 18);
            label7.TabIndex = 18;
            label7.Text = "Confirm Password:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(685, 484);
            Controls.Add(register_cPassword);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(register_btn);
            Controls.Add(register_showPass);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label5;
        private Button register_loginBtn;
        private Button register_btn;
        private CheckBox register_showPass;
        private TextBox register_password;
        private Label label4;
        private TextBox register_username;
        private Label label3;
        private Label label2;
        private Label close;
        private TextBox register_cPassword;
        private Label label7;
    }
}
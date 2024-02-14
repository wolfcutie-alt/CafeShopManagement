namespace CafeShopManagementSystem
{
    partial class AdminMainForm
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
            label1 = new Label();
            close = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel3 = new Panel();
            cashierCustomersForm1 = new CashierCustomersForm();
            adminAddProducts1 = new AdminAddProducts();
            adminAddUsers1 = new AdminAddUsers();
            adminDashboardForm1 = new AdminDashboardForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(232, 18);
            label1.TabIndex = 3;
            label1.Text = "Cafe Shop Management System";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(1474, 10);
            close.Name = "close";
            close.Size = new Size(20, 19);
            close.TabIndex = 2;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 99, 102);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 745);
            panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(7, 99, 102);
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(12, 687);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(224, 36);
            logout_btn.TabIndex = 12;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(7, 99, 102);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 397);
            button3.Name = "button3";
            button3.Size = new Size(224, 36);
            button3.TabIndex = 5;
            button3.Text = "Customers";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(7, 99, 102);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 345);
            button4.Name = "button4";
            button4.Size = new Size(224, 36);
            button4.TabIndex = 4;
            button4.Text = "Add Products";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(7, 99, 102);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 294);
            button2.Name = "button2";
            button2.Size = new Size(224, 36);
            button2.TabIndex = 3;
            button2.Text = "Add Cashiers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(93, 194);
            label4.Name = "label4";
            label4.Size = new Size(48, 16);
            label4.TabIndex = 11;
            label4.Text = "Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 157);
            label2.Name = "label2";
            label2.Size = new Size(145, 22);
            label2.TabIndex = 4;
            label2.Text = "Admin's Portal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_Cafe_100px_6;
            pictureBox1.Location = new Point(71, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(7, 99, 102);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 284);
            button1.Name = "button1";
            button1.Size = new Size(224, 36);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(adminDashboardForm1);
            panel3.Controls.Add(adminAddUsers1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierCustomersForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(249, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1251, 745);
            panel3.TabIndex = 3;
            // 
            // cashierCustomersForm1
            // 
            cashierCustomersForm1.Location = new Point(0, 0);
            cashierCustomersForm1.Name = "cashierCustomersForm1";
            cashierCustomersForm1.Size = new Size(1251, 745);
            cashierCustomersForm1.TabIndex = 0;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1251, 745);
            adminAddProducts1.TabIndex = 4;
            // 
            // adminAddUsers1
            // 
            adminAddUsers1.Location = new Point(0, 0);
            adminAddUsers1.Name = "adminAddUsers1";
            adminAddUsers1.Size = new Size(1251, 745);
            adminAddUsers1.TabIndex = 4;
            // 
            // adminDashboardForm1
            // 
            adminDashboardForm1.Location = new Point(0, 0);
            adminDashboardForm1.Name = "adminDashboardForm1";
            adminDashboardForm1.Size = new Size(1251, 745);
            adminDashboardForm1.TabIndex = 4;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 790);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label close;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button logout_btn;
        private Panel panel3;
        private AdminDashboardForm adminDashboardForm1;
        private AdminAddUsers adminAddUsers1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomersForm cashierCustomersForm1;
    }
}
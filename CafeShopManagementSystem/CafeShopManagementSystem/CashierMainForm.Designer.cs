namespace CafeShopManagementSystem
{
    partial class CashierMainForm
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
            customer_btn = new Button();
            logout_btn = new Button();
            order_btn = new Button();
            addProducts_btn = new Button();
            dashboard_btn = new Button();
            username = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            cashierCustomersForm1 = new CashierCustomersForm();
            cashierOrderForm1 = new CashierOrderForm();
            adminAddProducts1 = new AdminAddProducts();
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
            panel1.TabIndex = 1;
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
            panel2.Controls.Add(customer_btn);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(order_btn);
            panel2.Controls.Add(addProducts_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(username);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 745);
            panel2.TabIndex = 2;
            // 
            // customer_btn
            // 
            customer_btn.BackColor = Color.FromArgb(7, 99, 102);
            customer_btn.FlatStyle = FlatStyle.Flat;
            customer_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_btn.ForeColor = Color.White;
            customer_btn.Location = new Point(12, 452);
            customer_btn.Name = "customer_btn";
            customer_btn.Size = new Size(224, 36);
            customer_btn.TabIndex = 13;
            customer_btn.Text = "Customers";
            customer_btn.UseVisualStyleBackColor = false;
            customer_btn.Click += customer_btn_Click;
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
            // order_btn
            // 
            order_btn.BackColor = Color.FromArgb(7, 99, 102);
            order_btn.FlatStyle = FlatStyle.Flat;
            order_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order_btn.ForeColor = Color.White;
            order_btn.Location = new Point(12, 397);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(224, 36);
            order_btn.TabIndex = 5;
            order_btn.Text = "Order";
            order_btn.UseVisualStyleBackColor = false;
            order_btn.Click += order_btn_Click;
            // 
            // addProducts_btn
            // 
            addProducts_btn.BackColor = Color.FromArgb(7, 99, 102);
            addProducts_btn.FlatStyle = FlatStyle.Flat;
            addProducts_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProducts_btn.ForeColor = Color.White;
            addProducts_btn.Location = new Point(12, 345);
            addProducts_btn.Name = "addProducts_btn";
            addProducts_btn.Size = new Size(224, 36);
            addProducts_btn.TabIndex = 4;
            addProducts_btn.Text = "Add Products";
            addProducts_btn.UseVisualStyleBackColor = false;
            addProducts_btn.Click += addProducts_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(7, 99, 102);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(12, 294);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(224, 36);
            dashboard_btn.TabIndex = 3;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            username.ForeColor = Color.White;
            username.Location = new Point(93, 194);
            username.Name = "username";
            username.Size = new Size(48, 16);
            username.TabIndex = 11;
            username.Text = "Admin";
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
            // panel3
            // 
            panel3.Controls.Add(adminDashboardForm1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierOrderForm1);
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
            // cashierOrderForm1
            // 
            cashierOrderForm1.Location = new Point(0, 0);
            cashierOrderForm1.Name = "cashierOrderForm1";
            cashierOrderForm1.Size = new Size(1251, 745);
            cashierOrderForm1.TabIndex = 4;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1251, 745);
            adminAddProducts1.TabIndex = 4;
            // 
            // adminDashboardForm1
            // 
            adminDashboardForm1.Location = new Point(0, 0);
            adminDashboardForm1.Name = "adminDashboardForm1";
            adminDashboardForm1.Size = new Size(1251, 745);
            adminDashboardForm1.TabIndex = 4;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 790);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierMainForm";
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
        private Label label1;
        private Label close;
        private Panel panel2;
        private Button customer_btn;
        private Button logout_btn;
        private Button order_btn;
        private Button addProducts_btn;
        private Button dashboard_btn;
        private Label username;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private AdminDashboardForm adminDashboardForm1;
        private AdminAddProducts adminAddProducts1;
        private CashierOrderForm cashierOrderForm1;
        private CashierCustomersForm cashierCustomersForm1;
    }
}
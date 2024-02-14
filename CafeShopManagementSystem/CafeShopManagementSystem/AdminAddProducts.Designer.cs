namespace CafeShopManagementSystem
{
    partial class AdminAddProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            adminAddProducts_clearBtn = new Button();
            adminAddProducts_deleteBtn = new Button();
            adminAddProducts_updateBtn = new Button();
            adminAddProducts_addBtn = new Button();
            panel3 = new Panel();
            adminAddProducts_imageView = new PictureBox();
            adminAddProducts_importBtn = new Button();
            adminAddProducts_status = new ComboBox();
            label4 = new Label();
            adminAddProducts_price = new TextBox();
            label6 = new Label();
            adminAddProducts_stock = new TextBox();
            label7 = new Label();
            adminAddProducts_type = new ComboBox();
            label5 = new Label();
            adminAddProducts_name = new TextBox();
            label3 = new Label();
            adminAddProducts_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminAddProducts_imageView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(17, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 397);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(165, 22);
            label1.TabIndex = 3;
            label1.Text = "Data of Products";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(18, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1179, 318);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(adminAddProducts_clearBtn);
            panel2.Controls.Add(adminAddProducts_deleteBtn);
            panel2.Controls.Add(adminAddProducts_updateBtn);
            panel2.Controls.Add(adminAddProducts_addBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(adminAddProducts_importBtn);
            panel2.Controls.Add(adminAddProducts_status);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(adminAddProducts_price);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(adminAddProducts_stock);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(adminAddProducts_type);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(adminAddProducts_name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(adminAddProducts_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 442);
            panel2.Name = "panel2";
            panel2.Size = new Size(1216, 281);
            panel2.TabIndex = 1;
            // 
            // adminAddProducts_clearBtn
            // 
            adminAddProducts_clearBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_clearBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_clearBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            adminAddProducts_clearBtn.ForeColor = Color.White;
            adminAddProducts_clearBtn.Location = new Point(724, 199);
            adminAddProducts_clearBtn.Name = "adminAddProducts_clearBtn";
            adminAddProducts_clearBtn.Size = new Size(123, 49);
            adminAddProducts_clearBtn.TabIndex = 25;
            adminAddProducts_clearBtn.Text = "CLEAR";
            adminAddProducts_clearBtn.UseVisualStyleBackColor = false;
            adminAddProducts_clearBtn.Click += adminAddProducts_clearBtn_Click;
            // 
            // adminAddProducts_deleteBtn
            // 
            adminAddProducts_deleteBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_deleteBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_deleteBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            adminAddProducts_deleteBtn.ForeColor = Color.White;
            adminAddProducts_deleteBtn.Location = new Point(563, 199);
            adminAddProducts_deleteBtn.Name = "adminAddProducts_deleteBtn";
            adminAddProducts_deleteBtn.Size = new Size(123, 49);
            adminAddProducts_deleteBtn.TabIndex = 24;
            adminAddProducts_deleteBtn.Text = "DELETE";
            adminAddProducts_deleteBtn.UseVisualStyleBackColor = false;
            adminAddProducts_deleteBtn.Click += adminAddProducts_deleteBtn_Click;
            // 
            // adminAddProducts_updateBtn
            // 
            adminAddProducts_updateBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_updateBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_updateBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            adminAddProducts_updateBtn.ForeColor = Color.White;
            adminAddProducts_updateBtn.Location = new Point(352, 199);
            adminAddProducts_updateBtn.Name = "adminAddProducts_updateBtn";
            adminAddProducts_updateBtn.Size = new Size(123, 49);
            adminAddProducts_updateBtn.TabIndex = 23;
            adminAddProducts_updateBtn.Text = "UPDATE";
            adminAddProducts_updateBtn.UseVisualStyleBackColor = false;
            adminAddProducts_updateBtn.Click += adminAddProducts_updateBtn_Click;
            // 
            // adminAddProducts_addBtn
            // 
            adminAddProducts_addBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_addBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_addBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            adminAddProducts_addBtn.ForeColor = Color.White;
            adminAddProducts_addBtn.Location = new Point(192, 199);
            adminAddProducts_addBtn.Name = "adminAddProducts_addBtn";
            adminAddProducts_addBtn.Size = new Size(123, 49);
            adminAddProducts_addBtn.TabIndex = 22;
            adminAddProducts_addBtn.Text = "ADD";
            adminAddProducts_addBtn.UseVisualStyleBackColor = false;
            adminAddProducts_addBtn.Click += adminAddProducts_addBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(adminAddProducts_imageView);
            panel3.Location = new Point(1090, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(108, 122);
            panel3.TabIndex = 19;
            // 
            // adminAddProducts_imageView
            // 
            adminAddProducts_imageView.BackColor = Color.DarkGray;
            adminAddProducts_imageView.Location = new Point(0, 0);
            adminAddProducts_imageView.Name = "adminAddProducts_imageView";
            adminAddProducts_imageView.Size = new Size(108, 122);
            adminAddProducts_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            adminAddProducts_imageView.TabIndex = 20;
            adminAddProducts_imageView.TabStop = false;
            // 
            // adminAddProducts_importBtn
            // 
            adminAddProducts_importBtn.BackColor = Color.FromArgb(7, 99, 102);
            adminAddProducts_importBtn.FlatStyle = FlatStyle.Flat;
            adminAddProducts_importBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminAddProducts_importBtn.ForeColor = Color.White;
            adminAddProducts_importBtn.Location = new Point(1090, 161);
            adminAddProducts_importBtn.Name = "adminAddProducts_importBtn";
            adminAddProducts_importBtn.Size = new Size(108, 33);
            adminAddProducts_importBtn.TabIndex = 21;
            adminAddProducts_importBtn.Text = "Import";
            adminAddProducts_importBtn.UseVisualStyleBackColor = false;
            adminAddProducts_importBtn.Click += adminAddProducts_importBtn_Click;
            // 
            // adminAddProducts_status
            // 
            adminAddProducts_status.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_status.FormattingEnabled = true;
            adminAddProducts_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            adminAddProducts_status.Location = new Point(618, 126);
            adminAddProducts_status.Name = "adminAddProducts_status";
            adminAddProducts_status.Size = new Size(212, 32);
            adminAddProducts_status.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(553, 134);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 17;
            label4.Text = "Status:";
            // 
            // adminAddProducts_price
            // 
            adminAddProducts_price.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_price.Location = new Point(618, 77);
            adminAddProducts_price.Name = "adminAddProducts_price";
            adminAddProducts_price.Size = new Size(212, 26);
            adminAddProducts_price.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(539, 82);
            label6.Name = "label6";
            label6.Size = new Size(71, 18);
            label6.TabIndex = 15;
            label6.Text = "Price ($):";
            // 
            // adminAddProducts_stock
            // 
            adminAddProducts_stock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_stock.Location = new Point(618, 29);
            adminAddProducts_stock.Name = "adminAddProducts_stock";
            adminAddProducts_stock.Size = new Size(212, 26);
            adminAddProducts_stock.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(558, 34);
            label7.Name = "label7";
            label7.Size = new Size(52, 18);
            label7.TabIndex = 13;
            label7.Text = "Stock:";
            // 
            // adminAddProducts_type
            // 
            adminAddProducts_type.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_type.FormattingEnabled = true;
            adminAddProducts_type.Items.AddRange(new object[] { "Meal", "Drinks" });
            adminAddProducts_type.Location = new Point(166, 129);
            adminAddProducts_type.Name = "adminAddProducts_type";
            adminAddProducts_type.Size = new Size(212, 32);
            adminAddProducts_type.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 137);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 11;
            label5.Text = "Type:";
            // 
            // adminAddProducts_name
            // 
            adminAddProducts_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_name.Location = new Point(166, 80);
            adminAddProducts_name.Name = "adminAddProducts_name";
            adminAddProducts_name.Size = new Size(212, 26);
            adminAddProducts_name.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 85);
            label3.Name = "label3";
            label3.Size = new Size(112, 18);
            label3.TabIndex = 6;
            label3.Text = "Product Name:";
            // 
            // adminAddProducts_id
            // 
            adminAddProducts_id.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_id.Location = new Point(166, 32);
            adminAddProducts_id.Name = "adminAddProducts_id";
            adminAddProducts_id.Size = new Size(212, 26);
            adminAddProducts_id.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 37);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 4;
            label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(1251, 745);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminAddProducts_imageView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox adminAddProducts_name;
        private Label label3;
        private TextBox adminAddProducts_id;
        private Label label2;
        private ComboBox adminAddProducts_type;
        private Label label5;
        private ComboBox adminAddProducts_status;
        private Label label4;
        private TextBox adminAddProducts_price;
        private Label label6;
        private TextBox adminAddProducts_stock;
        private Label label7;
        private Panel panel3;
        private PictureBox adminAddProducts_imageView;
        private Button adminAddProducts_importBtn;
        private Button adminAddProducts_clearBtn;
        private Button adminAddProducts_deleteBtn;
        private Button adminAddProducts_updateBtn;
        private Button adminAddProducts_addBtn;
    }
}

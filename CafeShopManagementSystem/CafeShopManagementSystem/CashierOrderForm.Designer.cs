namespace CafeShopManagementSystem
{
    partial class CashierOrderForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrderForm));
            panel1 = new Panel();
            label1 = new Label();
            cashierOrderForm_menuTable = new DataGridView();
            panel2 = new Panel();
            cashierOrderForm_clearBtn = new Button();
            cashierOrderForm_removeBtn = new Button();
            cashierOrderForm_addBtn = new Button();
            cashierOrderForm_price = new Label();
            label8 = new Label();
            label6 = new Label();
            cashierOrderForm_quantity = new NumericUpDown();
            cashierOrderForm_prodName = new Label();
            label3 = new Label();
            cashierOrderForm_productID = new ComboBox();
            label2 = new Label();
            cashierOrderForm_type = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            cashierOrderForm_receiptBtn = new Button();
            cashierOrderForm_payBtn = new Button();
            cashierOrderForm_change = new Label();
            label13 = new Label();
            cashierOrderForm_amount = new TextBox();
            label11 = new Label();
            cashierOrderForm_orderPrice = new Label();
            label10 = new Label();
            cashierOrderForm_orderTable = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_menuTable).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_quantity).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_orderTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cashierOrderForm_menuTable);
            panel1.Location = new Point(18, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 345);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(62, 22);
            label1.TabIndex = 4;
            label1.Text = "Menu";
            // 
            // cashierOrderForm_menuTable
            // 
            cashierOrderForm_menuTable.AllowUserToAddRows = false;
            cashierOrderForm_menuTable.AllowUserToDeleteRows = false;
            cashierOrderForm_menuTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cashierOrderForm_menuTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            cashierOrderForm_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            cashierOrderForm_menuTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashierOrderForm_menuTable.EnableHeadersVisualStyles = false;
            cashierOrderForm_menuTable.Location = new Point(16, 59);
            cashierOrderForm_menuTable.Name = "cashierOrderForm_menuTable";
            cashierOrderForm_menuTable.ReadOnly = true;
            cashierOrderForm_menuTable.RowHeadersVisible = false;
            cashierOrderForm_menuTable.Size = new Size(777, 265);
            cashierOrderForm_menuTable.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cashierOrderForm_clearBtn);
            panel2.Controls.Add(cashierOrderForm_removeBtn);
            panel2.Controls.Add(cashierOrderForm_addBtn);
            panel2.Controls.Add(cashierOrderForm_price);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cashierOrderForm_quantity);
            panel2.Controls.Add(cashierOrderForm_prodName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cashierOrderForm_productID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cashierOrderForm_type);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(18, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 333);
            panel2.TabIndex = 1;
            // 
            // cashierOrderForm_clearBtn
            // 
            cashierOrderForm_clearBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_clearBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_clearBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            cashierOrderForm_clearBtn.ForeColor = Color.White;
            cashierOrderForm_clearBtn.Location = new Point(561, 255);
            cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            cashierOrderForm_clearBtn.Size = new Size(194, 49);
            cashierOrderForm_clearBtn.TabIndex = 26;
            cashierOrderForm_clearBtn.Text = "CLEAR";
            cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_removeBtn
            // 
            cashierOrderForm_removeBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_removeBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_removeBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            cashierOrderForm_removeBtn.ForeColor = Color.White;
            cashierOrderForm_removeBtn.Location = new Point(305, 255);
            cashierOrderForm_removeBtn.Name = "cashierOrderForm_removeBtn";
            cashierOrderForm_removeBtn.Size = new Size(194, 49);
            cashierOrderForm_removeBtn.TabIndex = 25;
            cashierOrderForm_removeBtn.Text = "REMOVE";
            cashierOrderForm_removeBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_addBtn
            // 
            cashierOrderForm_addBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_addBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_addBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            cashierOrderForm_addBtn.ForeColor = Color.White;
            cashierOrderForm_addBtn.Location = new Point(18, 255);
            cashierOrderForm_addBtn.Name = "cashierOrderForm_addBtn";
            cashierOrderForm_addBtn.Size = new Size(194, 49);
            cashierOrderForm_addBtn.TabIndex = 23;
            cashierOrderForm_addBtn.Text = "ADD";
            cashierOrderForm_addBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_addBtn.Click += cashierOrderForm_addBtn_Click;
            // 
            // cashierOrderForm_price
            // 
            cashierOrderForm_price.AutoSize = true;
            cashierOrderForm_price.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrderForm_price.Location = new Point(126, 168);
            cashierOrderForm_price.Name = "cashierOrderForm_price";
            cashierOrderForm_price.Size = new Size(32, 18);
            cashierOrderForm_price.TabIndex = 22;
            cashierOrderForm_price.Text = "100";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(53, 168);
            label8.Name = "label8";
            label8.Size = new Size(67, 18);
            label8.TabIndex = 21;
            label8.Text = "Price($):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(412, 121);
            label6.Name = "label6";
            label6.Size = new Size(71, 18);
            label6.TabIndex = 20;
            label6.Text = "Quantity:";
            // 
            // cashierOrderForm_quantity
            // 
            cashierOrderForm_quantity.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_quantity.Location = new Point(505, 116);
            cashierOrderForm_quantity.Name = "cashierOrderForm_quantity";
            cashierOrderForm_quantity.Size = new Size(212, 29);
            cashierOrderForm_quantity.TabIndex = 19;
            // 
            // cashierOrderForm_prodName
            // 
            cashierOrderForm_prodName.AutoSize = true;
            cashierOrderForm_prodName.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrderForm_prodName.Location = new Point(126, 121);
            cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
            cashierOrderForm_prodName.Size = new Size(0, 18);
            cashierOrderForm_prodName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 121);
            label3.Name = "label3";
            label3.Size = new Size(112, 18);
            label3.TabIndex = 17;
            label3.Text = "Product Name:";
            // 
            // cashierOrderForm_productID
            // 
            cashierOrderForm_productID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_productID.FormattingEnabled = true;
            cashierOrderForm_productID.Location = new Point(505, 54);
            cashierOrderForm_productID.Name = "cashierOrderForm_productID";
            cashierOrderForm_productID.Size = new Size(212, 32);
            cashierOrderForm_productID.TabIndex = 16;
            cashierOrderForm_productID.SelectedIndexChanged += cashierOrderForm_productID_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(412, 62);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 15;
            label2.Text = "Product ID:";
            // 
            // cashierOrderForm_type
            // 
            cashierOrderForm_type.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_type.FormattingEnabled = true;
            cashierOrderForm_type.Items.AddRange(new object[] { "Meal", "Drinks" });
            cashierOrderForm_type.Location = new Point(103, 54);
            cashierOrderForm_type.Name = "cashierOrderForm_type";
            cashierOrderForm_type.Size = new Size(212, 32);
            cashierOrderForm_type.TabIndex = 14;
            cashierOrderForm_type.SelectedIndexChanged += cashierOrderForm_type_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 62);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 13;
            label5.Text = "Type:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cashierOrderForm_receiptBtn);
            panel3.Controls.Add(cashierOrderForm_payBtn);
            panel3.Controls.Add(cashierOrderForm_change);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cashierOrderForm_amount);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(cashierOrderForm_orderPrice);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(cashierOrderForm_orderTable);
            panel3.Location = new Point(848, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 695);
            panel3.TabIndex = 1;
            // 
            // cashierOrderForm_receiptBtn
            // 
            cashierOrderForm_receiptBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_receiptBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_receiptBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            cashierOrderForm_receiptBtn.ForeColor = Color.White;
            cashierOrderForm_receiptBtn.Location = new Point(34, 625);
            cashierOrderForm_receiptBtn.Name = "cashierOrderForm_receiptBtn";
            cashierOrderForm_receiptBtn.Size = new Size(310, 49);
            cashierOrderForm_receiptBtn.TabIndex = 30;
            cashierOrderForm_receiptBtn.Text = "RECEIPT";
            cashierOrderForm_receiptBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_receiptBtn.Click += cashierOrderForm_receiptBtn_Click;
            // 
            // cashierOrderForm_payBtn
            // 
            cashierOrderForm_payBtn.BackColor = Color.FromArgb(7, 99, 102);
            cashierOrderForm_payBtn.FlatStyle = FlatStyle.Flat;
            cashierOrderForm_payBtn.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            cashierOrderForm_payBtn.ForeColor = Color.White;
            cashierOrderForm_payBtn.Location = new Point(34, 560);
            cashierOrderForm_payBtn.Name = "cashierOrderForm_payBtn";
            cashierOrderForm_payBtn.Size = new Size(310, 49);
            cashierOrderForm_payBtn.TabIndex = 29;
            cashierOrderForm_payBtn.Text = "PAY";
            cashierOrderForm_payBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_payBtn.Click += cashierOrderForm_payBtn_Click;
            // 
            // cashierOrderForm_change
            // 
            cashierOrderForm_change.AutoSize = true;
            cashierOrderForm_change.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrderForm_change.Location = new Point(198, 483);
            cashierOrderForm_change.Name = "cashierOrderForm_change";
            cashierOrderForm_change.Size = new Size(16, 18);
            cashierOrderForm_change.TabIndex = 28;
            cashierOrderForm_change.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(103, 483);
            label13.Name = "label13";
            label13.Size = new Size(89, 18);
            label13.TabIndex = 27;
            label13.Text = "Change ($):";
            // 
            // cashierOrderForm_amount
            // 
            cashierOrderForm_amount.BorderStyle = BorderStyle.FixedSingle;
            cashierOrderForm_amount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_amount.Location = new Point(198, 444);
            cashierOrderForm_amount.Name = "cashierOrderForm_amount";
            cashierOrderForm_amount.Size = new Size(128, 26);
            cashierOrderForm_amount.TabIndex = 26;
            cashierOrderForm_amount.TextChanged += cashierOrderForm_amount_TextChanged;
            cashierOrderForm_amount.KeyDown += cashierOrderForm_amount_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(105, 449);
            label11.Name = "label11";
            label11.Size = new Size(87, 18);
            label11.TabIndex = 25;
            label11.Text = "Amount ($):";
            // 
            // cashierOrderForm_orderPrice
            // 
            cashierOrderForm_orderPrice.AutoSize = true;
            cashierOrderForm_orderPrice.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashierOrderForm_orderPrice.Location = new Point(198, 416);
            cashierOrderForm_orderPrice.Name = "cashierOrderForm_orderPrice";
            cashierOrderForm_orderPrice.Size = new Size(16, 18);
            cashierOrderForm_orderPrice.TabIndex = 24;
            cashierOrderForm_orderPrice.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(125, 416);
            label10.Name = "label10";
            label10.Size = new Size(67, 18);
            label10.TabIndex = 23;
            label10.Text = "Price($):";
            // 
            // cashierOrderForm_orderTable
            // 
            cashierOrderForm_orderTable.AllowUserToAddRows = false;
            cashierOrderForm_orderTable.AllowUserToDeleteRows = false;
            cashierOrderForm_orderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cashierOrderForm_orderTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(7, 99, 102);
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            cashierOrderForm_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            cashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashierOrderForm_orderTable.EnableHeadersVisualStyles = false;
            cashierOrderForm_orderTable.Location = new Point(19, 33);
            cashierOrderForm_orderTable.Name = "cashierOrderForm_orderTable";
            cashierOrderForm_orderTable.ReadOnly = true;
            cashierOrderForm_orderTable.RowHeadersVisible = false;
            cashierOrderForm_orderTable.Size = new Size(346, 334);
            cashierOrderForm_orderTable.TabIndex = 5;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // CashierOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CashierOrderForm";
            Size = new Size(1251, 745);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_menuTable).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_quantity).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_orderTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView cashierOrderForm_menuTable;
        private Label label1;
        private ComboBox cashierOrderForm_productID;
        private Label label2;
        private ComboBox cashierOrderForm_type;
        private Label label5;
        private Label cashierOrderForm_price;
        private Label label8;
        private Label label6;
        private NumericUpDown cashierOrderForm_quantity;
        private Label cashierOrderForm_prodName;
        private Label label3;
        private Button cashierOrderForm_clearBtn;
        private Button cashierOrderForm_removeBtn;
        private Button cashierOrderForm_addBtn;
        private Label cashierOrderForm_orderPrice;
        private Label label10;
        private DataGridView cashierOrderForm_orderTable;
        private TextBox cashierOrderForm_amount;
        private Label label11;
        private Button cashierOrderForm_receiptBtn;
        private Button cashierOrderForm_payBtn;
        private Label cashierOrderForm_change;
        private Label label13;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}

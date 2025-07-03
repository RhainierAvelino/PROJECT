namespace Smart_Stock_Project
{
    partial class CashierOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.available_products_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierOrder_ClearBtn = new System.Windows.Forms.Button();
            this.cashierOrder_RemoveBtn = new System.Windows.Forms.Button();
            this.cashierOrder_AddBtn = new System.Windows.Forms.Button();
            this.cashierOrder_prodID = new System.Windows.Forms.ComboBox();
            this.cashierOrder_qty = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cashierOrder_price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cashierOrder_prodName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cashierOrder_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.cashierOrder_receipt = new System.Windows.Forms.Button();
            this.cashierOrder_payOrders = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cashierOrder_change = new System.Windows.Forms.Label();
            this.cashierOrder_amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cashierOrder_totalPrice = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.available_products_label);
            this.panel1.Location = new System.Drawing.Point(21, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 343);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(19, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(647, 275);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // available_products_label
            // 
            this.available_products_label.AutoSize = true;
            this.available_products_label.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_products_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.available_products_label.Location = new System.Drawing.Point(223, 13);
            this.available_products_label.Name = "available_products_label";
            this.available_products_label.Size = new System.Drawing.Size(227, 27);
            this.available_products_label.TabIndex = 30;
            this.available_products_label.Text = "AVAILABLE PRODUCTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cashierOrder_ClearBtn);
            this.panel2.Controls.Add(this.cashierOrder_RemoveBtn);
            this.panel2.Controls.Add(this.cashierOrder_AddBtn);
            this.panel2.Controls.Add(this.cashierOrder_prodID);
            this.panel2.Controls.Add(this.cashierOrder_qty);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cashierOrder_price);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cashierOrder_prodName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cashierOrder_category);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(21, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 343);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 27);
            this.label3.TabIndex = 32;
            this.label3.Text = "SELECT YOUR ORDERS";
            // 
            // cashierOrder_ClearBtn
            // 
            this.cashierOrder_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.cashierOrder_ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashierOrder_ClearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_ClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_ClearBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_ClearBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrder_ClearBtn.Location = new System.Drawing.Point(442, 246);
            this.cashierOrder_ClearBtn.Name = "cashierOrder_ClearBtn";
            this.cashierOrder_ClearBtn.Size = new System.Drawing.Size(118, 46);
            this.cashierOrder_ClearBtn.TabIndex = 28;
            this.cashierOrder_ClearBtn.Text = "CLEAR";
            this.cashierOrder_ClearBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_ClearBtn.Click += new System.EventHandler(this.cashierOrder_ClearBtn_Click);
            // 
            // cashierOrder_RemoveBtn
            // 
            this.cashierOrder_RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.cashierOrder_RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashierOrder_RemoveBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_RemoveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_RemoveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_RemoveBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_RemoveBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrder_RemoveBtn.Location = new System.Drawing.Point(273, 246);
            this.cashierOrder_RemoveBtn.Name = "cashierOrder_RemoveBtn";
            this.cashierOrder_RemoveBtn.Size = new System.Drawing.Size(118, 46);
            this.cashierOrder_RemoveBtn.TabIndex = 27;
            this.cashierOrder_RemoveBtn.Text = "REMOVE";
            this.cashierOrder_RemoveBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_RemoveBtn.Click += new System.EventHandler(this.cashierOrder_RemoveBtn_Click);
            // 
            // cashierOrder_AddBtn
            // 
            this.cashierOrder_AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.cashierOrder_AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashierOrder_AddBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_AddBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_AddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrder_AddBtn.Location = new System.Drawing.Point(105, 246);
            this.cashierOrder_AddBtn.Name = "cashierOrder_AddBtn";
            this.cashierOrder_AddBtn.Size = new System.Drawing.Size(118, 46);
            this.cashierOrder_AddBtn.TabIndex = 25;
            this.cashierOrder_AddBtn.Text = "ADD";
            this.cashierOrder_AddBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_AddBtn.Click += new System.EventHandler(this.cashierOrder_AddBtn_Click);
            // 
            // cashierOrder_prodID
            // 
            this.cashierOrder_prodID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_prodID.FormattingEnabled = true;
            this.cashierOrder_prodID.Location = new System.Drawing.Point(452, 61);
            this.cashierOrder_prodID.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrder_prodID.Name = "cashierOrder_prodID";
            this.cashierOrder_prodID.Size = new System.Drawing.Size(204, 30);
            this.cashierOrder_prodID.TabIndex = 16;
            this.cashierOrder_prodID.SelectedIndexChanged += new System.EventHandler(this.cashierOrder_prodID_SelectedIndexChanged);
            // 
            // cashierOrder_qty
            // 
            this.cashierOrder_qty.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.cashierOrder_qty.Location = new System.Drawing.Point(452, 146);
            this.cashierOrder_qty.Name = "cashierOrder_qty";
            this.cashierOrder_qty.Size = new System.Drawing.Size(204, 26);
            this.cashierOrder_qty.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(358, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantity:";
            // 
            // cashierOrder_price
            // 
            this.cashierOrder_price.AutoSize = true;
            this.cashierOrder_price.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrder_price.Location = new System.Drawing.Point(220, 187);
            this.cashierOrder_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashierOrder_price.Name = "cashierOrder_price";
            this.cashierOrder_price.Size = new System.Drawing.Size(34, 24);
            this.cashierOrder_price.TabIndex = 13;
            this.cashierOrder_price.Text = "    ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(111, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price (₱):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cashierOrder_prodName
            // 
            this.cashierOrder_prodName.AutoSize = true;
            this.cashierOrder_prodName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_prodName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrder_prodName.Location = new System.Drawing.Point(220, 146);
            this.cashierOrder_prodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashierOrder_prodName.Name = "cashierOrder_prodName";
            this.cashierOrder_prodName.Size = new System.Drawing.Size(34, 24);
            this.cashierOrder_prodName.TabIndex = 11;
            this.cashierOrder_prodName.Text = "    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(60, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = " Product Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(343, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product ID:";
            // 
            // cashierOrder_category
            // 
            this.cashierOrder_category.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_category.FormattingEnabled = true;
            this.cashierOrder_category.Location = new System.Drawing.Point(105, 62);
            this.cashierOrder_category.Margin = new System.Windows.Forms.Padding(2);
            this.cashierOrder_category.Name = "cashierOrder_category";
            this.cashierOrder_category.Size = new System.Drawing.Size(225, 30);
            this.cashierOrder_category.TabIndex = 7;
            this.cashierOrder_category.SelectedIndexChanged += new System.EventHandler(this.cashierOrder_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cashierOrder_receipt);
            this.panel3.Controls.Add(this.cashierOrder_payOrders);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cashierOrder_change);
            this.panel3.Controls.Add(this.cashierOrder_amount);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cashierOrder_totalPrice);
            this.panel3.Location = new System.Drawing.Point(716, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 701);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(20, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(353, 294);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(131, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 27);
            this.label13.TabIndex = 31;
            this.label13.Text = "ALL ORDERS";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cashierOrder_receipt
            // 
            this.cashierOrder_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.cashierOrder_receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashierOrder_receipt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_receipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_receipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_receipt.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_receipt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrder_receipt.Location = new System.Drawing.Point(20, 597);
            this.cashierOrder_receipt.Name = "cashierOrder_receipt";
            this.cashierOrder_receipt.Size = new System.Drawing.Size(353, 56);
            this.cashierOrder_receipt.TabIndex = 35;
            this.cashierOrder_receipt.Text = "RECEIPT";
            this.cashierOrder_receipt.UseVisualStyleBackColor = false;
            this.cashierOrder_receipt.Click += new System.EventHandler(this.cashierOrder_receipt_Click);
            // 
            // cashierOrder_payOrders
            // 
            this.cashierOrder_payOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.cashierOrder_payOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cashierOrder_payOrders.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_payOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_payOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.cashierOrder_payOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_payOrders.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_payOrders.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrder_payOrders.Location = new System.Drawing.Point(20, 523);
            this.cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            this.cashierOrder_payOrders.Size = new System.Drawing.Size(353, 56);
            this.cashierOrder_payOrders.TabIndex = 29;
            this.cashierOrder_payOrders.Text = "PAY ORDERS";
            this.cashierOrder_payOrders.UseVisualStyleBackColor = false;
            this.cashierOrder_payOrders.Click += new System.EventHandler(this.cashierOrder_payOrders_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(88, 458);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Change (₱):";
            // 
            // cashierOrder_change
            // 
            this.cashierOrder_change.AutoSize = true;
            this.cashierOrder_change.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_change.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrder_change.Location = new System.Drawing.Point(206, 458);
            this.cashierOrder_change.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashierOrder_change.Name = "cashierOrder_change";
            this.cashierOrder_change.Size = new System.Drawing.Size(47, 24);
            this.cashierOrder_change.TabIndex = 34;
            this.cashierOrder_change.Text = "0.00";
            // 
            // cashierOrder_amount
            // 
            this.cashierOrder_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashierOrder_amount.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.cashierOrder_amount.Location = new System.Drawing.Point(210, 410);
            this.cashierOrder_amount.Name = "cashierOrder_amount";
            this.cashierOrder_amount.Size = new System.Drawing.Size(163, 26);
            this.cashierOrder_amount.TabIndex = 32;
            this.cashierOrder_amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.cashierOrder_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrder_amount_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(84, 414);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Amount (₱):";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(59, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total Price (₱):";
            // 
            // cashierOrder_totalPrice
            // 
            this.cashierOrder_totalPrice.AutoSize = true;
            this.cashierOrder_totalPrice.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_totalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrder_totalPrice.Location = new System.Drawing.Point(206, 371);
            this.cashierOrder_totalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            this.cashierOrder_totalPrice.Size = new System.Drawing.Size(47, 24);
            this.cashierOrder_totalPrice.TabIndex = 30;
            this.cashierOrder_totalPrice.Text = "0.00";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // CashierOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrders";
            this.Size = new System.Drawing.Size(1121, 738);
            this.Load += new System.EventHandler(this.CashierOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label available_products_label;
        private System.Windows.Forms.ComboBox cashierOrder_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cashierOrder_prodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cashierOrder_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cashierOrder_prodID;
        private System.Windows.Forms.NumericUpDown cashierOrder_qty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cashierOrder_ClearBtn;
        private System.Windows.Forms.Button cashierOrder_RemoveBtn;
        private System.Windows.Forms.Button cashierOrder_AddBtn;
        private System.Windows.Forms.TextBox cashierOrder_amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label cashierOrder_totalPrice;
        private System.Windows.Forms.Button cashierOrder_receipt;
        private System.Windows.Forms.Button cashierOrder_payOrders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cashierOrder_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

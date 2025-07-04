namespace Smart_Stock_Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear_product_button = new System.Windows.Forms.Button();
            this.remove_product_button = new System.Windows.Forms.Button();
            this.update_product_button = new System.Windows.Forms.Button();
            this.add_product_button = new System.Windows.Forms.Button();
            this.add_product_import = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.add_product_image = new System.Windows.Forms.PictureBox();
            this.add_product_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_product_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add_product_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_product_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_product_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_productID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_product_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 344);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 275);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALL PRODUCTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.clear_product_button);
            this.panel2.Controls.Add(this.remove_product_button);
            this.panel2.Controls.Add(this.update_product_button);
            this.panel2.Controls.Add(this.add_product_button);
            this.panel2.Controls.Add(this.add_product_import);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.add_product_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.add_product_stock);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.add_product_price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.add_product_category);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.add_product_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.add_productID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(11, 379);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 344);
            this.panel2.TabIndex = 1;
            // 
            // clear_product_button
            // 
            this.clear_product_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clear_product_button.FlatAppearance.BorderSize = 0;
            this.clear_product_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.clear_product_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.clear_product_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_product_button.Location = new System.Drawing.Point(741, 239);
            this.clear_product_button.Margin = new System.Windows.Forms.Padding(2);
            this.clear_product_button.Name = "clear_product_button";
            this.clear_product_button.Size = new System.Drawing.Size(127, 51);
            this.clear_product_button.TabIndex = 17;
            this.clear_product_button.Text = "Clear";
            this.clear_product_button.UseVisualStyleBackColor = false;
            this.clear_product_button.Click += new System.EventHandler(this.clear_product_button_Click);
            // 
            // remove_product_button
            // 
            this.remove_product_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.remove_product_button.FlatAppearance.BorderSize = 0;
            this.remove_product_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.remove_product_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.remove_product_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_product_button.Location = new System.Drawing.Point(544, 239);
            this.remove_product_button.Margin = new System.Windows.Forms.Padding(2);
            this.remove_product_button.Name = "remove_product_button";
            this.remove_product_button.Size = new System.Drawing.Size(127, 51);
            this.remove_product_button.TabIndex = 16;
            this.remove_product_button.Text = "Remove";
            this.remove_product_button.UseVisualStyleBackColor = false;
            this.remove_product_button.Click += new System.EventHandler(this.remove_product_button_Click);
            // 
            // update_product_button
            // 
            this.update_product_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.update_product_button.FlatAppearance.BorderSize = 0;
            this.update_product_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.update_product_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.update_product_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_product_button.Location = new System.Drawing.Point(308, 239);
            this.update_product_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_product_button.Name = "update_product_button";
            this.update_product_button.Size = new System.Drawing.Size(127, 51);
            this.update_product_button.TabIndex = 15;
            this.update_product_button.Text = "Update";
            this.update_product_button.UseVisualStyleBackColor = false;
            this.update_product_button.Click += new System.EventHandler(this.update_product_button_Click);
            // 
            // add_product_button
            // 
            this.add_product_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add_product_button.FlatAppearance.BorderSize = 0;
            this.add_product_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_product_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_product_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_button.Location = new System.Drawing.Point(110, 239);
            this.add_product_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_button.Name = "add_product_button";
            this.add_product_button.Size = new System.Drawing.Size(127, 51);
            this.add_product_button.TabIndex = 14;
            this.add_product_button.Text = "Add";
            this.add_product_button.UseVisualStyleBackColor = false;
            this.add_product_button.Click += new System.EventHandler(this.add_product_button_Click);
            // 
            // add_product_import
            // 
            this.add_product_import.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add_product_import.FlatAppearance.BorderSize = 0;
            this.add_product_import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_product_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_product_import.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_import.Location = new System.Drawing.Point(964, 163);
            this.add_product_import.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_import.Name = "add_product_import";
            this.add_product_import.Size = new System.Drawing.Size(102, 35);
            this.add_product_import.TabIndex = 13;
            this.add_product_import.Text = "Import";
            this.add_product_import.UseVisualStyleBackColor = false;
            this.add_product_import.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.add_product_image);
            this.panel3.Location = new System.Drawing.Point(964, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 117);
            this.panel3.TabIndex = 12;
            // 
            // add_product_image
            // 
            this.add_product_image.Location = new System.Drawing.Point(0, 0);
            this.add_product_image.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_image.Name = "add_product_image";
            this.add_product_image.Size = new System.Drawing.Size(102, 117);
            this.add_product_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_product_image.TabIndex = 0;
            this.add_product_image.TabStop = false;
            // 
            // add_product_status
            // 
            this.add_product_status.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_status.FormattingEnabled = true;
            this.add_product_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.add_product_status.Location = new System.Drawing.Point(602, 131);
            this.add_product_status.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_status.Name = "add_product_status";
            this.add_product_status.Size = new System.Drawing.Size(225, 30);
            this.add_product_status.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(527, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // add_product_stock
            // 
            this.add_product_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_product_stock.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_stock.Location = new System.Drawing.Point(602, 84);
            this.add_product_stock.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_stock.Name = "add_product_stock";
            this.add_product_stock.Size = new System.Drawing.Size(225, 26);
            this.add_product_stock.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(534, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock:";
            // 
            // add_product_price
            // 
            this.add_product_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_product_price.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_price.Location = new System.Drawing.Point(602, 42);
            this.add_product_price.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_price.Name = "add_product_price";
            this.add_product_price.Size = new System.Drawing.Size(225, 26);
            this.add_product_price.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(540, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price:";
            // 
            // add_product_category
            // 
            this.add_product_category.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_category.FormattingEnabled = true;
            this.add_product_category.Location = new System.Drawing.Point(176, 130);
            this.add_product_category.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_category.Name = "add_product_category";
            this.add_product_category.Size = new System.Drawing.Size(225, 30);
            this.add_product_category.TabIndex = 5;
            this.add_product_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(80, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category:";
            // 
            // add_product_name
            // 
            this.add_product_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_product_name.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_product_name.Location = new System.Drawing.Point(176, 85);
            this.add_product_name.Margin = new System.Windows.Forms.Padding(2);
            this.add_product_name.Name = "add_product_name";
            this.add_product_name.Size = new System.Drawing.Size(225, 26);
            this.add_product_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(36, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // add_productID
            // 
            this.add_productID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_productID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_productID.Location = new System.Drawing.Point(176, 41);
            this.add_productID.Margin = new System.Windows.Forms.Padding(2);
            this.add_productID.Name = "add_productID";
            this.add_productID.Size = new System.Drawing.Size(225, 26);
            this.add_productID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(67, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(1121, 738);
            this.Load += new System.EventHandler(this.AdminAddProducts_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.add_product_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox add_product_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox add_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox add_product_category;
        private System.Windows.Forms.ComboBox add_product_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox add_product_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox add_product_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button add_product_import;
        private System.Windows.Forms.PictureBox add_product_image;
        private System.Windows.Forms.Button clear_product_button;
        private System.Windows.Forms.Button remove_product_button;
        private System.Windows.Forms.Button update_product_button;
        private System.Windows.Forms.Button add_product_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

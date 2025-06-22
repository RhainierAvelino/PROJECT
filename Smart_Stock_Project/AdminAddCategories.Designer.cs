namespace Smart_Stock_Project
{
    partial class AdminAddCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inventoryDataSet1 = new Smart_Stock_Project.inventoryDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.remove_category_button = new System.Windows.Forms.Button();
            this.update_category_button = new System.Windows.Forms.Button();
            this.add_category_button = new System.Windows.Forms.Button();
            this.addCategories_category = new System.Windows.Forms.TextBox();
            this.add_username_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_category_button = new System.Windows.Forms.Button();
            this.all_user_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryDataSet1
            // 
            this.inventoryDataSet1.DataSetName = "inventoryDataSet";
            this.inventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(892, 736);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // remove_category_button
            // 
            this.remove_category_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.remove_category_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_category_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.remove_category_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.remove_category_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.remove_category_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_category_button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_category_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remove_category_button.Location = new System.Drawing.Point(29, 274);
            this.remove_category_button.Margin = new System.Windows.Forms.Padding(4);
            this.remove_category_button.Name = "remove_category_button";
            this.remove_category_button.Size = new System.Drawing.Size(157, 57);
            this.remove_category_button.TabIndex = 23;
            this.remove_category_button.Text = "REMOVE";
            this.remove_category_button.UseVisualStyleBackColor = false;
            this.remove_category_button.Click += new System.EventHandler(this.remove_category_button_Click);
            // 
            // update_category_button
            // 
            this.update_category_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.update_category_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_category_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.update_category_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.update_category_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.update_category_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_category_button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_category_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_category_button.Location = new System.Drawing.Point(217, 195);
            this.update_category_button.Margin = new System.Windows.Forms.Padding(4);
            this.update_category_button.Name = "update_category_button";
            this.update_category_button.Size = new System.Drawing.Size(157, 57);
            this.update_category_button.TabIndex = 22;
            this.update_category_button.Text = "UPDATE";
            this.update_category_button.UseVisualStyleBackColor = false;
            this.update_category_button.Click += new System.EventHandler(this.update_category_button_Click);
            // 
            // add_category_button
            // 
            this.add_category_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.add_category_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_category_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_category_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_category_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_category_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_category_button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_category_button.Location = new System.Drawing.Point(29, 195);
            this.add_category_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_category_button.Name = "add_category_button";
            this.add_category_button.Size = new System.Drawing.Size(157, 57);
            this.add_category_button.TabIndex = 21;
            this.add_category_button.Text = "ADD";
            this.add_category_button.UseVisualStyleBackColor = false;
            this.add_category_button.Click += new System.EventHandler(this.add_category_button_Click);
            // 
            // addCategories_category
            // 
            this.addCategories_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCategories_category.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_category.Location = new System.Drawing.Point(24, 118);
            this.addCategories_category.Margin = new System.Windows.Forms.Padding(4);
            this.addCategories_category.Name = "addCategories_category";
            this.addCategories_category.Size = new System.Drawing.Size(362, 31);
            this.addCategories_category.TabIndex = 15;
            // 
            // add_username_label
            // 
            this.add_username_label.AutoSize = true;
            this.add_username_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_username_label.Location = new System.Drawing.Point(20, 87);
            this.add_username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add_username_label.Name = "add_username_label";
            this.add_username_label.Size = new System.Drawing.Size(96, 26);
            this.add_username_label.TabIndex = 14;
            this.add_username_label.Text = "Category";
            this.add_username_label.Click += new System.EventHandler(this.add_username_label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.clear_category_button);
            this.panel1.Controls.Add(this.remove_category_button);
            this.panel1.Controls.Add(this.update_category_button);
            this.panel1.Controls.Add(this.add_category_button);
            this.panel1.Controls.Add(this.addCategories_category);
            this.panel1.Controls.Add(this.add_username_label);
            this.panel1.Location = new System.Drawing.Point(43, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 850);
            this.panel1.TabIndex = 2;
            // 
            // clear_category_button
            // 
            this.clear_category_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.clear_category_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_category_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.clear_category_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.clear_category_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.clear_category_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_category_button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_category_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear_category_button.Location = new System.Drawing.Point(217, 274);
            this.clear_category_button.Margin = new System.Windows.Forms.Padding(4);
            this.clear_category_button.Name = "clear_category_button";
            this.clear_category_button.Size = new System.Drawing.Size(157, 57);
            this.clear_category_button.TabIndex = 24;
            this.clear_category_button.Text = "CLEAR";
            this.clear_category_button.UseVisualStyleBackColor = false;
            this.clear_category_button.Click += new System.EventHandler(this.clear_category_button_Click);
            // 
            // all_user_label
            // 
            this.all_user_label.AutoSize = true;
            this.all_user_label.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_user_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.all_user_label.Location = new System.Drawing.Point(24, 27);
            this.all_user_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.all_user_label.Name = "all_user_label";
            this.all_user_label.Size = new System.Drawing.Size(281, 43);
            this.all_user_label.TabIndex = 12;
            this.all_user_label.Text = "ALL CATEGORIES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.all_user_label);
            this.panel2.Location = new System.Drawing.Point(500, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 850);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AdminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminAddCategories";
            this.Size = new System.Drawing.Size(1495, 908);
            this.Load += new System.EventHandler(this.AdminAddCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private inventoryDataSet inventoryDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button remove_category_button;
        private System.Windows.Forms.Button update_category_button;
        private System.Windows.Forms.Button add_category_button;
        private System.Windows.Forms.TextBox addCategories_category;
        private System.Windows.Forms.Label add_username_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label all_user_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clear_category_button;
    }
}

namespace Smart_Stock_Project
{
    partial class AdminAddUsers
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
            this.clear_user_button = new System.Windows.Forms.Button();
            this.remove_user_button = new System.Windows.Forms.Button();
            this.update_user_button = new System.Windows.Forms.Button();
            this.add_user_button = new System.Windows.Forms.Button();
            this.addUsers_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addUsers_role = new System.Windows.Forms.ComboBox();
            this.role_label = new System.Windows.Forms.Label();
            this.addUsers_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUsers_username = new System.Windows.Forms.TextBox();
            this.add_username_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.all_user_label = new System.Windows.Forms.Label();
            this.inventoryDataSet1 = new Smart_Stock_Project.inventoryDataSet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.clear_user_button);
            this.panel1.Controls.Add(this.remove_user_button);
            this.panel1.Controls.Add(this.update_user_button);
            this.panel1.Controls.Add(this.add_user_button);
            this.panel1.Controls.Add(this.addUsers_status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addUsers_role);
            this.panel1.Controls.Add(this.role_label);
            this.panel1.Controls.Add(this.addUsers_password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addUsers_username);
            this.panel1.Controls.Add(this.add_username_label);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 691);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clear_user_button
            // 
            this.clear_user_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.clear_user_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_user_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.clear_user_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.clear_user_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.clear_user_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_user_button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_user_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear_user_button.Location = new System.Drawing.Point(166, 455);
            this.clear_user_button.Name = "clear_user_button";
            this.clear_user_button.Size = new System.Drawing.Size(118, 46);
            this.clear_user_button.TabIndex = 24;
            this.clear_user_button.Text = "CLEAR";
            this.clear_user_button.UseVisualStyleBackColor = false;
            this.clear_user_button.Click += new System.EventHandler(this.clear_user_button_Click);
            // 
            // remove_user_button
            // 
            this.remove_user_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.remove_user_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_user_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.remove_user_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.remove_user_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.remove_user_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_user_button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_user_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remove_user_button.Location = new System.Drawing.Point(25, 455);
            this.remove_user_button.Name = "remove_user_button";
            this.remove_user_button.Size = new System.Drawing.Size(118, 46);
            this.remove_user_button.TabIndex = 23;
            this.remove_user_button.Text = "REMOVE";
            this.remove_user_button.UseVisualStyleBackColor = false;
            this.remove_user_button.Click += new System.EventHandler(this.remove_user_button_Click);
            // 
            // update_user_button
            // 
            this.update_user_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.update_user_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_user_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.update_user_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.update_user_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.update_user_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_user_button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_user_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_user_button.Location = new System.Drawing.Point(166, 391);
            this.update_user_button.Name = "update_user_button";
            this.update_user_button.Size = new System.Drawing.Size(118, 46);
            this.update_user_button.TabIndex = 22;
            this.update_user_button.Text = "UPDATE";
            this.update_user_button.UseVisualStyleBackColor = false;
            this.update_user_button.Click += new System.EventHandler(this.update_user_button_Click);
            // 
            // add_user_button
            // 
            this.add_user_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.add_user_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_user_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_user_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_user_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.add_user_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_user_button.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_user_button.Location = new System.Drawing.Point(25, 391);
            this.add_user_button.Name = "add_user_button";
            this.add_user_button.Size = new System.Drawing.Size(118, 46);
            this.add_user_button.TabIndex = 21;
            this.add_user_button.Text = "ADD";
            this.add_user_button.UseVisualStyleBackColor = false;
            this.add_user_button.Click += new System.EventHandler(this.add_user_button_Click);
            // 
            // addUsers_status
            // 
            this.addUsers_status.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_status.FormattingEnabled = true;
            this.addUsers_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.addUsers_status.Location = new System.Drawing.Point(19, 302);
            this.addUsers_status.Name = "addUsers_status";
            this.addUsers_status.Size = new System.Drawing.Size(271, 30);
            this.addUsers_status.TabIndex = 19;
            this.addUsers_status.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addUsers_role
            // 
            this.addUsers_role.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_role.FormattingEnabled = true;
            this.addUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.addUsers_role.Location = new System.Drawing.Point(19, 230);
            this.addUsers_role.Name = "addUsers_role";
            this.addUsers_role.Size = new System.Drawing.Size(271, 30);
            this.addUsers_role.TabIndex = 0;
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.role_label.Location = new System.Drawing.Point(15, 205);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(49, 22);
            this.role_label.TabIndex = 18;
            this.role_label.Text = "Role:";
            // 
            // addUsers_password
            // 
            this.addUsers_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addUsers_password.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_password.Location = new System.Drawing.Point(18, 163);
            this.addUsers_password.Name = "addUsers_password";
            this.addUsers_password.Size = new System.Drawing.Size(272, 26);
            this.addUsers_password.TabIndex = 17;
            this.addUsers_password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addUsers_username
            // 
            this.addUsers_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addUsers_username.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_username.Location = new System.Drawing.Point(18, 96);
            this.addUsers_username.Name = "addUsers_username";
            this.addUsers_username.Size = new System.Drawing.Size(272, 26);
            this.addUsers_username.TabIndex = 15;
            // 
            // add_username_label
            // 
            this.add_username_label.AutoSize = true;
            this.add_username_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_username_label.Location = new System.Drawing.Point(15, 71);
            this.add_username_label.Name = "add_username_label";
            this.add_username_label.Size = new System.Drawing.Size(91, 22);
            this.add_username_label.TabIndex = 14;
            this.add_username_label.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.all_user_label);
            this.panel2.Location = new System.Drawing.Point(373, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 691);
            this.panel2.TabIndex = 1;
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
            this.dataGridView1.Location = new System.Drawing.Point(24, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(669, 598);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // all_user_label
            // 
            this.all_user_label.AutoSize = true;
            this.all_user_label.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_user_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.all_user_label.Location = new System.Drawing.Point(18, 22);
            this.all_user_label.Name = "all_user_label";
            this.all_user_label.Size = new System.Drawing.Size(226, 35);
            this.all_user_label.TabIndex = 12;
            this.all_user_label.Text = "ALL USER\'S DATA";
            // 
            // inventoryDataSet1
            // 
            this.inventoryDataSet1.DataSetName = "inventoryDataSet";
            this.inventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddUsers";
            this.Size = new System.Drawing.Size(1121, 738);
            this.Load += new System.EventHandler(this.AdminAddUsers_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addUsers_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addUsers_username;
        private System.Windows.Forms.Label add_username_label;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.ComboBox addUsers_role;
        private System.Windows.Forms.ComboBox addUsers_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear_user_button;
        private System.Windows.Forms.Button remove_user_button;
        private System.Windows.Forms.Button update_user_button;
        private System.Windows.Forms.Button add_user_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label all_user_label;
        private inventoryDataSet inventoryDataSet1;
    }
}

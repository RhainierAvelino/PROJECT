namespace Smart_Stock_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.smartstock_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.adminAddCategories1 = new Smart_Stock_Project.AdminAddCategories();
            this.adminAddUsers1 = new Smart_Stock_Project.AdminAddUsers();
            this.adminAddProducts1 = new Smart_Stock_Project.AdminAddProducts();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.smartstock_label);
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1739, 69);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(772, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 38);
            this.label2.TabIndex = 30;
            this.label2.Text = "Smart Stock";
            // 
            // smartstock_label
            // 
            this.smartstock_label.AutoSize = true;
            this.smartstock_label.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartstock_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.smartstock_label.Location = new System.Drawing.Point(23, 18);
            this.smartstock_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smartstock_label.Name = "smartstock_label";
            this.smartstock_label.Size = new System.Drawing.Size(222, 35);
            this.smartstock_label.TabIndex = 29;
            this.smartstock_label.Text = "ADMIN\'S PORTAL";
            this.smartstock_label.Click += new System.EventHandler(this.register_label_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.IndianRed;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.Control;
            this.exit_button.Location = new System.Drawing.Point(1644, 15);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(79, 41);
            this.exit_button.TabIndex = 28;
            this.exit_button.Text = "❌";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.logout_button);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dashboard_button);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 908);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.logout_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout_button.Location = new System.Drawing.Point(16, 843);
            this.logout_button.Margin = new System.Windows.Forms.Padding(4);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(215, 50);
            this.logout_button.TabIndex = 36;
            this.logout_button.Text = "LOGOUT";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(4, 484);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 50);
            this.button4.TabIndex = 35;
            this.button4.Text = "CUSTOMERS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 50);
            this.button2.TabIndex = 34;
            this.button2.Text = "ADD PRODUCTS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 368);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 50);
            this.button3.TabIndex = 33;
            this.button3.Text = "ADD CATEGORIES";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 50);
            this.button1.TabIndex = 32;
            this.button1.Text = "ADD USERS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.FlatAppearance.BorderSize = 0;
            this.dashboard_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.dashboard_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.dashboard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_button.Location = new System.Drawing.Point(4, 252);
            this.dashboard_button.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(236, 50);
            this.dashboard_button.TabIndex = 2;
            this.dashboard_button.Text = "DASHBOARD";
            this.dashboard_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(56, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "WELCOME!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(19, -9);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 185);
            this.logo.TabIndex = 30;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(244, 69);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1495, 908);
            this.adminAddCategories1.TabIndex = 3;
            this.adminAddCategories1.Load += new System.EventHandler(this.adminAddCategories1_Load);
            // 
            // adminAddUsers1
            // 
            this.adminAddUsers1.Location = new System.Drawing.Point(244, 69);
            this.adminAddUsers1.Margin = new System.Windows.Forms.Padding(5);
            this.adminAddUsers1.Name = "adminAddUsers1";
            this.adminAddUsers1.Size = new System.Drawing.Size(1495, 908);
            this.adminAddUsers1.TabIndex = 2;
            this.adminAddUsers1.Load += new System.EventHandler(this.adminAddUsers1_Load_1);
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(244, 69);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1495, 908);
            this.adminAddProducts1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 977);
            this.Controls.Add(this.adminAddProducts1);
            this.Controls.Add(this.adminAddCategories1);
            this.Controls.Add(this.adminAddUsers1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label smartstock_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AdminAddUsers adminAddUsers1;
        private AdminAddCategories adminAddCategories1;
        private AdminAddProducts adminAddProducts1;
    }
}
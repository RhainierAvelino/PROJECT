﻿namespace Smart_Stock_Project
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
            this.sales_forecasting_button = new System.Windows.Forms.Button();
            this.AprioriAnalysis_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.salesForecasting1 = new Smart_Stock_Project.SalesForecasting();
            this.aprioriAnalysis1 = new Smart_Stock_Project.AprioriAnalysis();
            this.adminAddUsers1 = new Smart_Stock_Project.AdminAddUsers();
            this.adminAddCategories1 = new Smart_Stock_Project.AdminAddCategories();
            this.adminAddProducts1 = new Smart_Stock_Project.AdminAddProducts();
            this.cashierCustomersForm1 = new Smart_Stock_Project.CashierCustomersForm();
            this.csvDataSeeder1 = new Smart_Stock_Project.CSVDataSeeder();
            this.adminDashboard1 = new Smart_Stock_Project.AdminDashboard();
            this.csvbutton = new System.Windows.Forms.Button();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 56);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(579, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Smart Stock";
            // 
            // smartstock_label
            // 
            this.smartstock_label.AutoSize = true;
            this.smartstock_label.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartstock_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.smartstock_label.Location = new System.Drawing.Point(17, 15);
            this.smartstock_label.Name = "smartstock_label";
            this.smartstock_label.Size = new System.Drawing.Size(172, 27);
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
            this.exit_button.Location = new System.Drawing.Point(1233, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(59, 33);
            this.exit_button.TabIndex = 28;
            this.exit_button.Text = "❌";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.csvbutton);
            this.panel2.Controls.Add(this.sales_forecasting_button);
            this.panel2.Controls.Add(this.AprioriAnalysis_button);
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
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 738);
            this.panel2.TabIndex = 1;
            // 
            // sales_forecasting_button
            // 
            this.sales_forecasting_button.FlatAppearance.BorderSize = 0;
            this.sales_forecasting_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.sales_forecasting_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.sales_forecasting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sales_forecasting_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_forecasting_button.Location = new System.Drawing.Point(3, 487);
            this.sales_forecasting_button.Name = "sales_forecasting_button";
            this.sales_forecasting_button.Size = new System.Drawing.Size(177, 41);
            this.sales_forecasting_button.TabIndex = 38;
            this.sales_forecasting_button.Text = "SALES FORECASTING";
            this.sales_forecasting_button.UseVisualStyleBackColor = true;
            this.sales_forecasting_button.Click += new System.EventHandler(this.sales_forecasting_button_Click);
            // 
            // AprioriAnalysis_button
            // 
            this.AprioriAnalysis_button.FlatAppearance.BorderSize = 0;
            this.AprioriAnalysis_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.AprioriAnalysis_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.AprioriAnalysis_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AprioriAnalysis_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AprioriAnalysis_button.Location = new System.Drawing.Point(3, 440);
            this.AprioriAnalysis_button.Name = "AprioriAnalysis_button";
            this.AprioriAnalysis_button.Size = new System.Drawing.Size(177, 41);
            this.AprioriAnalysis_button.TabIndex = 37;
            this.AprioriAnalysis_button.Text = "SMART BUNDLING";
            this.AprioriAnalysis_button.UseVisualStyleBackColor = true;
            this.AprioriAnalysis_button.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
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
            this.logout_button.Location = new System.Drawing.Point(12, 685);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(161, 41);
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
            this.button4.Location = new System.Drawing.Point(3, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 41);
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
            this.button2.Location = new System.Drawing.Point(3, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 41);
            this.button2.TabIndex = 34;
            this.button2.Text = "ADD PRODUCTS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 41);
            this.button3.TabIndex = 33;
            this.button3.Text = "ADD CATEGORIES";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 41);
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
            this.dashboard_button.Location = new System.Drawing.Point(3, 205);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(177, 41);
            this.dashboard_button.TabIndex = 2;
            this.dashboard_button.Text = "DASHBOARD";
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(47, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "WELCOME!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(14, -7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 150);
            this.logo.TabIndex = 30;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // salesForecasting1
            // 
            this.salesForecasting1.Location = new System.Drawing.Point(183, 56);
            this.salesForecasting1.Name = "salesForecasting1";
            this.salesForecasting1.Size = new System.Drawing.Size(1121, 738);
            this.salesForecasting1.TabIndex = 7;
            // 
            // aprioriAnalysis1
            // 
            this.aprioriAnalysis1.Location = new System.Drawing.Point(183, 56);
            this.aprioriAnalysis1.Name = "aprioriAnalysis1";
            this.aprioriAnalysis1.Size = new System.Drawing.Size(1121, 738);
            this.aprioriAnalysis1.TabIndex = 6;
            // 
            // adminAddUsers1
            // 
            this.adminAddUsers1.Location = new System.Drawing.Point(183, 56);
            this.adminAddUsers1.Name = "adminAddUsers1";
            this.adminAddUsers1.Size = new System.Drawing.Size(1121, 738);
            this.adminAddUsers1.TabIndex = 5;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(183, 56);
            this.adminAddCategories1.Margin = new System.Windows.Forms.Padding(2);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1121, 738);
            this.adminAddCategories1.TabIndex = 4;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(183, 56);
            this.adminAddProducts1.Margin = new System.Windows.Forms.Padding(2);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1121, 738);
            this.adminAddProducts1.TabIndex = 3;
            // 
            // cashierCustomersForm1
            // 
            this.cashierCustomersForm1.Location = new System.Drawing.Point(183, 56);
            this.cashierCustomersForm1.Name = "cashierCustomersForm1";
            this.cashierCustomersForm1.Size = new System.Drawing.Size(1121, 738);
            this.cashierCustomersForm1.TabIndex = 2;
            // 
            // csvDataSeeder1
            // 
            this.csvDataSeeder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.csvDataSeeder1.Location = new System.Drawing.Point(183, 56);
            this.csvDataSeeder1.Name = "csvDataSeeder1";
            this.csvDataSeeder1.Size = new System.Drawing.Size(1121, 738);
            this.csvDataSeeder1.TabIndex = 8;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(183, 56);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1121, 738);
            this.adminDashboard1.TabIndex = 9;
            // 
            // csvbutton
            // 
            this.csvbutton.FlatAppearance.BorderSize = 0;
            this.csvbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.csvbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(151)))));
            this.csvbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csvbutton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvbutton.Location = new System.Drawing.Point(0, 534);
            this.csvbutton.Name = "csvbutton";
            this.csvbutton.Size = new System.Drawing.Size(177, 41);
            this.csvbutton.TabIndex = 39;
            this.csvbutton.Text = "CSV SEEDER";
            this.csvbutton.UseVisualStyleBackColor = true;
            this.csvbutton.Click += new System.EventHandler(this.csvbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 794);
            this.Controls.Add(this.adminDashboard1);
            this.Controls.Add(this.csvDataSeeder1);
            this.Controls.Add(this.salesForecasting1);
            this.Controls.Add(this.aprioriAnalysis1);
            this.Controls.Add(this.adminAddUsers1);
            this.Controls.Add(this.adminAddCategories1);
            this.Controls.Add(this.adminAddProducts1);
            this.Controls.Add(this.cashierCustomersForm1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private CashierCustomersForm cashierCustomersForm1;
        private System.Windows.Forms.Button AprioriAnalysis_button;
        private AdminAddProducts adminAddProducts1;
        private AdminAddCategories adminAddCategories1;
        private AdminAddUsers adminAddUsers1;
        private AprioriAnalysis aprioriAnalysis1;
        private System.Windows.Forms.Button sales_forecasting_button;
        private SalesForecasting salesForecasting1;
        private CSVDataSeeder csvDataSeeder1;
        private AdminDashboard adminDashboard1;
        private System.Windows.Forms.Button csvbutton;
    }
}
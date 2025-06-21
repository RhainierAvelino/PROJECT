using System.Drawing;
using System.Windows.Forms;

namespace SmartStock_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.sign_up_link = new System.Windows.Forms.Label();
            this.no_account_label = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_username = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login_button.Location = new System.Drawing.Point(234, 356);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(223, 46);
            this.login_button.TabIndex = 18;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.IndianRed;
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.Control;
            this.exit_button.Location = new System.Drawing.Point(635, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(59, 33);
            this.exit_button.TabIndex = 17;
            this.exit_button.Text = "❌";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // sign_up_link
            // 
            this.sign_up_link.AutoSize = true;
            this.sign_up_link.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up_link.ForeColor = System.Drawing.Color.RoyalBlue;
            this.sign_up_link.Location = new System.Drawing.Point(389, 416);
            this.sign_up_link.Name = "sign_up_link";
            this.sign_up_link.Size = new System.Drawing.Size(58, 18);
            this.sign_up_link.TabIndex = 16;
            this.sign_up_link.Text = "SIGN UP";
            this.sign_up_link.Click += new System.EventHandler(this.sign_up_link_Click);
            // 
            // no_account_label
            // 
            this.no_account_label.AutoSize = true;
            this.no_account_label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_account_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.no_account_label.Location = new System.Drawing.Point(246, 416);
            this.no_account_label.Name = "no_account_label";
            this.no_account_label.Size = new System.Drawing.Size(152, 18);
            this.no_account_label.TabIndex = 15;
            this.no_account_label.Text = "Don’t have an account?  ";
            // 
            // login_password
            // 
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_password.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(150, 284);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(407, 32);
            this.login_password.TabIndex = 14;
            // 
            // login_username
            // 
            this.login_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_username.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(150, 213);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(407, 32);
            this.login_username.TabIndex = 13;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_label.Location = new System.Drawing.Point(150, 259);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(87, 22);
            this.password_label.TabIndex = 12;
            this.password_label.Text = "Password:";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_label.Location = new System.Drawing.Point(150, 188);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(91, 22);
            this.username_label.TabIndex = 11;
            this.username_label.Text = "Username:";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.login_label.Location = new System.Drawing.Point(150, 143);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(407, 40);
            this.login_label.TabIndex = 10;
            this.login_label.Text = "LOGIN TO YOUR ACCOUNT";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(259, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(157, 125);
            this.logo.TabIndex = 19;
            this.logo.TabStop = false;
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPass.Location = new System.Drawing.Point(154, 322);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(127, 24);
            this.login_showPass.TabIndex = 20;
            this.login_showPass.Text = "Show Password";
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(707, 476);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.sign_up_link);
            this.Controls.Add(this.no_account_label);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login_button;
        private Button exit_button;
        private Label sign_up_link;
        private Label no_account_label;
        private TextBox login_password;
        private TextBox login_username;
        private Label password_label;
        private Label username_label;
        private Label login_label;
        private PictureBox logo;
        private CheckBox login_showPass;
    }
}
namespace Smart_Stock_Project
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.signup_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.login_link = new System.Windows.Forms.Label();
            this.no_account_label = new System.Windows.Forms.Label();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_username = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.register_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.register_cPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.signup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup_button.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signup_button.Location = new System.Drawing.Point(226, 375);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(223, 46);
            this.signup_button.TabIndex = 28;
            this.signup_button.Text = "SIGN UP";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.login_button_Click);
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
            this.exit_button.TabIndex = 27;
            this.exit_button.Text = "❌";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // login_link
            // 
            this.login_link.AutoSize = true;
            this.login_link.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_link.ForeColor = System.Drawing.Color.RoyalBlue;
            this.login_link.Location = new System.Drawing.Point(386, 429);
            this.login_link.Name = "login_link";
            this.login_link.Size = new System.Drawing.Size(46, 18);
            this.login_link.TabIndex = 26;
            this.login_link.Text = "LOGIN";
            this.login_link.Click += new System.EventHandler(this.sign_up_link_Click);
            // 
            // no_account_label
            // 
            this.no_account_label.AutoSize = true;
            this.no_account_label.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_account_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.no_account_label.Location = new System.Drawing.Point(236, 429);
            this.no_account_label.Name = "no_account_label";
            this.no_account_label.Size = new System.Drawing.Size(163, 18);
            this.no_account_label.TabIndex = 25;
            this.no_account_label.Text = "Already have an account?  ";
            this.no_account_label.Click += new System.EventHandler(this.no_account_label_Click);
            // 
            // register_password
            // 
            this.register_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_password.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(142, 242);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(407, 32);
            this.register_password.TabIndex = 24;
            this.register_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // register_username
            // 
            this.register_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_username.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(142, 180);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(407, 32);
            this.register_username.TabIndex = 23;
            this.register_username.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_label.Location = new System.Drawing.Point(142, 217);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(87, 22);
            this.password_label.TabIndex = 22;
            this.password_label.Text = "Password:";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_label.Location = new System.Drawing.Point(142, 155);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(91, 22);
            this.username_label.TabIndex = 21;
            this.username_label.Text = "Username:";
            this.username_label.Click += new System.EventHandler(this.username_label_Click);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.register_label.Location = new System.Drawing.Point(153, 117);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(378, 40);
            this.register_label.TabIndex = 20;
            this.register_label.Text = "CREATE YOUR ACCOUNT";
            this.register_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(251, -12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(157, 125);
            this.logo.TabIndex = 29;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // register_cPassword
            // 
            this.register_cPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_cPassword.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_cPassword.Location = new System.Drawing.Point(142, 302);
            this.register_cPassword.Name = "register_cPassword";
            this.register_cPassword.PasswordChar = '*';
            this.register_cPassword.Size = new System.Drawing.Size(407, 32);
            this.register_cPassword.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(142, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Confirm Password:";
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showPass.Location = new System.Drawing.Point(146, 340);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(127, 24);
            this.register_showPass.TabIndex = 32;
            this.register_showPass.Text = "Show Password";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(707, 476);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.register_cPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_link);
            this.Controls.Add(this.no_account_label);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label login_link;
        private System.Windows.Forms.Label no_account_label;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox register_cPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox register_showPass;
    }
}
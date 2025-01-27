namespace Hotel_Management_System_WinFormsApp
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.register_ShowPassword = new System.Windows.Forms.CheckBox();
            this.register_SignUp = new System.Windows.Forms.Button();
            this.register_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.register_UserName = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.Label_Registration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.register_SignIn_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_SignIn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.register_Password = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_ShowPassword
            // 
            this.register_ShowPassword.AutoSize = true;
            this.register_ShowPassword.Location = new System.Drawing.Point(328, 346);
            this.register_ShowPassword.Name = "register_ShowPassword";
            this.register_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.register_ShowPassword.TabIndex = 13;
            this.register_ShowPassword.Text = "Show Password";
            this.register_ShowPassword.UseVisualStyleBackColor = true;
            this.register_ShowPassword.CheckedChanged += new System.EventHandler(this.register_ShowPassword_CheckedChanged);
            // 
            // register_SignUp
            // 
            this.register_SignUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.register_SignUp.Font = new System.Drawing.Font("Montserrat ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_SignUp.ForeColor = System.Drawing.Color.White;
            this.register_SignUp.Location = new System.Drawing.Point(386, 382);
            this.register_SignUp.Name = "register_SignUp";
            this.register_SignUp.Size = new System.Drawing.Size(172, 29);
            this.register_SignUp.TabIndex = 12;
            this.register_SignUp.Text = "Sign Up";
            this.register_SignUp.UseVisualStyleBackColor = false;
            this.register_SignUp.Click += new System.EventHandler(this.register_SignUp_Click);
            // 
            // register_ConfirmPassword
            // 
            this.register_ConfirmPassword.Location = new System.Drawing.Point(328, 319);
            this.register_ConfirmPassword.Name = "register_ConfirmPassword";
            this.register_ConfirmPassword.PasswordChar = '*';
            this.register_ConfirmPassword.Size = new System.Drawing.Size(294, 20);
            this.register_ConfirmPassword.TabIndex = 10;
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ConfirmPassword.Location = new System.Drawing.Point(325, 298);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(138, 18);
            this.label_ConfirmPassword.TabIndex = 6;
            this.label_ConfirmPassword.Text = "Confirm Password";
            // 
            // register_UserName
            // 
            this.register_UserName.Location = new System.Drawing.Point(328, 189);
            this.register_UserName.Name = "register_UserName";
            this.register_UserName.Size = new System.Drawing.Size(295, 20);
            this.register_UserName.TabIndex = 11;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Username.Location = new System.Drawing.Point(325, 168);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(78, 18);
            this.label_Username.TabIndex = 7;
            this.label_Username.Text = "Username";
            // 
            // Label_Registration
            // 
            this.Label_Registration.AutoSize = true;
            this.Label_Registration.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label_Registration.Location = new System.Drawing.Point(325, 91);
            this.Label_Registration.Name = "Label_Registration";
            this.Label_Registration.Size = new System.Drawing.Size(114, 22);
            this.Label_Registration.TabIndex = 8;
            this.Label_Registration.Text = "Registration";
            this.Label_Registration.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.register_SignIn_Button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_SignIn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 450);
            this.panel1.TabIndex = 5;
            // 
            // register_SignIn_Button
            // 
            this.register_SignIn_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.register_SignIn_Button.Font = new System.Drawing.Font("Montserrat ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.register_SignIn_Button.ForeColor = System.Drawing.Color.White;
            this.register_SignIn_Button.Location = new System.Drawing.Point(58, 382);
            this.register_SignIn_Button.Name = "register_SignIn_Button";
            this.register_SignIn_Button.Size = new System.Drawing.Size(172, 29);
            this.register_SignIn_Button.TabIndex = 3;
            this.register_SignIn_Button.Text = "Sign In";
            this.register_SignIn_Button.UseVisualStyleBackColor = false;
            this.register_SignIn_Button.Click += new System.EventHandler(this.register_SignIn_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(97, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_SignIn
            // 
            this.label_SignIn.AutoSize = true;
            this.label_SignIn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_SignIn.ForeColor = System.Drawing.Color.White;
            this.label_SignIn.Location = new System.Drawing.Point(68, 361);
            this.label_SignIn.Name = "label_SignIn";
            this.label_SignIn.Size = new System.Drawing.Size(151, 18);
            this.label_SignIn.TabIndex = 1;
            this.label_SignIn.Text = "Sign in your Account";
            this.label_SignIn.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hotel Managment System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Password.Location = new System.Drawing.Point(325, 232);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(76, 18);
            this.label_Password.TabIndex = 6;
            this.label_Password.Text = "Password";
            // 
            // register_Password
            // 
            this.register_Password.Location = new System.Drawing.Point(328, 253);
            this.register_Password.Name = "register_Password";
            this.register_Password.PasswordChar = '*';
            this.register_Password.Size = new System.Drawing.Size(294, 20);
            this.register_Password.TabIndex = 10;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.Location = new System.Drawing.Point(617, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 22);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.register_ShowPassword);
            this.Controls.Add(this.register_SignUp);
            this.Controls.Add(this.register_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.register_ConfirmPassword);
            this.Controls.Add(this.label_ConfirmPassword);
            this.Controls.Add(this.register_UserName);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.Label_Registration);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox register_ShowPassword;
        private System.Windows.Forms.Button register_SignUp;
        private System.Windows.Forms.TextBox register_ConfirmPassword;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.TextBox register_UserName;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label Label_Registration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button register_SignIn_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_SignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox register_Password;
        protected internal System.Windows.Forms.Label close;
    }
}
using System;

namespace Hotel_Management_System_WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_RegisterButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_login_username = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.label_login_password = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.login_ShowPassword = new System.Windows.Forms.CheckBox();
            this.close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.login_RegisterButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 450);
            this.panel1.TabIndex = 0;
            // 
            // login_RegisterButton
            // 
            this.login_RegisterButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.login_RegisterButton.Font = new System.Drawing.Font("Montserrat ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_RegisterButton.ForeColor = System.Drawing.Color.White;
            this.login_RegisterButton.Location = new System.Drawing.Point(58, 382);
            this.login_RegisterButton.Name = "login_RegisterButton";
            this.login_RegisterButton.Size = new System.Drawing.Size(172, 29);
            this.login_RegisterButton.TabIndex = 3;
            this.login_RegisterButton.Text = "Register";
            this.login_RegisterButton.UseVisualStyleBackColor = false;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Create new account";
            this.label6.Click += new System.EventHandler(this.label2_Click);
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
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_welcome.Location = new System.Drawing.Point(319, 91);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(140, 22);
            this.label_welcome.TabIndex = 1;
            this.label_welcome.Text = "Welcome back!";
            this.label_welcome.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_login_username
            // 
            this.label_login_username.AutoSize = true;
            this.label_login_username.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login_username.Location = new System.Drawing.Point(319, 168);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(78, 18);
            this.label_login_username.TabIndex = 1;
            this.label_login_username.Text = "Username";
            this.label_login_username.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(322, 189);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(295, 20);
            this.login_username.TabIndex = 2;
            // 
            // label_login_password
            // 
            this.label_login_password.AutoSize = true;
            this.label_login_password.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login_password.Location = new System.Drawing.Point(320, 240);
            this.label_login_password.Name = "label_login_password";
            this.label_login_password.Size = new System.Drawing.Size(76, 18);
            this.label_login_password.TabIndex = 1;
            this.label_login_password.Text = "Password";
            this.label_login_password.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(323, 261);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(294, 20);
            this.login_password.TabIndex = 2;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.login_button.Font = new System.Drawing.Font("Montserrat ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(383, 350);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(172, 29);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            // 
            // login_ShowPassword
            // 
            this.login_ShowPassword.AutoSize = true;
            this.login_ShowPassword.Location = new System.Drawing.Point(323, 288);
            this.login_ShowPassword.Name = "login_ShowPassword";
            this.login_ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.login_ShowPassword.TabIndex = 4;
            this.login_ShowPassword.Text = "Show Password";
            this.login_ShowPassword.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.Location = new System.Drawing.Point(617, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 22);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.login_ShowPassword);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.label_login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label_login_username);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        protected internal System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label_welcome;
        protected internal System.Windows.Forms.Label label_login_username;
        protected internal System.Windows.Forms.TextBox login_username;
        protected internal System.Windows.Forms.Label label_login_password;
        protected internal System.Windows.Forms.TextBox login_password;
        protected internal System.Windows.Forms.Button login_button;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        protected internal System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.Button login_RegisterButton;
        protected internal System.Windows.Forms.CheckBox login_ShowPassword;
        protected internal System.Windows.Forms.Label close;
    }
}


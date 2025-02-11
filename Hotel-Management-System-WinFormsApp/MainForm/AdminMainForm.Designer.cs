namespace Hotel_Management_System_WinFormsApp
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.admin_mainform = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.customer_button = new System.Windows.Forms.Button();
            this.rooms_button = new System.Windows.Forms.Button();
            this.adduser_button = new System.Windows.Forms.Button();
            this.dashbord_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.admin_dashboard1 = new Hotel_Management_System_WinFormsApp.admin_dashboard();
            this.admin_adduser1 = new Hotel_Management_System_WinFormsApp.admin_adduser();
            this.admin_rooms1 = new Hotel_Management_System_WinFormsApp.admin_rooms();
            this.admin_customers1 = new Hotel_Management_System_WinFormsApp.admin_customers();
            this.admin_mainform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_mainform
            // 
            this.admin_mainform.BackColor = System.Drawing.Color.DarkOrange;
            this.admin_mainform.Controls.Add(this.close);
            this.admin_mainform.Controls.Add(this.logout);
            this.admin_mainform.Controls.Add(this.customer_button);
            this.admin_mainform.Controls.Add(this.rooms_button);
            this.admin_mainform.Controls.Add(this.adduser_button);
            this.admin_mainform.Controls.Add(this.dashbord_button);
            this.admin_mainform.Controls.Add(this.pictureBox1);
            this.admin_mainform.Dock = System.Windows.Forms.DockStyle.Left;
            this.admin_mainform.Location = new System.Drawing.Point(0, 0);
            this.admin_mainform.Name = "admin_mainform";
            this.admin_mainform.Size = new System.Drawing.Size(200, 640);
            this.admin_mainform.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(148, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(12, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(17, 18);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Black;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(16, 597);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(169, 31);
            this.logout.TabIndex = 2;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // customer_button
            // 
            this.customer_button.BackColor = System.Drawing.Color.Black;
            this.customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customer_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customer_button.ForeColor = System.Drawing.Color.White;
            this.customer_button.Location = new System.Drawing.Point(16, 431);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(169, 31);
            this.customer_button.TabIndex = 2;
            this.customer_button.Text = "GUEST\'S";
            this.customer_button.UseVisualStyleBackColor = false;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // rooms_button
            // 
            this.rooms_button.BackColor = System.Drawing.Color.Black;
            this.rooms_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rooms_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_button.ForeColor = System.Drawing.Color.White;
            this.rooms_button.Location = new System.Drawing.Point(16, 381);
            this.rooms_button.Name = "rooms_button";
            this.rooms_button.Size = new System.Drawing.Size(169, 31);
            this.rooms_button.TabIndex = 2;
            this.rooms_button.Text = "ROOM\'S";
            this.rooms_button.UseVisualStyleBackColor = false;
            this.rooms_button.Click += new System.EventHandler(this.rooms_button_Click);
            // 
            // adduser_button
            // 
            this.adduser_button.BackColor = System.Drawing.Color.Black;
            this.adduser_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adduser_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adduser_button.ForeColor = System.Drawing.Color.White;
            this.adduser_button.Location = new System.Drawing.Point(16, 333);
            this.adduser_button.Name = "adduser_button";
            this.adduser_button.Size = new System.Drawing.Size(169, 31);
            this.adduser_button.TabIndex = 2;
            this.adduser_button.Text = "USER\'S";
            this.adduser_button.UseVisualStyleBackColor = false;
            this.adduser_button.Click += new System.EventHandler(this.adduser_button_Click);
            // 
            // dashbord_button
            // 
            this.dashbord_button.BackColor = System.Drawing.Color.Black;
            this.dashbord_button.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.dashbord_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashbord_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dashbord_button.ForeColor = System.Drawing.SystemColors.Control;
            this.dashbord_button.Location = new System.Drawing.Point(16, 283);
            this.dashbord_button.Name = "dashbord_button";
            this.dashbord_button.Size = new System.Drawing.Size(169, 31);
            this.dashbord_button.TabIndex = 2;
            this.dashbord_button.Text = "DASHBOARD";
            this.dashbord_button.UseVisualStyleBackColor = false;
            this.dashbord_button.Click += new System.EventHandler(this.dashbord_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.admin_dashboard1);
            this.panel3.Controls.Add(this.admin_adduser1);
            this.panel3.Controls.Add(this.admin_rooms1);
            this.panel3.Controls.Add(this.admin_customers1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 640);
            this.panel3.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // admin_dashboard1
            // 
            this.admin_dashboard1.Location = new System.Drawing.Point(0, 0);
            this.admin_dashboard1.Name = "admin_dashboard1";
            this.admin_dashboard1.Size = new System.Drawing.Size(900, 640);
            this.admin_dashboard1.TabIndex = 3;
            // 
            // admin_adduser1
            // 
            this.admin_adduser1.BackColor = System.Drawing.Color.White;
            this.admin_adduser1.Location = new System.Drawing.Point(0, 0);
            this.admin_adduser1.Name = "admin_adduser1";
            this.admin_adduser1.Size = new System.Drawing.Size(900, 640);
            this.admin_adduser1.TabIndex = 2;
            // 
            // admin_rooms1
            // 
            this.admin_rooms1.BackColor = System.Drawing.Color.White;
            this.admin_rooms1.Location = new System.Drawing.Point(0, 0);
            this.admin_rooms1.Name = "admin_rooms1";
            this.admin_rooms1.Size = new System.Drawing.Size(900, 640);
            this.admin_rooms1.TabIndex = 1;
            // 
            // admin_customers1
            // 
            this.admin_customers1.BackColor = System.Drawing.Color.White;
            this.admin_customers1.Location = new System.Drawing.Point(0, 0);
            this.admin_customers1.Name = "admin_customers1";
            this.admin_customers1.Size = new System.Drawing.Size(900, 640);
            this.admin_customers1.TabIndex = 0;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.admin_mainform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.admin_mainform.ResumeLayout(false);
            this.admin_mainform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel admin_mainform;
        private System.Windows.Forms.Button dashbord_button;
        private System.Windows.Forms.Button customer_button;
        private System.Windows.Forms.Button rooms_button;
        private System.Windows.Forms.Button adduser_button;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private admin_customers admin_customers1;
        private admin_adduser admin_adduser1;
        private admin_rooms admin_rooms1;
        protected internal System.Windows.Forms.Label close;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private admin_dashboard admin_dashboard1;
    }
}
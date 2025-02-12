namespace Hotel_Management_System_WinFormsApp
{
    partial class staffMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffMainForm));
            this.close = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.customer_button = new System.Windows.Forms.Button();
            this.bookroom_button = new System.Windows.Forms.Button();
            this.dashbord_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.admin_customers1 = new Hotel_Management_System_WinFormsApp.admin_customers();
            this.staffBookRoom1 = new Hotel_Management_System_WinFormsApp.staffBookRoom();
            this.admin_dashboard1 = new Hotel_Management_System_WinFormsApp.admin_dashboard();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.customer_button);
            this.panel2.Controls.Add(this.bookroom_button);
            this.panel2.Controls.Add(this.dashbord_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 640);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(148, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // customer_button
            // 
            this.customer_button.BackColor = System.Drawing.Color.Black;
            this.customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customer_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customer_button.ForeColor = System.Drawing.Color.White;
            this.customer_button.Location = new System.Drawing.Point(16, 382);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(169, 31);
            this.customer_button.TabIndex = 2;
            this.customer_button.Text = "QUEST\'S";
            this.customer_button.UseVisualStyleBackColor = false;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // bookroom_button
            // 
            this.bookroom_button.BackColor = System.Drawing.Color.Black;
            this.bookroom_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookroom_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bookroom_button.ForeColor = System.Drawing.Color.White;
            this.bookroom_button.Location = new System.Drawing.Point(16, 333);
            this.bookroom_button.Name = "bookroom_button";
            this.bookroom_button.Size = new System.Drawing.Size(169, 31);
            this.bookroom_button.TabIndex = 2;
            this.bookroom_button.Text = "BOOK ROOM";
            this.bookroom_button.UseVisualStyleBackColor = false;
            this.bookroom_button.Click += new System.EventHandler(this.bookroom_button_Click);
            // 
            // dashbord_button
            // 
            this.dashbord_button.BackColor = System.Drawing.Color.Black;
            this.dashbord_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashbord_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dashbord_button.ForeColor = System.Drawing.Color.White;
            this.dashbord_button.Location = new System.Drawing.Point(16, 284);
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
            this.panel3.Controls.Add(this.staffBookRoom1);
            this.panel3.Controls.Add(this.admin_customers1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 640);
            this.panel3.TabIndex = 5;
            // 
            // admin_customers1
            // 
            this.admin_customers1.BackColor = System.Drawing.Color.White;
            this.admin_customers1.Location = new System.Drawing.Point(200, 0);
            this.admin_customers1.Name = "admin_customers1";
            this.admin_customers1.Size = new System.Drawing.Size(900, 640);
            this.admin_customers1.TabIndex = 3;
            // 
            // staffBookRoom1
            // 
            this.staffBookRoom1.BackColor = System.Drawing.Color.White;
            this.staffBookRoom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.staffBookRoom1.Location = new System.Drawing.Point(200, 0);
            this.staffBookRoom1.Name = "staffBookRoom1";
            this.staffBookRoom1.Size = new System.Drawing.Size(900, 640);
            this.staffBookRoom1.TabIndex = 4;
            // 
            // admin_dashboard1
            // 
            this.admin_dashboard1.Location = new System.Drawing.Point(200, 0);
            this.admin_dashboard1.Name = "admin_dashboard1";
            this.admin_dashboard1.Size = new System.Drawing.Size(900, 640);
            this.admin_dashboard1.TabIndex = 5;
            // 
            // staffMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staffMainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.Label close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button customer_button;
        private System.Windows.Forms.Button bookroom_button;
        private System.Windows.Forms.Button dashbord_button;
        private System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private admin_dashboard admin_dashboard1;
        private staffBookRoom staffBookRoom1;
        private admin_customers admin_customers1;
    }
}
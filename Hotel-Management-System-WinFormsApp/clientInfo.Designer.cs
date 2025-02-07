namespace Hotel_Management_System_WinFormsApp
{
    partial class clientInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clientInfo_gender = new System.Windows.Forms.ComboBox();
            this.clientInfo_contact = new System.Windows.Forms.TextBox();
            this.clientInfo_email = new System.Windows.Forms.TextBox();
            this.clientInfo_address = new System.Windows.Forms.TextBox();
            this.clientInfo_fullname = new System.Windows.Forms.TextBox();
            this.clientInfo_bookID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientInfo_bookNowButton = new System.Windows.Forms.Button();
            this.clientInfo_clearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(767, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client\'s Information";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1067, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 22);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.clientInfo_clearButton);
            this.panel2.Controls.Add(this.clientInfo_bookNowButton);
            this.panel2.Controls.Add(this.clientInfo_gender);
            this.panel2.Controls.Add(this.clientInfo_contact);
            this.panel2.Controls.Add(this.clientInfo_email);
            this.panel2.Controls.Add(this.clientInfo_address);
            this.panel2.Controls.Add(this.clientInfo_fullname);
            this.panel2.Controls.Add(this.clientInfo_bookID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 383);
            this.panel2.TabIndex = 5;
            // 
            // clientInfo_gender
            // 
            this.clientInfo_gender.FormattingEnabled = true;
            this.clientInfo_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.clientInfo_gender.Location = new System.Drawing.Point(445, 30);
            this.clientInfo_gender.Name = "clientInfo_gender";
            this.clientInfo_gender.Size = new System.Drawing.Size(174, 21);
            this.clientInfo_gender.TabIndex = 2;
            // 
            // clientInfo_contact
            // 
            this.clientInfo_contact.Location = new System.Drawing.Point(121, 139);
            this.clientInfo_contact.Name = "clientInfo_contact";
            this.clientInfo_contact.Size = new System.Drawing.Size(174, 20);
            this.clientInfo_contact.TabIndex = 1;
            // 
            // clientInfo_email
            // 
            this.clientInfo_email.Location = new System.Drawing.Point(121, 103);
            this.clientInfo_email.Name = "clientInfo_email";
            this.clientInfo_email.Size = new System.Drawing.Size(174, 20);
            this.clientInfo_email.TabIndex = 1;
            // 
            // clientInfo_address
            // 
            this.clientInfo_address.Location = new System.Drawing.Point(445, 63);
            this.clientInfo_address.Multiline = true;
            this.clientInfo_address.Name = "clientInfo_address";
            this.clientInfo_address.Size = new System.Drawing.Size(174, 96);
            this.clientInfo_address.TabIndex = 1;
            // 
            // clientInfo_fullname
            // 
            this.clientInfo_fullname.Location = new System.Drawing.Point(121, 66);
            this.clientInfo_fullname.Name = "clientInfo_fullname";
            this.clientInfo_fullname.Size = new System.Drawing.Size(174, 20);
            this.clientInfo_fullname.TabIndex = 1;
            // 
            // clientInfo_bookID
            // 
            this.clientInfo_bookID.AutoSize = true;
            this.clientInfo_bookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientInfo_bookID.Location = new System.Drawing.Point(118, 33);
            this.clientInfo_bookID.Name = "clientInfo_bookID";
            this.clientInfo_bookID.Size = new System.Drawing.Size(55, 13);
            this.clientInfo_bookID.TabIndex = 0;
            this.clientInfo_bookID.Text = "------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Contact Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Full Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book ID:";
            // 
            // clientInfo_bookNowButton
            // 
            this.clientInfo_bookNowButton.Location = new System.Drawing.Point(76, 262);
            this.clientInfo_bookNowButton.Name = "clientInfo_bookNowButton";
            this.clientInfo_bookNowButton.Size = new System.Drawing.Size(210, 23);
            this.clientInfo_bookNowButton.TabIndex = 7;
            this.clientInfo_bookNowButton.Text = "Book Now";
            this.clientInfo_bookNowButton.UseVisualStyleBackColor = true;
            this.clientInfo_bookNowButton.Click += new System.EventHandler(this.staffBook_clearButton_Click);
            // 
            // clientInfo_clearButton
            // 
            this.clientInfo_clearButton.Location = new System.Drawing.Point(397, 262);
            this.clientInfo_clearButton.Name = "clientInfo_clearButton";
            this.clientInfo_clearButton.Size = new System.Drawing.Size(210, 23);
            this.clientInfo_clearButton.TabIndex = 7;
            this.clientInfo_clearButton.Text = "Clear";
            this.clientInfo_clearButton.UseVisualStyleBackColor = true;
            // 
            // clientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientInfo";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label close;
        protected internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label clientInfo_bookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox clientInfo_gender;
        private System.Windows.Forms.TextBox clientInfo_contact;
        private System.Windows.Forms.TextBox clientInfo_email;
        private System.Windows.Forms.TextBox clientInfo_address;
        private System.Windows.Forms.TextBox clientInfo_fullname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clientInfo_clearButton;
        private System.Windows.Forms.Button clientInfo_bookNowButton;
    }
}
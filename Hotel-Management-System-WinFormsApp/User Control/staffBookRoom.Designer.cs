namespace Hotel_Management_System_WinFormsApp
{
    partial class staffBookRoom
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel7 = new System.Windows.Forms.Panel();
            this.staffBook_clearButton = new System.Windows.Forms.Button();
            this.staffBook_printButton = new System.Windows.Forms.Button();
            this.staffBook_bookButton = new System.Windows.Forms.Button();
            this.staffBook_scheduleButton = new System.Windows.Forms.Button();
            this.staffBook_to = new System.Windows.Forms.DateTimePicker();
            this.staffBook_from = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.staffBook_total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.staffBook_regularPrice = new System.Windows.Forms.Label();
            this.staffBook_status = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.staffBook_name = new System.Windows.Forms.Label();
            this.staffBook_type = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffBook_roomID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addUser_addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.staffBook_clearButton);
            this.panel7.Controls.Add(this.staffBook_printButton);
            this.panel7.Controls.Add(this.staffBook_bookButton);
            this.panel7.Controls.Add(this.staffBook_scheduleButton);
            this.panel7.Controls.Add(this.staffBook_to);
            this.panel7.Controls.Add(this.staffBook_from);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.staffBook_total);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.staffBook_regularPrice);
            this.panel7.Controls.Add(this.staffBook_status);
            this.panel7.Controls.Add(this.label);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.staffBook_name);
            this.panel7.Controls.Add(this.staffBook_type);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.staffBook_roomID);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(579, 44);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(315, 553);
            this.panel7.TabIndex = 1;
            // 
            // staffBook_clearButton
            // 
            this.staffBook_clearButton.Location = new System.Drawing.Point(35, 496);
            this.staffBook_clearButton.Name = "staffBook_clearButton";
            this.staffBook_clearButton.Size = new System.Drawing.Size(210, 23);
            this.staffBook_clearButton.TabIndex = 6;
            this.staffBook_clearButton.Text = "Clear";
            this.staffBook_clearButton.UseVisualStyleBackColor = true;
            this.staffBook_clearButton.Click += new System.EventHandler(this.staffBook_clearButton_Click);
            // 
            // staffBook_printButton
            // 
            this.staffBook_printButton.Location = new System.Drawing.Point(35, 453);
            this.staffBook_printButton.Name = "staffBook_printButton";
            this.staffBook_printButton.Size = new System.Drawing.Size(210, 23);
            this.staffBook_printButton.TabIndex = 6;
            this.staffBook_printButton.Text = "Print";
            this.staffBook_printButton.UseVisualStyleBackColor = true;
            // 
            // staffBook_bookButton
            // 
            this.staffBook_bookButton.Location = new System.Drawing.Point(37, 411);
            this.staffBook_bookButton.Name = "staffBook_bookButton";
            this.staffBook_bookButton.Size = new System.Drawing.Size(210, 23);
            this.staffBook_bookButton.TabIndex = 6;
            this.staffBook_bookButton.Text = "Book";
            this.staffBook_bookButton.UseVisualStyleBackColor = true;
            this.staffBook_bookButton.Click += new System.EventHandler(this.staffBook_bookButton_Click);
            // 
            // staffBook_scheduleButton
            // 
            this.staffBook_scheduleButton.Location = new System.Drawing.Point(37, 322);
            this.staffBook_scheduleButton.Name = "staffBook_scheduleButton";
            this.staffBook_scheduleButton.Size = new System.Drawing.Size(210, 23);
            this.staffBook_scheduleButton.TabIndex = 6;
            this.staffBook_scheduleButton.Text = "Schedule Now";
            this.staffBook_scheduleButton.UseVisualStyleBackColor = true;
            this.staffBook_scheduleButton.Click += new System.EventHandler(this.staffBook_scheduleButton_Click);
            // 
            // staffBook_to
            // 
            this.staffBook_to.Location = new System.Drawing.Point(37, 280);
            this.staffBook_to.Name = "staffBook_to";
            this.staffBook_to.Size = new System.Drawing.Size(210, 20);
            this.staffBook_to.TabIndex = 5;
            // 
            // staffBook_from
            // 
            this.staffBook_from.Location = new System.Drawing.Point(37, 229);
            this.staffBook_from.Name = "staffBook_from";
            this.staffBook_from.Size = new System.Drawing.Size(210, 20);
            this.staffBook_from.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(25, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "To Schedule:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(10, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "From Schedule:";
            // 
            // staffBook_total
            // 
            this.staffBook_total.AutoSize = true;
            this.staffBook_total.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.staffBook_total.Location = new System.Drawing.Point(164, 361);
            this.staffBook_total.Name = "staffBook_total";
            this.staffBook_total.Size = new System.Drawing.Size(31, 15);
            this.staffBook_total.TabIndex = 4;
            this.staffBook_total.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(72, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "TOTAL PRICE:";
            // 
            // staffBook_regularPrice
            // 
            this.staffBook_regularPrice.AutoSize = true;
            this.staffBook_regularPrice.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.staffBook_regularPrice.Location = new System.Drawing.Point(158, 174);
            this.staffBook_regularPrice.Name = "staffBook_regularPrice";
            this.staffBook_regularPrice.Size = new System.Drawing.Size(67, 15);
            this.staffBook_regularPrice.TabIndex = 4;
            this.staffBook_regularPrice.Text = "---------------";
            // 
            // staffBook_status
            // 
            this.staffBook_status.AutoSize = true;
            this.staffBook_status.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.staffBook_status.Location = new System.Drawing.Point(158, 138);
            this.staffBook_status.Name = "staffBook_status";
            this.staffBook_status.Size = new System.Drawing.Size(67, 15);
            this.staffBook_status.TabIndex = 4;
            this.staffBook_status.Text = "---------------";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(49, 174);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(87, 15);
            this.label.TabIndex = 4;
            this.label.Text = "Regular Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(89, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            // 
            // staffBook_name
            // 
            this.staffBook_name.AutoSize = true;
            this.staffBook_name.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.staffBook_name.Location = new System.Drawing.Point(158, 101);
            this.staffBook_name.Name = "staffBook_name";
            this.staffBook_name.Size = new System.Drawing.Size(67, 15);
            this.staffBook_name.TabIndex = 4;
            this.staffBook_name.Text = "---------------";
            // 
            // staffBook_type
            // 
            this.staffBook_type.AutoSize = true;
            this.staffBook_type.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.staffBook_type.Location = new System.Drawing.Point(158, 62);
            this.staffBook_type.Name = "staffBook_type";
            this.staffBook_type.Size = new System.Drawing.Size(67, 15);
            this.staffBook_type.TabIndex = 4;
            this.staffBook_type.Text = "---------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(54, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Name:";
            // 
            // staffBook_roomID
            // 
            this.staffBook_roomID.AutoSize = true;
            this.staffBook_roomID.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.staffBook_roomID.Location = new System.Drawing.Point(158, 24);
            this.staffBook_roomID.Name = "staffBook_roomID";
            this.staffBook_roomID.Size = new System.Drawing.Size(67, 15);
            this.staffBook_roomID.TabIndex = 4;
            this.staffBook_roomID.Text = "---------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(61, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(76, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room ID:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.addUser_addButton);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(12, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(561, 553);
            this.panel5.TabIndex = 2;
            // 
            // addUser_addButton
            // 
            this.addUser_addButton.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUser_addButton.Location = new System.Drawing.Point(15, 473);
            this.addUser_addButton.Name = "addUser_addButton";
            this.addUser_addButton.Size = new System.Drawing.Size(164, 23);
            this.addUser_addButton.TabIndex = 6;
            this.addUser_addButton.Text = "Check Room";
            this.addUser_addButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 403);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Available Room\'s";
            // 
            // staffBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Name = "staffBookRoom";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button staffBook_clearButton;
        private System.Windows.Forms.Button staffBook_printButton;
        private System.Windows.Forms.Button staffBook_bookButton;
        private System.Windows.Forms.Button staffBook_scheduleButton;
        private System.Windows.Forms.DateTimePicker staffBook_to;
        private System.Windows.Forms.DateTimePicker staffBook_from;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label staffBook_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label staffBook_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label staffBook_name;
        private System.Windows.Forms.Label staffBook_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label staffBook_roomID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button addUser_addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label staffBook_regularPrice;
        private System.Windows.Forms.Label label;
    }
}

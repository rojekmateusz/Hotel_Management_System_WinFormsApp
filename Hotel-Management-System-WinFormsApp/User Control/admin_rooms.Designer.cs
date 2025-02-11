namespace Hotel_Management_System_WinFormsApp
{
    partial class admin_rooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rooms_clear_button = new System.Windows.Forms.Button();
            this.rooms_update_button = new System.Windows.Forms.Button();
            this.rooms_delete_button = new System.Windows.Forms.Button();
            this.rooms_add_button = new System.Windows.Forms.Button();
            this.rooms_status = new System.Windows.Forms.ComboBox();
            this.rooms_type = new System.Windows.Forms.ComboBox();
            this.rooms_name = new System.Windows.Forms.TextBox();
            this.rooms_price = new System.Windows.Forms.TextBox();
            this.rooms_room_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(259, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 634);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(495, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "ROOM\'S DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(621, 540);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rooms_clear_button);
            this.panel2.Controls.Add(this.rooms_update_button);
            this.panel2.Controls.Add(this.rooms_delete_button);
            this.panel2.Controls.Add(this.rooms_add_button);
            this.panel2.Controls.Add(this.rooms_status);
            this.panel2.Controls.Add(this.rooms_type);
            this.panel2.Controls.Add(this.rooms_name);
            this.panel2.Controls.Add(this.rooms_price);
            this.panel2.Controls.Add(this.rooms_room_id);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 634);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "ROOM\'S";
            // 
            // rooms_clear_button
            // 
            this.rooms_clear_button.BackColor = System.Drawing.Color.Black;
            this.rooms_clear_button.FlatAppearance.BorderSize = 0;
            this.rooms_clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_clear_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_clear_button.ForeColor = System.Drawing.Color.White;
            this.rooms_clear_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rooms_clear_button.Location = new System.Drawing.Point(41, 563);
            this.rooms_clear_button.Name = "rooms_clear_button";
            this.rooms_clear_button.Size = new System.Drawing.Size(169, 31);
            this.rooms_clear_button.TabIndex = 7;
            this.rooms_clear_button.Text = "CLEAR";
            this.rooms_clear_button.UseVisualStyleBackColor = false;
            this.rooms_clear_button.Click += new System.EventHandler(this.rooms_clear_button_Click);
            // 
            // rooms_update_button
            // 
            this.rooms_update_button.BackColor = System.Drawing.Color.Black;
            this.rooms_update_button.FlatAppearance.BorderSize = 0;
            this.rooms_update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_update_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_update_button.ForeColor = System.Drawing.Color.White;
            this.rooms_update_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rooms_update_button.Location = new System.Drawing.Point(41, 467);
            this.rooms_update_button.Name = "rooms_update_button";
            this.rooms_update_button.Size = new System.Drawing.Size(169, 31);
            this.rooms_update_button.TabIndex = 7;
            this.rooms_update_button.Text = "UPDATE";
            this.rooms_update_button.UseVisualStyleBackColor = false;
            this.rooms_update_button.Click += new System.EventHandler(this.rooms_update_button_Click);
            // 
            // rooms_delete_button
            // 
            this.rooms_delete_button.BackColor = System.Drawing.Color.Black;
            this.rooms_delete_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.rooms_delete_button.FlatAppearance.BorderSize = 0;
            this.rooms_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_delete_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_delete_button.ForeColor = System.Drawing.Color.White;
            this.rooms_delete_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rooms_delete_button.Location = new System.Drawing.Point(41, 515);
            this.rooms_delete_button.Name = "rooms_delete_button";
            this.rooms_delete_button.Size = new System.Drawing.Size(169, 31);
            this.rooms_delete_button.TabIndex = 7;
            this.rooms_delete_button.Text = "DELETE";
            this.rooms_delete_button.UseVisualStyleBackColor = false;
            this.rooms_delete_button.Click += new System.EventHandler(this.rooms_delete_button_Click);
            // 
            // rooms_add_button
            // 
            this.rooms_add_button.BackColor = System.Drawing.Color.Black;
            this.rooms_add_button.FlatAppearance.BorderSize = 0;
            this.rooms_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms_add_button.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_add_button.ForeColor = System.Drawing.Color.White;
            this.rooms_add_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rooms_add_button.Location = new System.Drawing.Point(41, 419);
            this.rooms_add_button.Name = "rooms_add_button";
            this.rooms_add_button.Size = new System.Drawing.Size(169, 31);
            this.rooms_add_button.TabIndex = 7;
            this.rooms_add_button.Text = "ADD";
            this.rooms_add_button.UseVisualStyleBackColor = false;
            this.rooms_add_button.Click += new System.EventHandler(this.rooms_add_button_Click);
            // 
            // rooms_status
            // 
            this.rooms_status.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_status.FormattingEnabled = true;
            this.rooms_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Occupied",
            "Unavailable"});
            this.rooms_status.Location = new System.Drawing.Point(43, 331);
            this.rooms_status.Name = "rooms_status";
            this.rooms_status.Size = new System.Drawing.Size(169, 23);
            this.rooms_status.TabIndex = 6;
            // 
            // rooms_type
            // 
            this.rooms_type.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_type.FormattingEnabled = true;
            this.rooms_type.Items.AddRange(new object[] {
            "Single Room",
            "Double Room"});
            this.rooms_type.Location = new System.Drawing.Point(43, 212);
            this.rooms_type.Name = "rooms_type";
            this.rooms_type.Size = new System.Drawing.Size(167, 23);
            this.rooms_type.TabIndex = 6;
            // 
            // rooms_name
            // 
            this.rooms_name.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_name.Location = new System.Drawing.Point(43, 157);
            this.rooms_name.Name = "rooms_name";
            this.rooms_name.Size = new System.Drawing.Size(167, 21);
            this.rooms_name.TabIndex = 5;
            // 
            // rooms_price
            // 
            this.rooms_price.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_price.Location = new System.Drawing.Point(43, 272);
            this.rooms_price.Name = "rooms_price";
            this.rooms_price.Size = new System.Drawing.Size(169, 21);
            this.rooms_price.TabIndex = 5;
            // 
            // rooms_room_id
            // 
            this.rooms_room_id.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rooms_room_id.Location = new System.Drawing.Point(43, 99);
            this.rooms_room_id.Name = "rooms_room_id";
            this.rooms_room_id.Size = new System.Drawing.Size(167, 21);
            this.rooms_room_id.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(42, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(42, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price ($):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room Id:";
            // 
            // admin_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "admin_rooms";
            this.Size = new System.Drawing.Size(900, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rooms_type;
        private System.Windows.Forms.TextBox rooms_room_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rooms_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rooms_status;
        private System.Windows.Forms.TextBox rooms_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rooms_clear_button;
        private System.Windows.Forms.Button rooms_update_button;
        private System.Windows.Forms.Button rooms_delete_button;
        private System.Windows.Forms.Button rooms_add_button;
        private System.Windows.Forms.Label label7;
    }
}

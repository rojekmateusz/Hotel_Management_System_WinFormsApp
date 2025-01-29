namespace Hotel_Management_System_WinFormsApp
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addUser_clearButton = new System.Windows.Forms.Button();
            this.addUser_deleteButton = new System.Windows.Forms.Button();
            this.addUser_updateButton = new System.Windows.Forms.Button();
            this.addUser_addButton = new System.Windows.Forms.Button();
            this.addUser_status = new System.Windows.Forms.ComboBox();
            this.addUser_role = new System.Windows.Forms.ComboBox();
            this.addUser_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addUser_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(225, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 581);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(14, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(632, 506);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDataView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "User\'s Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addUser_clearButton);
            this.panel1.Controls.Add(this.addUser_deleteButton);
            this.panel1.Controls.Add(this.addUser_updateButton);
            this.panel1.Controls.Add(this.addUser_addButton);
            this.panel1.Controls.Add(this.addUser_status);
            this.panel1.Controls.Add(this.addUser_role);
            this.panel1.Controls.Add(this.addUser_password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addUser_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 576);
            this.panel1.TabIndex = 2;
            // 
            // addUser_clearButton
            // 
            this.addUser_clearButton.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUser_clearButton.Location = new System.Drawing.Point(16, 399);
            this.addUser_clearButton.Name = "addUser_clearButton";
            this.addUser_clearButton.Size = new System.Drawing.Size(164, 23);
            this.addUser_clearButton.TabIndex = 0;
            this.addUser_clearButton.Text = "Clear";
            this.addUser_clearButton.UseVisualStyleBackColor = true;
            this.addUser_clearButton.Click += new System.EventHandler(this.addUser_clearButton_Click);
            // 
            // addUser_deleteButton
            // 
            this.addUser_deleteButton.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUser_deleteButton.Location = new System.Drawing.Point(16, 370);
            this.addUser_deleteButton.Name = "addUser_deleteButton";
            this.addUser_deleteButton.Size = new System.Drawing.Size(164, 23);
            this.addUser_deleteButton.TabIndex = 0;
            this.addUser_deleteButton.Text = "Delete";
            this.addUser_deleteButton.UseVisualStyleBackColor = true;
            this.addUser_deleteButton.Click += new System.EventHandler(this.addUser_deleteButton_Click);
            // 
            // addUser_updateButton
            // 
            this.addUser_updateButton.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUser_updateButton.Location = new System.Drawing.Point(16, 340);
            this.addUser_updateButton.Name = "addUser_updateButton";
            this.addUser_updateButton.Size = new System.Drawing.Size(164, 23);
            this.addUser_updateButton.TabIndex = 0;
            this.addUser_updateButton.Text = "Update";
            this.addUser_updateButton.UseVisualStyleBackColor = true;
            this.addUser_updateButton.Click += new System.EventHandler(this.addUser_updateButton_Click);
            // 
            // addUser_addButton
            // 
            this.addUser_addButton.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUser_addButton.Location = new System.Drawing.Point(16, 311);
            this.addUser_addButton.Name = "addUser_addButton";
            this.addUser_addButton.Size = new System.Drawing.Size(164, 23);
            this.addUser_addButton.TabIndex = 0;
            this.addUser_addButton.Text = "Add";
            this.addUser_addButton.UseVisualStyleBackColor = true;
            this.addUser_addButton.Click += new System.EventHandler(this.addUser_addButton_Click);
            // 
            // addUser_status
            // 
            this.addUser_status.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUser_status.FormattingEnabled = true;
            this.addUser_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addUser_status.Location = new System.Drawing.Point(16, 260);
            this.addUser_status.Name = "addUser_status";
            this.addUser_status.Size = new System.Drawing.Size(164, 24);
            this.addUser_status.TabIndex = 0;
            // 
            // addUser_role
            // 
            this.addUser_role.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUser_role.FormattingEnabled = true;
            this.addUser_role.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.addUser_role.Location = new System.Drawing.Point(16, 196);
            this.addUser_role.Name = "addUser_role";
            this.addUser_role.Size = new System.Drawing.Size(164, 24);
            this.addUser_role.TabIndex = 0;
            // 
            // addUser_password
            // 
            this.addUser_password.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUser_password.Location = new System.Drawing.Point(16, 136);
            this.addUser_password.Name = "addUser_password";
            this.addUser_password.Size = new System.Drawing.Size(164, 23);
            this.addUser_password.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // addUser_username
            // 
            this.addUser_username.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUser_username.Location = new System.Drawing.Point(16, 73);
            this.addUser_username.Name = "addUser_username";
            this.addUser_username.Size = new System.Drawing.Size(164, 23);
            this.addUser_username.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addUser_clearButton;
        private System.Windows.Forms.Button addUser_deleteButton;
        private System.Windows.Forms.Button addUser_updateButton;
        private System.Windows.Forms.Button addUser_addButton;
        private System.Windows.Forms.ComboBox addUser_status;
        private System.Windows.Forms.ComboBox addUser_role;
        private System.Windows.Forms.TextBox addUser_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addUser_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

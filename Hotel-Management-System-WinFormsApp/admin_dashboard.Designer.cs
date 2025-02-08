namespace Hotel_Management_System_WinFormsApp
{
    partial class admin_dashboard
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.totalProfit = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.todayProfit = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.availabelRooms = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.totalStaff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(15, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(871, 404);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(15, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 150);
            this.panel4.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel9.Controls.Add(this.totalProfit);
            this.panel9.Controls.Add(this.pictureBox4);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(656, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(197, 124);
            this.panel9.TabIndex = 0;
            // 
            // totalProfit
            // 
            this.totalProfit.AutoSize = true;
            this.totalProfit.Location = new System.Drawing.Point(165, 29);
            this.totalProfit.Name = "totalProfit";
            this.totalProfit.Size = new System.Drawing.Size(19, 13);
            this.totalProfit.TabIndex = 1;
            this.totalProfit.Text = "$0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hotel_Management_System_WinFormsApp.Properties.Resources.business_and_finance;
            this.pictureBox4.Location = new System.Drawing.Point(21, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Profit";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel8.Controls.Add(this.todayProfit);
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(443, 14);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(197, 124);
            this.panel8.TabIndex = 0;
            // 
            // todayProfit
            // 
            this.todayProfit.AutoSize = true;
            this.todayProfit.Location = new System.Drawing.Point(165, 29);
            this.todayProfit.Name = "todayProfit";
            this.todayProfit.Size = new System.Drawing.Size(19, 13);
            this.todayProfit.TabIndex = 1;
            this.todayProfit.Text = "$0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hotel_Management_System_WinFormsApp.Properties.Resources.profit;
            this.pictureBox3.Location = new System.Drawing.Point(21, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Today\'s Profit";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel7.Controls.Add(this.availabelRooms);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Location = new System.Drawing.Point(230, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 124);
            this.panel7.TabIndex = 0;
            // 
            // availabelRooms
            // 
            this.availabelRooms.AutoSize = true;
            this.availabelRooms.Location = new System.Drawing.Point(174, 29);
            this.availabelRooms.Name = "availabelRooms";
            this.availabelRooms.Size = new System.Drawing.Size(13, 13);
            this.availabelRooms.TabIndex = 1;
            this.availabelRooms.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Avaiable Rooms";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel_Management_System_WinFormsApp.Properties.Resources.bed;
            this.pictureBox2.Location = new System.Drawing.Point(21, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Controls.Add(this.totalStaff);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(17, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 124);
            this.panel6.TabIndex = 0;
            // 
            // totalStaff
            // 
            this.totalStaff.AutoSize = true;
            this.totalStaff.Location = new System.Drawing.Point(171, 29);
            this.totalStaff.Name = "totalStaff";
            this.totalStaff.Size = new System.Drawing.Size(13, 13);
            this.totalStaff.TabIndex = 1;
            this.totalStaff.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Staff";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Management_System_WinFormsApp.Properties.Resources.group;
            this.pictureBox1.Location = new System.Drawing.Point(18, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "All Rooms";
            // 
            // admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "admin_dashboard";
            this.Size = new System.Drawing.Size(900, 600);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label totalProfit;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label todayProfit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label availabelRooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label totalStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}

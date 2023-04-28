namespace QuanLyKhachSan
{
    partial class fInvoice
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
            panel3 = new Panel();
            panel5 = new Panel();
            label12 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            panel17 = new Panel();
            label15 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            dataGridView4 = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label11 = new Label();
            button1 = new Button();
            label13 = new Label();
            label16 = new Label();
            comboBox1 = new ComboBox();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel17);
            panel3.Location = new Point(13, 668);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1421, 80);
            panel3.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(label12);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(42, 8);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(171, 64);
            panel5.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(27, 15);
            label12.Name = "label12";
            label12.Size = new Size(131, 32);
            label12.TabIndex = 0;
            label12.Text = "< Quay lại";
            label12.Click += label12_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Controls.Add(label14);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(1042, 8);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(169, 64);
            panel4.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(19, 15);
            label14.Name = "label14";
            label14.Size = new Size(136, 32);
            label14.TabIndex = 0;
            label14.Text = "Thanh toán";
            label14.Click += label14_Click;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(159, 209, 147);
            panel17.Controls.Add(label15);
            panel17.Cursor = Cursors.Hand;
            panel17.Location = new Point(1231, 8);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(154, 64);
            panel17.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(18, 15);
            label15.Name = "label15";
            label15.Size = new Size(130, 32);
            label15.TabIndex = 0;
            label15.Text = "In hoá đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(39, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(463, 238);
            dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TenDV";
            Column1.HeaderText = "Tên Dịch vụ/Tour";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "SoLuong";
            Column2.HeaderText = "Số lượng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "DonGia";
            Column3.HeaderText = "Đơn giá";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 110;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            dataGridView2.Location = new Point(39, 413);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(463, 238);
            dataGridView2.TabIndex = 18;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TenSanPham";
            Column4.HeaderText = "Tên sản phẩm";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "SoLuong";
            Column5.HeaderText = "Số lượng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DonGia";
            Column6.HeaderText = "Đơn giá";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 110;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8 });
            dataGridView3.Location = new Point(534, 94);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(463, 238);
            dataGridView3.TabIndex = 19;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "SoPhong";
            Column7.HeaderText = "Số phòng";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 205;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "DonGia";
            Column8.HeaderText = "Giá";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 205;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10, Column11, Column12 });
            dataGridView4.Location = new Point(534, 413);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(463, 238);
            dataGridView4.TabIndex = 20;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "SoPhong";
            Column9.HeaderText = "Số phòng";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 80;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "NoiDung";
            Column10.HeaderText = "Nội dung";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 150;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "ChiPhiThietHai";
            Column11.HeaderText = "Chi phí thiệt hại";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 80;
            // 
            // Column12
            // 
            Column12.DataPropertyName = "SoLuong";
            Column12.HeaderText = "Số lượng";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 50);
            label1.Name = "label1";
            label1.Size = new Size(348, 41);
            label1.TabIndex = 21;
            label1.Text = "Dịch vụ/Tour đã đăng ký:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 369);
            label2.Name = "label2";
            label2.Size = new Size(315, 41);
            label2.TabIndex = 22;
            label2.Text = "Sản phẩm đã sử dụng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(534, 50);
            label3.Name = "label3";
            label3.Size = new Size(214, 41);
            label3.TabIndex = 23;
            label3.Text = "Chi phí phòng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(534, 369);
            label4.Name = "label4";
            label4.Size = new Size(248, 41);
            label4.TabIndex = 24;
            label4.Text = "Chi phí phát sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1065, 96);
            label5.Name = "label5";
            label5.Size = new Size(90, 31);
            label5.TabIndex = 25;
            label5.Text = "Mã HĐ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1065, 140);
            label6.Name = "label6";
            label6.Size = new Size(100, 31);
            label6.TabIndex = 26;
            label6.Text = "Mã PĐP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1065, 183);
            label7.Name = "label7";
            label7.Size = new Size(87, 31);
            label7.TabIndex = 27;
            label7.Text = "Mã KH:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1065, 226);
            label8.Name = "label8";
            label8.Size = new Size(118, 31);
            label8.TabIndex = 28;
            label8.Text = "Ngày đến:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1065, 269);
            label9.Name = "label9";
            label9.Size = new Size(99, 31);
            label9.TabIndex = 29;
            label9.Text = "Ngày đi:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1183, 93);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1183, 137);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1183, 180);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 34);
            textBox3.TabIndex = 32;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1183, 222);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 34);
            textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1183, 265);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 34);
            textBox5.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Underline, GraphicsUnit.Point);
            label10.Location = new Point(1055, 579);
            label10.Name = "label10";
            label10.Size = new Size(169, 41);
            label10.TabIndex = 35;
            label10.Text = "Tổng cộng:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1230, 579);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(193, 41);
            textBox6.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1230, 623);
            label11.Name = "label11";
            label11.Size = new Size(181, 20);
            label11.TabIndex = 37;
            label11.Text = "*Đã bao gồm tiền đặt cọc";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(159, 209, 147);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(890, 369);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 38;
            button1.Text = "Kiểm tra";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1055, 20);
            label13.Name = "label13";
            label13.Size = new Size(262, 60);
            label13.TabIndex = 39;
            label13.Text = "CHECK-OUT";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(1065, 313);
            label16.Name = "label16";
            label16.Size = new Size(236, 31);
            label16.TabIndex = 40;
            label16.Text = "Hình thức thanh toán:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            comboBox1.Location = new Point(1141, 347);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 41;
            // 
            // fInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 241);
            ClientSize = new Size(1445, 767);
            Controls.Add(comboBox1);
            Controls.Add(label16);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView4);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fInvoice";
            Text = "fInvoice";
            Load += fInvoice_Load;
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Panel panel5;
        private Label label12;
        private Panel panel4;
        private Label label14;
        private Panel panel17;
        private Label label15;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox6;
        private Label label11;
        private Button button1;
        private Label label13;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Label label16;
        private ComboBox comboBox1;
    }
}
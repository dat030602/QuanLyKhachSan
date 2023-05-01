namespace QuanLyKhachSan
{
    partial class fInfoRoom
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
            panel17 = new Panel();
            label12 = new Label();
            panel13 = new Panel();
            panel16 = new Panel();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel14 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            btn_link_vanchuyenhanhly = new Button();
            btn_link_kiemtraminibar = new Button();
            btn_link_kiemtraphong = new Button();
            btn_link_tour = new Button();
            btn_link_dichvucungcap = new Button();
            btn_link_sanphan_dichvu = new Button();
            btn_link_thongtinphong = new Button();
            btn_link_datphong = new Button();
            btn_link_khachhang = new Button();
            panel11 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel17.SuspendLayout();
            panel13.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel14.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(159, 209, 147);
            panel17.Controls.Add(label12);
            panel17.Cursor = Cursors.Hand;
            panel17.Location = new Point(848, 621);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(171, 45);
            panel17.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(15, 5);
            label12.Name = "label12";
            label12.Size = new Size(148, 32);
            label12.TabIndex = 0;
            label12.Text = "Check-out >";
            label12.Click += label12_Click;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Transparent;
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(317, 1);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(1127, 904);
            panel13.TabIndex = 8;
            // 
            // panel16
            // 
            panel16.Controls.Add(textBox5);
            panel16.Controls.Add(textBox4);
            panel16.Controls.Add(textBox3);
            panel16.Controls.Add(textBox2);
            panel16.Controls.Add(panel17);
            panel16.Controls.Add(dataGridView1);
            panel16.Controls.Add(label8);
            panel16.Controls.Add(label7);
            panel16.Controls.Add(label6);
            panel16.Controls.Add(label5);
            panel16.Controls.Add(label4);
            panel16.Controls.Add(label3);
            panel16.Controls.Add(label2);
            panel16.Location = new Point(3, 88);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(1120, 724);
            panel16.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(337, 188);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 33);
            textBox5.TabIndex = 0;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(337, 141);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 33);
            textBox4.TabIndex = 0;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(337, 91);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 33);
            textBox3.TabIndex = 0;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 35);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 33);
            textBox2.TabIndex = 0;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(239, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(654, 165);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SoPhong";
            Column1.HeaderText = "Số phòng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenLoaiPhong";
            Column2.HeaderText = "Loại phòng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "DonGia";
            Column3.HeaderText = "Đơn giá";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(208, 129);
            label8.Name = "label8";
            label8.Size = new Size(0, 45);
            label8.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(48, 181);
            label7.Name = "label7";
            label7.Size = new Size(140, 45);
            label7.TabIndex = 5;
            label7.Text = "Ngày đi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 129);
            label6.Name = "label6";
            label6.Size = new Size(168, 45);
            label6.TabIndex = 4;
            label6.Text = "Ngày đến:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(299, 83);
            label5.Name = "label5";
            label5.Size = new Size(0, 45);
            label5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 83);
            label4.Name = "label4";
            label4.Size = new Size(255, 45);
            label4.TabIndex = 2;
            label4.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(267, 28);
            label3.Name = "label3";
            label3.Size = new Size(0, 45);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 28);
            label2.Name = "label2";
            label2.Size = new Size(221, 45);
            label2.TabIndex = 0;
            label2.Text = "Mã phiếu đặt:";
            // 
            // panel14
            // 
            panel14.Controls.Add(button1);
            panel14.Controls.Add(textBox1);
            panel14.Location = new Point(3, 4);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(1120, 80);
            panel14.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(159, 209, 147);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(550, 12);
            button1.Name = "button1";
            button1.Size = new Size(123, 51);
            button1.TabIndex = 1;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.Location = new Point(394, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 49);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btn_link_vanchuyenhanhly);
            panel2.Controls.Add(btn_link_kiemtraminibar);
            panel2.Controls.Add(btn_link_kiemtraphong);
            panel2.Controls.Add(btn_link_tour);
            panel2.Controls.Add(btn_link_dichvucungcap);
            panel2.Controls.Add(btn_link_sanphan_dichvu);
            panel2.Controls.Add(btn_link_thongtinphong);
            panel2.Controls.Add(btn_link_datphong);
            panel2.Controls.Add(btn_link_khachhang);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, -4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 916);
            panel2.TabIndex = 9;
            // 
            // btn_link_vanchuyenhanhly
            // 
            btn_link_vanchuyenhanhly.BackColor = Color.Transparent;
            btn_link_vanchuyenhanhly.Cursor = Cursors.Hand;
            btn_link_vanchuyenhanhly.FlatAppearance.BorderSize = 0;
            btn_link_vanchuyenhanhly.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_vanchuyenhanhly.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_vanchuyenhanhly.FlatStyle = FlatStyle.Flat;
            btn_link_vanchuyenhanhly.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_vanchuyenhanhly.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_vanchuyenhanhly.Location = new Point(13, 729);
            btn_link_vanchuyenhanhly.Margin = new Padding(3, 4, 3, 4);
            btn_link_vanchuyenhanhly.Name = "btn_link_vanchuyenhanhly";
            btn_link_vanchuyenhanhly.Size = new Size(279, 69);
            btn_link_vanchuyenhanhly.TabIndex = 19;
            btn_link_vanchuyenhanhly.Text = "Vận chuyển hành lý";
            btn_link_vanchuyenhanhly.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_vanchuyenhanhly.UseVisualStyleBackColor = false;
            // 
            // btn_link_kiemtraminibar
            // 
            btn_link_kiemtraminibar.BackColor = Color.Transparent;
            btn_link_kiemtraminibar.Cursor = Cursors.Hand;
            btn_link_kiemtraminibar.FlatAppearance.BorderSize = 0;
            btn_link_kiemtraminibar.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_kiemtraminibar.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_kiemtraminibar.FlatStyle = FlatStyle.Flat;
            btn_link_kiemtraminibar.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_kiemtraminibar.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_kiemtraminibar.Location = new Point(13, 652);
            btn_link_kiemtraminibar.Margin = new Padding(3, 4, 3, 4);
            btn_link_kiemtraminibar.Name = "btn_link_kiemtraminibar";
            btn_link_kiemtraminibar.Size = new Size(279, 69);
            btn_link_kiemtraminibar.TabIndex = 18;
            btn_link_kiemtraminibar.Text = "Kiểm tra minibar";
            btn_link_kiemtraminibar.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_kiemtraminibar.UseVisualStyleBackColor = false;
            btn_link_kiemtraminibar.Click += btn_link_kiemtraminibar_Click;
            // 
            // btn_link_kiemtraphong
            // 
            btn_link_kiemtraphong.BackColor = Color.Transparent;
            btn_link_kiemtraphong.Cursor = Cursors.Hand;
            btn_link_kiemtraphong.FlatAppearance.BorderSize = 0;
            btn_link_kiemtraphong.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_kiemtraphong.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_kiemtraphong.FlatStyle = FlatStyle.Flat;
            btn_link_kiemtraphong.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_kiemtraphong.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_kiemtraphong.Location = new Point(13, 575);
            btn_link_kiemtraphong.Margin = new Padding(3, 4, 3, 4);
            btn_link_kiemtraphong.Name = "btn_link_kiemtraphong";
            btn_link_kiemtraphong.Size = new Size(279, 69);
            btn_link_kiemtraphong.TabIndex = 17;
            btn_link_kiemtraphong.Text = "Kiểm tra phòng";
            btn_link_kiemtraphong.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_kiemtraphong.UseVisualStyleBackColor = false;
            btn_link_kiemtraphong.Click += btn_link_kiemtraphong_Click;
            // 
            // btn_link_tour
            // 
            btn_link_tour.BackColor = Color.Transparent;
            btn_link_tour.Cursor = Cursors.Hand;
            btn_link_tour.FlatAppearance.BorderSize = 0;
            btn_link_tour.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_tour.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_tour.FlatStyle = FlatStyle.Flat;
            btn_link_tour.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_tour.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_tour.Location = new Point(13, 497);
            btn_link_tour.Margin = new Padding(3, 4, 3, 4);
            btn_link_tour.Name = "btn_link_tour";
            btn_link_tour.Size = new Size(279, 69);
            btn_link_tour.TabIndex = 16;
            btn_link_tour.Text = "Tour";
            btn_link_tour.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_tour.UseVisualStyleBackColor = false;
            btn_link_tour.Click += btn_link_tour_Click;
            // 
            // btn_link_dichvucungcap
            // 
            btn_link_dichvucungcap.BackColor = Color.Transparent;
            btn_link_dichvucungcap.Cursor = Cursors.Hand;
            btn_link_dichvucungcap.FlatAppearance.BorderSize = 0;
            btn_link_dichvucungcap.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_dichvucungcap.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_dichvucungcap.FlatStyle = FlatStyle.Flat;
            btn_link_dichvucungcap.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_dichvucungcap.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_dichvucungcap.Location = new Point(13, 420);
            btn_link_dichvucungcap.Margin = new Padding(3, 4, 3, 4);
            btn_link_dichvucungcap.Name = "btn_link_dichvucungcap";
            btn_link_dichvucungcap.Size = new Size(279, 69);
            btn_link_dichvucungcap.TabIndex = 15;
            btn_link_dichvucungcap.Text = "Dịch vụ cung cấp";
            btn_link_dichvucungcap.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_dichvucungcap.UseVisualStyleBackColor = false;
            btn_link_dichvucungcap.Click += btn_link_dichvucungcap_Click;
            // 
            // btn_link_sanphan_dichvu
            // 
            btn_link_sanphan_dichvu.BackColor = Color.Transparent;
            btn_link_sanphan_dichvu.Cursor = Cursors.Hand;
            btn_link_sanphan_dichvu.FlatAppearance.BorderSize = 0;
            btn_link_sanphan_dichvu.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_sanphan_dichvu.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_sanphan_dichvu.FlatStyle = FlatStyle.Flat;
            btn_link_sanphan_dichvu.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_sanphan_dichvu.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_sanphan_dichvu.Location = new Point(13, 343);
            btn_link_sanphan_dichvu.Margin = new Padding(3, 4, 3, 4);
            btn_link_sanphan_dichvu.Name = "btn_link_sanphan_dichvu";
            btn_link_sanphan_dichvu.Size = new Size(279, 69);
            btn_link_sanphan_dichvu.TabIndex = 14;
            btn_link_sanphan_dichvu.Text = "Sản phẩm, dịch vụ";
            btn_link_sanphan_dichvu.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_sanphan_dichvu.UseVisualStyleBackColor = false;
            // 
            // btn_link_thongtinphong
            // 
            btn_link_thongtinphong.BackColor = SystemColors.ButtonFace;
            btn_link_thongtinphong.Cursor = Cursors.Hand;
            btn_link_thongtinphong.FlatAppearance.BorderSize = 0;
            btn_link_thongtinphong.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_thongtinphong.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_thongtinphong.FlatStyle = FlatStyle.Flat;
            btn_link_thongtinphong.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_thongtinphong.ForeColor = Color.FromArgb(255, 0, 61);
            btn_link_thongtinphong.Location = new Point(13, 265);
            btn_link_thongtinphong.Margin = new Padding(3, 4, 3, 4);
            btn_link_thongtinphong.Name = "btn_link_thongtinphong";
            btn_link_thongtinphong.Size = new Size(279, 69);
            btn_link_thongtinphong.TabIndex = 13;
            btn_link_thongtinphong.Text = "Thông tin phòng";
            btn_link_thongtinphong.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_thongtinphong.UseVisualStyleBackColor = false;
            // 
            // btn_link_datphong
            // 
            btn_link_datphong.BackColor = Color.Transparent;
            btn_link_datphong.Cursor = Cursors.Hand;
            btn_link_datphong.FlatAppearance.BorderSize = 0;
            btn_link_datphong.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_datphong.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_datphong.FlatStyle = FlatStyle.Flat;
            btn_link_datphong.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_datphong.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_datphong.Location = new Point(13, 188);
            btn_link_datphong.Margin = new Padding(3, 4, 3, 4);
            btn_link_datphong.Name = "btn_link_datphong";
            btn_link_datphong.Size = new Size(279, 69);
            btn_link_datphong.TabIndex = 11;
            btn_link_datphong.Text = "Phiếu đặt phòng";
            btn_link_datphong.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_datphong.UseVisualStyleBackColor = false;
            btn_link_datphong.Click += btn_link_datphong_Click;
            // 
            // btn_link_khachhang
            // 
            btn_link_khachhang.BackColor = Color.Transparent;
            btn_link_khachhang.FlatAppearance.BorderSize = 0;
            btn_link_khachhang.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            btn_link_khachhang.FlatAppearance.MouseOverBackColor = SystemColors.AppWorkspace;
            btn_link_khachhang.FlatStyle = FlatStyle.Flat;
            btn_link_khachhang.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_khachhang.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_khachhang.Location = new Point(13, 111);
            btn_link_khachhang.Margin = new Padding(3, 4, 3, 4);
            btn_link_khachhang.Name = "btn_link_khachhang";
            btn_link_khachhang.Size = new Size(279, 69);
            btn_link_khachhang.TabIndex = 1;
            btn_link_khachhang.Text = "Khách hàng";
            btn_link_khachhang.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_khachhang.UseVisualStyleBackColor = false;
            btn_link_khachhang.Click += btn_link_khachhang_Click;
            // 
            // panel11
            // 
            panel11.Location = new Point(315, 0);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(1127, 904);
            panel11.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(13, 101);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 1);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(189, 58);
            label1.TabIndex = 2;
            label1.Text = "Trang chủ";
            // 
            // fInfoRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.R;
            ClientSize = new Size(1445, 908);
            Controls.Add(panel2);
            Controls.Add(panel13);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fInfoRoom";
            Text = "fInfoRoom";
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel13.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel17;
        private Label label12;
        private Panel panel13;
        private Panel panel16;
        private Panel panel14;
        private Panel panel2;
        private Button btn_link_vanchuyenhanhly;
        private Button btn_link_kiemtraminibar;
        private Button btn_link_kiemtraphong;
        private Button btn_link_tour;
        private Button btn_link_dichvucungcap;
        private Button btn_link_sanphan_dichvu;
        private Button btn_link_thongtinphong;
        private Button btn_link_datphong;
        private Button btn_link_khachhang;
        private Panel panel11;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
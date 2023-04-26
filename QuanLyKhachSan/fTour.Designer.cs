namespace QuanLyKhachSan
{
    partial class fTour
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
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            panel15 = new Panel();
            panel14 = new Panel();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            panel16 = new Panel();
            panel13 = new Panel();
            btn_add = new Button();
            panel2 = new Panel();
            btn_link_vanchuyenhanhly = new Button();
            btn_link_kiemtraminibar = new Button();
            btn_link_kiemtraphong = new Button();
            btn_link_tour = new Button();
            btn_link_dichvucungcap = new Button();
            btn_link_sanphan_dichvu = new Button();
            btn_link_thongtinphong = new Button();
            btn_link_khachhangchodat = new Button();
            btn_link_datphong = new Button();
            btn_link_khachhang = new Button();
            panel11 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel16.SuspendLayout();
            panel13.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(97, 16);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(380, 39);
            textBoxSearch.TabIndex = 0;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearch.Location = new Point(-9, -13);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(64, 57);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "";
            labelSearch.Click += label10_Click;
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.Controls.Add(labelSearch);
            panel15.Location = new Point(477, 17);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(41, 40);
            panel15.TabIndex = 2;
            // 
            // panel14
            // 
            panel14.Controls.Add(panel15);
            panel14.Controls.Add(textBoxSearch);
            panel14.Location = new Point(3, 4);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(1120, 80);
            panel14.TabIndex = 0;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(42, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1039, 705);
            dataGridView1.TabIndex = 0;
            // 
            // panel16
            // 
            panel16.Controls.Add(dataGridView1);
            panel16.Location = new Point(3, 88);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(1120, 724);
            panel16.TabIndex = 1;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Transparent;
            panel13.Controls.Add(btn_add);
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(317, 1);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(1127, 904);
            panel13.TabIndex = 6;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(159, 209, 147);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Location = new Point(935, 820);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(149, 64);
            btn_add.TabIndex = 44;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
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
            panel2.Controls.Add(btn_link_khachhangchodat);
            panel2.Controls.Add(btn_link_datphong);
            panel2.Controls.Add(btn_link_khachhang);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 916);
            panel2.TabIndex = 7;
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
            btn_link_vanchuyenhanhly.Location = new Point(13, 807);
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
            btn_link_kiemtraminibar.Location = new Point(13, 729);
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
            btn_link_kiemtraphong.Location = new Point(13, 652);
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
            btn_link_tour.BackColor = SystemColors.ButtonFace;
            btn_link_tour.Cursor = Cursors.Hand;
            btn_link_tour.FlatAppearance.BorderSize = 0;
            btn_link_tour.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_tour.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_tour.FlatStyle = FlatStyle.Flat;
            btn_link_tour.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_tour.ForeColor = Color.FromArgb(255, 0, 61);
            btn_link_tour.Location = new Point(13, 575);
            btn_link_tour.Margin = new Padding(3, 4, 3, 4);
            btn_link_tour.Name = "btn_link_tour";
            btn_link_tour.Size = new Size(279, 69);
            btn_link_tour.TabIndex = 16;
            btn_link_tour.Text = "Tour";
            btn_link_tour.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_tour.UseVisualStyleBackColor = false;
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
            btn_link_dichvucungcap.Location = new Point(13, 497);
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
            btn_link_sanphan_dichvu.Location = new Point(13, 420);
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
            btn_link_thongtinphong.BackColor = Color.Transparent;
            btn_link_thongtinphong.Cursor = Cursors.Hand;
            btn_link_thongtinphong.FlatAppearance.BorderSize = 0;
            btn_link_thongtinphong.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_thongtinphong.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_thongtinphong.FlatStyle = FlatStyle.Flat;
            btn_link_thongtinphong.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_thongtinphong.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_thongtinphong.Location = new Point(13, 343);
            btn_link_thongtinphong.Margin = new Padding(3, 4, 3, 4);
            btn_link_thongtinphong.Name = "btn_link_thongtinphong";
            btn_link_thongtinphong.Size = new Size(279, 69);
            btn_link_thongtinphong.TabIndex = 13;
            btn_link_thongtinphong.Text = "Thông tin phòng";
            btn_link_thongtinphong.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_thongtinphong.UseVisualStyleBackColor = false;
            btn_link_thongtinphong.Click += btn_link_thongtinphong_Click;
            // 
            // btn_link_khachhangchodat
            // 
            btn_link_khachhangchodat.BackColor = Color.Transparent;
            btn_link_khachhangchodat.Cursor = Cursors.Hand;
            btn_link_khachhangchodat.FlatAppearance.BorderSize = 0;
            btn_link_khachhangchodat.FlatAppearance.MouseDownBackColor = SystemColors.AppWorkspace;
            btn_link_khachhangchodat.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
            btn_link_khachhangchodat.FlatStyle = FlatStyle.Flat;
            btn_link_khachhangchodat.Font = new Font("Sitka Banner", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_link_khachhangchodat.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btn_link_khachhangchodat.Location = new Point(13, 265);
            btn_link_khachhangchodat.Margin = new Padding(3, 4, 3, 4);
            btn_link_khachhangchodat.Name = "btn_link_khachhangchodat";
            btn_link_khachhangchodat.Size = new Size(279, 69);
            btn_link_khachhangchodat.TabIndex = 12;
            btn_link_khachhangchodat.Text = "Khách hàng chờ đặt";
            btn_link_khachhangchodat.TextAlign = ContentAlignment.MiddleLeft;
            btn_link_khachhangchodat.UseVisualStyleBackColor = false;
            btn_link_khachhangchodat.Click += btn_link_khachhangchodat_Click;
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
            label1.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(189, 58);
            label1.TabIndex = 2;
            label1.Text = "Trang chủ";
            label1.Click += label1_Click;
            // 
            // fTour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.R;
            ClientSize = new Size(1445, 908);
            Controls.Add(panel2);
            Controls.Add(panel13);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fTour";
            Text = "fTour";
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel16.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxSearch;
        private Label labelSearch;
        private Panel panel15;
        private Panel panel14;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dataGridView1;
        private Panel panel16;
        private Panel panel13;
        private Panel panel2;
        private Button btn_link_vanchuyenhanhly;
        private Button btn_link_kiemtraminibar;
        private Button btn_link_kiemtraphong;
        private Button btn_link_tour;
        private Button btn_link_dichvucungcap;
        private Button btn_link_sanphan_dichvu;
        private Button btn_link_thongtinphong;
        private Button btn_link_khachhangchodat;
        private Button btn_link_datphong;
        private Button btn_link_khachhang;
        private Panel panel11;
        private Panel panel1;
        private Label label1;
        private Button btn_add;
    }
}
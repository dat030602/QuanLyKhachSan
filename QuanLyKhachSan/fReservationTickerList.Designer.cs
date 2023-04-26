namespace QuanLyKhachSan
{
    partial class fReservationTickerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.tableGrid = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnAddReservationTicker = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_link_vanchuyenhanhly = new System.Windows.Forms.Button();
            this.btn_link_kiemtraminibar = new System.Windows.Forms.Button();
            this.btn_link_kiemtraphong = new System.Windows.Forms.Button();
            this.btn_link_tour = new System.Windows.Forms.Button();
            this.btn_link_dichvucungcap = new System.Windows.Forms.Button();
            this.btn_link_sanphan_dichvu = new System.Windows.Forms.Button();
            this.btn_link_thongtinphong = new System.Windows.Forms.Button();
            this.btn_link_khachhangchodat = new System.Windows.Forms.Button();
            this.btn_link_datphong = new System.Windows.Forms.Button();
            this.btn_link_khachhang = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.Controls.Add(this.btn_submit);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(277, 1);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(986, 678);
            this.panel13.TabIndex = 4;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_submit.Location = new System.Drawing.Point(785, 620);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(163, 48);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Phân công";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.tableGrid);
            this.panel16.Location = new System.Drawing.Point(3, 66);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(980, 543);
            this.panel16.TabIndex = 1;
            // 
            // tableGrid
            // 
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle43;
            this.tableGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableGrid.ColumnHeadersHeight = 32;
            this.tableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.CMND,
            this.HoTen,
            this.DiaChi,
            this.SoFax});
            this.tableGrid.Location = new System.Drawing.Point(36, 7);
            this.tableGrid.Margin = new System.Windows.Forms.Padding(0);
            this.tableGrid.MultiSelect = false;
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.ReadOnly = true;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.tableGrid.RowTemplate.Height = 32;
            this.tableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableGrid.Size = new System.Drawing.Size(909, 529);
            this.tableGrid.TabIndex = 1;
            // 
            // MaKH
            // 
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaKH.DefaultCellStyle = dataGridViewCellStyle44;
            this.MaKH.HeaderText = "Mã Khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 115;
            // 
            // CMND
            // 
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CMND.DefaultCellStyle = dataGridViewCellStyle45;
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            this.CMND.Width = 150;
            // 
            // HoTen
            // 
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HoTen.DefaultCellStyle = dataGridViewCellStyle46;
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 200;
            // 
            // DiaChi
            // 
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiaChi.DefaultCellStyle = dataGridViewCellStyle47;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 245;
            // 
            // SoFax
            // 
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Inter", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SoFax.DefaultCellStyle = dataGridViewCellStyle48;
            this.SoFax.HeaderText = "Số Fax";
            this.SoFax.Name = "SoFax";
            this.SoFax.ReadOnly = true;
            this.SoFax.Width = 150;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnAddReservationTicker);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.textBoxSearch);
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(980, 60);
            this.panel14.TabIndex = 0;
            // 
            // btnAddReservationTicker
            // 
            this.btnAddReservationTicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddReservationTicker.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.plus_icon_black_2;
            this.btnAddReservationTicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddReservationTicker.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddReservationTicker.Location = new System.Drawing.Point(900, 12);
            this.btnAddReservationTicker.Name = "btnAddReservationTicker";
            this.btnAddReservationTicker.Size = new System.Drawing.Size(45, 42);
            this.btnAddReservationTicker.TabIndex = 4;
            this.btnAddReservationTicker.UseVisualStyleBackColor = false;
            this.btnAddReservationTicker.Click += new System.EventHandler(this.btnAddReservationTicker_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.label10);
            this.panel15.Location = new System.Drawing.Point(417, 13);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(36, 30);
            this.panel15.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(-6, -11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 46);
            this.label10.TabIndex = 0;
            this.label10.Text = "";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(85, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(333, 32);
            this.textBoxSearch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btn_link_vanchuyenhanhly);
            this.panel2.Controls.Add(this.btn_link_kiemtraminibar);
            this.panel2.Controls.Add(this.btn_link_kiemtraphong);
            this.panel2.Controls.Add(this.btn_link_tour);
            this.panel2.Controls.Add(this.btn_link_dichvucungcap);
            this.panel2.Controls.Add(this.btn_link_sanphan_dichvu);
            this.panel2.Controls.Add(this.btn_link_thongtinphong);
            this.panel2.Controls.Add(this.btn_link_khachhangchodat);
            this.panel2.Controls.Add(this.btn_link_datphong);
            this.panel2.Controls.Add(this.btn_link_khachhang);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 687);
            this.panel2.TabIndex = 5;
            // 
            // btn_link_vanchuyenhanhly
            // 
            this.btn_link_vanchuyenhanhly.BackColor = System.Drawing.Color.Transparent;
            this.btn_link_vanchuyenhanhly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link_vanchuyenhanhly.FlatAppearance.BorderSize = 0;
            this.btn_link_vanchuyenhanhly.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_vanchuyenhanhly.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_vanchuyenhanhly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_vanchuyenhanhly.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_vanchuyenhanhly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_link_vanchuyenhanhly.Location = new System.Drawing.Point(11, 605);
            this.btn_link_vanchuyenhanhly.Name = "btn_link_vanchuyenhanhly";
            this.btn_link_vanchuyenhanhly.Size = new System.Drawing.Size(244, 52);
            this.btn_link_vanchuyenhanhly.TabIndex = 19;
            this.btn_link_vanchuyenhanhly.Text = "Vận chuyển hành lý";
            this.btn_link_vanchuyenhanhly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_vanchuyenhanhly.UseVisualStyleBackColor = false;
            // 
            // btn_link_kiemtraminibar
            // 
            this.btn_link_kiemtraminibar.BackColor = System.Drawing.Color.Transparent;
            this.btn_link_kiemtraminibar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link_kiemtraminibar.FlatAppearance.BorderSize = 0;
            this.btn_link_kiemtraminibar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_kiemtraminibar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_kiemtraminibar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_kiemtraminibar.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_kiemtraminibar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_link_kiemtraminibar.Location = new System.Drawing.Point(11, 547);
            this.btn_link_kiemtraminibar.Name = "btn_link_kiemtraminibar";
            this.btn_link_kiemtraminibar.Size = new System.Drawing.Size(244, 52);
            this.btn_link_kiemtraminibar.TabIndex = 18;
            this.btn_link_kiemtraminibar.Text = "Kiểm tra minibar";
            this.btn_link_kiemtraminibar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_kiemtraminibar.UseVisualStyleBackColor = false;
            this.btn_link_kiemtraminibar.Click += new System.EventHandler(this.btn_link_kiemtraminibar_Click);
            // 
            // btn_link_kiemtraphong
            // 
            this.btn_link_kiemtraphong.BackColor = System.Drawing.Color.Transparent;
            this.btn_link_kiemtraphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link_kiemtraphong.FlatAppearance.BorderSize = 0;
            this.btn_link_kiemtraphong.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_kiemtraphong.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_kiemtraphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_kiemtraphong.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_kiemtraphong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_link_kiemtraphong.Location = new System.Drawing.Point(11, 489);
            this.btn_link_kiemtraphong.Name = "btn_link_kiemtraphong";
            this.btn_link_kiemtraphong.Size = new System.Drawing.Size(244, 52);
            this.btn_link_kiemtraphong.TabIndex = 17;
            this.btn_link_kiemtraphong.Text = "Kiểm tra phòng";
            this.btn_link_kiemtraphong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_kiemtraphong.UseVisualStyleBackColor = false;
            this.btn_link_kiemtraphong.Click += new System.EventHandler(this.btn_link_kiemtraphong_Click);
            // 
            // btn_link_tour
            // 
            this.btn_link_tour.BackColor = System.Drawing.Color.Transparent;
            this.btn_link_tour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link_tour.FlatAppearance.BorderSize = 0;
            this.btn_link_tour.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_tour.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_tour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_tour.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_tour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_link_tour.Location = new System.Drawing.Point(11, 431);
            this.btn_link_tour.Name = "btn_link_tour";
            this.btn_link_tour.Size = new System.Drawing.Size(244, 52);
            this.btn_link_tour.TabIndex = 16;
            this.btn_link_tour.Text = "Tour";
            this.btn_link_tour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_tour.UseVisualStyleBackColor = false;
            this.btn_link_tour.Click += new System.EventHandler(this.btn_link_tour_Click);
            // 
            // btn_link_dichvucungcap
            // 
            this.btn_link_dichvucungcap.BackColor = System.Drawing.Color.Transparent;
            this.btn_link_dichvucungcap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link_dichvucungcap.FlatAppearance.BorderSize = 0;
            this.btn_link_dichvucungcap.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_dichvucungcap.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_dichvucungcap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_dichvucungcap.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_dichvucungcap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_link_dichvucungcap.Location = new System.Drawing.Point(11, 373);
            this.btn_link_dichvucungcap.Name = "btn_link_dichvucungcap";
            this.btn_link_dichvucungcap.Size = new System.Drawing.Size(244, 52);
            this.btn_link_dichvucungcap.TabIndex = 15;
            this.btn_link_dichvucungcap.Text = "Dịch vụ cung cấp";
            this.btn_link_dichvucungcap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_dichvucungcap.UseVisualStyleBackColor = false;
            this.btn_link_dichvucungcap.Click += new System.EventHandler(this.btn_link_dichvucungcap_Click);
            // 
            // btn_link_sanphan_dichvu
            // 
            this.btn_link_sanphan_dichvu.BackColor = System.Drawing.Color.Transparent;
            this.btn_link_sanphan_dichvu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link_sanphan_dichvu.FlatAppearance.BorderSize = 0;
            this.btn_link_sanphan_dichvu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_sanphan_dichvu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_sanphan_dichvu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_sanphan_dichvu.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_sanphan_dichvu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_link_sanphan_dichvu.Location = new System.Drawing.Point(11, 315);
            this.btn_link_sanphan_dichvu.Name = "btn_link_sanphan_dichvu";
            this.btn_link_sanphan_dichvu.Size = new System.Drawing.Size(244, 52);
            this.btn_link_sanphan_dichvu.TabIndex = 14;
            this.btn_link_sanphan_dichvu.Text = "Sản phẩm, dịch vụ";
            this.btn_link_sanphan_dichvu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_sanphan_dichvu.UseVisualStyleBackColor = false;
            // 
            // btn_link_thongtinphong
            // 
            this.btn_link_thongtinphong.BackColor = System.Drawing.Color.Transparent;
            this.btn_link_thongtinphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link_thongtinphong.FlatAppearance.BorderSize = 0;
            this.btn_link_thongtinphong.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_thongtinphong.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_thongtinphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_thongtinphong.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_thongtinphong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_link_thongtinphong.Location = new System.Drawing.Point(11, 257);
            this.btn_link_thongtinphong.Name = "btn_link_thongtinphong";
            this.btn_link_thongtinphong.Size = new System.Drawing.Size(244, 52);
            this.btn_link_thongtinphong.TabIndex = 13;
            this.btn_link_thongtinphong.Text = "Thông tin phòng";
            this.btn_link_thongtinphong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_thongtinphong.UseVisualStyleBackColor = false;
            this.btn_link_thongtinphong.Click += new System.EventHandler(this.btn_link_thongtinphong_Click);
            // 
            // btn_link_khachhangchodat
            // 
            this.btn_link_khachhangchodat.BackColor = System.Drawing.Color.Transparent;
            this.btn_link_khachhangchodat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link_khachhangchodat.FlatAppearance.BorderSize = 0;
            this.btn_link_khachhangchodat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_khachhangchodat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_khachhangchodat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_khachhangchodat.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_khachhangchodat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_link_khachhangchodat.Location = new System.Drawing.Point(11, 199);
            this.btn_link_khachhangchodat.Name = "btn_link_khachhangchodat";
            this.btn_link_khachhangchodat.Size = new System.Drawing.Size(244, 52);
            this.btn_link_khachhangchodat.TabIndex = 12;
            this.btn_link_khachhangchodat.Text = "Khách hàng chờ đặt";
            this.btn_link_khachhangchodat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_khachhangchodat.UseVisualStyleBackColor = false;
            this.btn_link_khachhangchodat.Click += new System.EventHandler(this.btn_link_khachhangchodat_Click);
            // 
            // btn_link_datphong
            // 
            this.btn_link_datphong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_datphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link_datphong.FlatAppearance.BorderSize = 0;
            this.btn_link_datphong.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_datphong.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_datphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_datphong.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_datphong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(61)))));
            this.btn_link_datphong.Location = new System.Drawing.Point(11, 141);
            this.btn_link_datphong.Name = "btn_link_datphong";
            this.btn_link_datphong.Size = new System.Drawing.Size(244, 52);
            this.btn_link_datphong.TabIndex = 11;
            this.btn_link_datphong.Text = "Phiếu đặt phòng";
            this.btn_link_datphong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_datphong.UseVisualStyleBackColor = false;
            // 
            // btn_link_khachhang
            // 
            this.btn_link_khachhang.BackColor = System.Drawing.Color.Transparent;
            this.btn_link_khachhang.FlatAppearance.BorderSize = 0;
            this.btn_link_khachhang.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_link_khachhang.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_link_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link_khachhang.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_link_khachhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_link_khachhang.Location = new System.Drawing.Point(11, 83);
            this.btn_link_khachhang.Name = "btn_link_khachhang";
            this.btn_link_khachhang.Size = new System.Drawing.Size(244, 52);
            this.btn_link_khachhang.TabIndex = 1;
            this.btn_link_khachhang.Text = "Khách hàng";
            this.btn_link_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_link_khachhang.UseVisualStyleBackColor = false;
            this.btn_link_khachhang.Click += new System.EventHandler(this.btn_link_khachhang_Click);
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(276, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(986, 678);
            this.panel11.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(11, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 1);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trang chủ";
            // 
            // fReservationTickerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.R;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel13);
            this.Name = "fReservationTickerList";
            this.Text = "fReservationTickerList";
            this.Load += new System.EventHandler(this.fReservationTickerList_Load);
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel13;
        private Panel panel16;
        private Panel panel14;
        private Panel panel15;
        private Label label10;
        private Button btnAddReservationTicker;
        private TextBox textBoxSearch;
        private DataGridView tableGrid;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoFax;
        private Button btn_submit;
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
    }
}
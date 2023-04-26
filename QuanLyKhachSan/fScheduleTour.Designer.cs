namespace QuanLyKhachSan
{
    partial class fScheduleTour
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
            panel13 = new Panel();
            panel1 = new Panel();
            btn_back = new Button();
            button_complete = new Button();
            panel16 = new Panel();
            btn_xoa = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel14 = new Panel();
            btn_add = new Button();
            textBoxSoLuong = new TextBox();
            textBoxThoiGian = new TextBox();
            comboBoxDichVu = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label18 = new Label();
            comboBoxTour = new ComboBox();
            textBoxYcdb = new TextBox();
            textBoxMaKH = new TextBox();
            panel18 = new Panel();
            label13 = new Label();
            panel13.SuspendLayout();
            panel1.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel14.SuspendLayout();
            panel18.SuspendLayout();
            SuspendLayout();
            // 
            // panel13
            // 
            panel13.BackColor = Color.Transparent;
            panel13.Controls.Add(panel1);
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(2, 1);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(1441, 904);
            panel13.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_back);
            panel1.Controls.Add(button_complete);
            panel1.Location = new Point(3, 790);
            panel1.Name = "panel1";
            panel1.Size = new Size(1425, 105);
            panel1.TabIndex = 2;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.Location = new Point(34, 23);
            btn_back.Margin = new Padding(3, 4, 3, 4);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(141, 64);
            btn_back.TabIndex = 46;
            btn_back.Text = "< Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // button_complete
            // 
            button_complete.BackColor = Color.FromArgb(159, 209, 147);
            button_complete.FlatAppearance.BorderSize = 0;
            button_complete.FlatStyle = FlatStyle.Flat;
            button_complete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button_complete.Location = new Point(1206, 23);
            button_complete.Margin = new Padding(3, 4, 3, 4);
            button_complete.Name = "button_complete";
            button_complete.Size = new Size(149, 64);
            button_complete.TabIndex = 45;
            button_complete.Text = "Hoàn thành";
            button_complete.UseVisualStyleBackColor = false;
            button_complete.Click += button_complete_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(btn_xoa);
            panel16.Controls.Add(dataGridView1);
            panel16.Location = new Point(3, 369);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(1425, 416);
            panel16.TabIndex = 1;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.FromArgb(241, 146, 117);
            btn_xoa.FlatAppearance.BorderSize = 0;
            btn_xoa.FlatStyle = FlatStyle.Flat;
            btn_xoa.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.Location = new Point(1206, 326);
            btn_xoa.Margin = new Padding(3, 4, 3, 4);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(105, 64);
            btn_xoa.TabIndex = 9;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(243, 29);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(873, 361);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // panel14
            // 
            panel14.Controls.Add(btn_add);
            panel14.Controls.Add(textBoxSoLuong);
            panel14.Controls.Add(textBoxThoiGian);
            panel14.Controls.Add(comboBoxDichVu);
            panel14.Controls.Add(label6);
            panel14.Controls.Add(label5);
            panel14.Controls.Add(label4);
            panel14.Controls.Add(label2);
            panel14.Controls.Add(label1);
            panel14.Controls.Add(label18);
            panel14.Controls.Add(comboBoxTour);
            panel14.Controls.Add(textBoxYcdb);
            panel14.Controls.Add(textBoxMaKH);
            panel14.Controls.Add(panel18);
            panel14.Location = new Point(3, 4);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(1425, 357);
            panel14.TabIndex = 0;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(159, 209, 147);
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.Location = new Point(1224, 272);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(149, 64);
            btn_add.TabIndex = 45;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // textBoxSoLuong
            // 
            textBoxSoLuong.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSoLuong.Location = new Point(1000, 162);
            textBoxSoLuong.Margin = new Padding(3, 4, 3, 4);
            textBoxSoLuong.Name = "textBoxSoLuong";
            textBoxSoLuong.Size = new Size(373, 39);
            textBoxSoLuong.TabIndex = 24;
            // 
            // textBoxThoiGian
            // 
            textBoxThoiGian.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxThoiGian.Location = new Point(1000, 102);
            textBoxThoiGian.Margin = new Padding(3, 4, 3, 4);
            textBoxThoiGian.Name = "textBoxThoiGian";
            textBoxThoiGian.Size = new Size(373, 39);
            textBoxThoiGian.TabIndex = 23;
            // 
            // comboBoxDichVu
            // 
            comboBoxDichVu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDichVu.FormattingEnabled = true;
            comboBoxDichVu.Location = new Point(243, 173);
            comboBoxDichVu.Margin = new Padding(3, 4, 3, 4);
            comboBoxDichVu.Name = "comboBoxDichVu";
            comboBoxDichVu.Size = new Size(373, 39);
            comboBoxDichVu.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(766, 169);
            label6.Name = "label6";
            label6.Size = new Size(110, 32);
            label6.TabIndex = 21;
            label6.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(766, 108);
            label5.Name = "label5";
            label5.Size = new Size(228, 32);
            label5.TabIndex = 19;
            label5.Text = "Thời gian khởi hành";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 247);
            label4.Name = "label4";
            label4.Size = new Size(188, 32);
            label4.TabIndex = 18;
            label4.Text = "Yêu cầu đặc biệt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 173);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 0;
            label2.Text = "Dịch vụ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 109);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 0;
            label1.Text = "Tour";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(34, 27);
            label18.Name = "label18";
            label18.Size = new Size(191, 57);
            label18.TabIndex = 16;
            label18.Text = "Đặt tour";
            // 
            // comboBoxTour
            // 
            comboBoxTour.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTour.FormattingEnabled = true;
            comboBoxTour.Location = new Point(243, 108);
            comboBoxTour.Margin = new Padding(3, 4, 3, 4);
            comboBoxTour.Name = "comboBoxTour";
            comboBoxTour.Size = new Size(373, 39);
            comboBoxTour.TabIndex = 15;
            comboBoxTour.SelectedIndexChanged += comboBoxTour_SelectedIndexChanged;
            // 
            // textBoxYcdb
            // 
            textBoxYcdb.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYcdb.Location = new Point(243, 247);
            textBoxYcdb.Margin = new Padding(3, 4, 3, 4);
            textBoxYcdb.Name = "textBoxYcdb";
            textBoxYcdb.Size = new Size(373, 39);
            textBoxYcdb.TabIndex = 13;
            // 
            // textBoxMaKH
            // 
            textBoxMaKH.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMaKH.Location = new Point(721, 37);
            textBoxMaKH.Margin = new Padding(3, 4, 3, 4);
            textBoxMaKH.Name = "textBoxMaKH";
            textBoxMaKH.Size = new Size(211, 39);
            textBoxMaKH.TabIndex = 9;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(151, 71, 255);
            panel18.Controls.Add(label13);
            panel18.Cursor = Cursors.Hand;
            panel18.Location = new Point(551, 37);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(141, 39);
            panel18.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(28, 3);
            label13.Name = "label13";
            label13.Size = new Size(86, 32);
            label13.TabIndex = 0;
            label13.Text = "Mã KH";
            // 
            // fScheduleTour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 241);
            ClientSize = new Size(1445, 908);
            Controls.Add(panel13);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fScheduleTour";
            Text = "fScheduleService";
            panel13.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel13;
        private Panel panel16;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel14;
        private Panel panel18;
        private Label label13;
        private ComboBox comboBoxTour;
        private TextBox textBoxYcdb;
        private Label label2;
        private Label label1;
        private TextBox textBoxMaKH;
        private Label label18;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox textBoxSoLuong;
        private TextBox textBoxThoiGian;
        private ComboBox comboBoxDichVu;
        private Panel panel1;
        private Button btn_xoa;
        private Button button_complete;
        private Button btn_add;
        private Button btn_back;
    }
}
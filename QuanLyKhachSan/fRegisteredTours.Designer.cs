namespace QuanLyKhachSan
{
    partial class fRegisteredTours
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            textBoxMaKH = new TextBox();
            panel18 = new Panel();
            label13 = new Label();
            label18 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btn_huy = new Button();
            button_complete = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel18.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1444, 902);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxMaKH);
            panel3.Controls.Add(panel18);
            panel3.Controls.Add(label18);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1441, 179);
            panel3.TabIndex = 0;
            // 
            // textBoxMaKH
            // 
            textBoxMaKH.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMaKH.Location = new Point(721, 37);
            textBoxMaKH.Margin = new Padding(3, 4, 3, 4);
            textBoxMaKH.Name = "textBoxMaKH";
            textBoxMaKH.Size = new Size(211, 39);
            textBoxMaKH.TabIndex = 19;
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
            panel18.TabIndex = 18;
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
            // label18
            // 
            label18.Anchor = AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(34, 27);
            label18.Name = "label18";
            label18.Size = new Size(347, 57);
            label18.TabIndex = 17;
            label18.Text = "Tour đã đăng ký";
            label18.Click += label18_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(1444, 539);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(157, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1120, 436);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên tour";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Dịch vụ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Thời gian khởi hành";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Yêu cầu đặc biệt";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_huy);
            panel2.Controls.Add(button_complete);
            panel2.Location = new Point(0, 733);
            panel2.Name = "panel2";
            panel2.Size = new Size(1444, 162);
            panel2.TabIndex = 2;
            // 
            // btn_huy
            // 
            btn_huy.BackColor = Color.FromArgb(241, 146, 117);
            btn_huy.FlatAppearance.BorderSize = 0;
            btn_huy.FlatStyle = FlatStyle.Flat;
            btn_huy.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_huy.Location = new Point(1065, 23);
            btn_huy.Margin = new Padding(3, 4, 3, 4);
            btn_huy.Name = "btn_huy";
            btn_huy.Size = new Size(105, 64);
            btn_huy.TabIndex = 47;
            btn_huy.Text = "Hủy";
            btn_huy.UseVisualStyleBackColor = false;
            btn_huy.Click += btn_huy_Click;
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
            button_complete.TabIndex = 46;
            button_complete.Text = "Hoàn thành";
            button_complete.UseVisualStyleBackColor = false;
            // 
            // fRegisteredTours
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 241, 241);
            ClientSize = new Size(1445, 908);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "fRegisteredTours";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fRegisteredTours";
            Load += fRegisteredTours_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label18;
        private Panel panel18;
        private Label label13;
        private Button button_complete;
        private Button btn_huy;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        public TextBox textBoxMaKH;
    }
}
namespace QuanLyKhachSan
{
    partial class fLuggageTransportList
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
            panel2 = new Panel();
            label1 = new Label();
            label17 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnDangKy = new Button();
            btnBack = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(16, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1417, 101);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1726, 20);
            label1.Name = "label1";
            label1.Size = new Size(436, 57);
            label1.TabIndex = 9;
            label1.Text = "Lập phiếu đặt phòng";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(2998, 4);
            label17.Name = "label17";
            label17.Size = new Size(436, 57);
            label17.TabIndex = 8;
            label17.Text = "Lập phiếu đặt phòng";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(4826, 7);
            label4.Name = "label4";
            label4.Size = new Size(42, 32);
            label4.TabIndex = 6;
            label4.Text = "35";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(4658, 7);
            label3.Name = "label3";
            label3.Size = new Size(192, 32);
            label3.TabIndex = 5;
            label3.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(316, 20);
            label2.Name = "label2";
            label2.Size = new Size(791, 57);
            label2.TabIndex = 10;
            label2.Text = "Danh sách đăng ký vận chuyển hành lý";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(16, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(1417, 631);
            panel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBack);
            panel3.Controls.Add(btnDangKy);
            panel3.Location = new Point(16, 758);
            panel3.Name = "panel3";
            panel3.Size = new Size(1417, 122);
            panel3.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(50, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1317, 571);
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
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(159, 209, 147);
            btnDangKy.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangKy.Location = new Point(1195, 40);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(172, 64);
            btnDangKy.TabIndex = 38;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(50, 40);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(171, 64);
            btnBack.TabIndex = 39;
            btnBack.Text = "< Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // fLuggageTransportList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 241);
            ClientSize = new Size(1445, 908);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fLuggageTransportList";
            Text = "fLuggageTransportList";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label17;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnDangKy;
        private Button btnBack;
    }
}
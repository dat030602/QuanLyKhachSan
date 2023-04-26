using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fCreateCustomer : Form
    {
        public fCreateCustomer()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textTenKhachHang.Text + textDienThoai.Text + textCMND.Text + textGioiTinh.Text + textNgaySinh.Text + textSofax.Text);
        }
    }
}

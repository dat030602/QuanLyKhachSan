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
    public partial class fCreateReservationTicket : Form
    {
        private string maKHfromCustomerList ="";
        private string maphieudatphong ="";
        public fCreateReservationTicket()
        {
            InitializeComponent();
        }
        public fCreateReservationTicket(string Message) : this()
        {
            maKHfromCustomerList = Message;
            maphieu.Text = maKHfromCustomerList;
            text_maKhachHang.Text = maKHfromCustomerList;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string stringInput1 = text_maKhachHang.Text;
            string stringInput2 = textNgayDen.Text;
            string stringInput3 = textNgaydi.Text;
            string stringInput4 = textHinhThucThanhToan.Text;
            string stringInput5 = textTenDoan.Text;
            string stringInput6 = textSoLuong.Text;
            MessageBox.Show(stringInput1+ stringInput2+ stringInput3+ stringInput4+ stringInput5+ stringInput6);
        }

        private void SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCreateDetailsReservationTicket form = new fCreateDetailsReservationTicket(maphieudatphong);
            form.ShowDialog();
            this.Show();
        }

        private void btn_YeuCauDacBiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSpecialRequirement form = new fSpecialRequirement(maphieudatphong);
            form.ShowDialog();
            this.Show();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

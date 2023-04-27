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
    public partial class fCheckRoom : Form
    {
        public fCheckRoom()
        {
            InitializeComponent();
        }

        private void btn_link_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCustomerList form = new fCustomerList();
            form.ShowDialog();
            this.Close();
        }

        private void btn_link_datphong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReservationTickerList form = new fReservationTickerList();
            form.ShowDialog();
            this.Close();
        }

        private void btn_link_khachhangchodat_Click(object sender, EventArgs e)
        {

        }

        private void btn_link_thongtinphong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fInfoRoom form = new fInfoRoom();
            form.ShowDialog();
            this.Close();
        }

        private void btn_link_dichvucungcap_Click(object sender, EventArgs e)
        {
            this.Hide();
            fServiceProvided form = new fServiceProvided();
            form.ShowDialog();
            this.Close();
        }

        private void btn_link_tour_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTour form = new fTour();
            form.ShowDialog();
            this.Close();
        }

        private void btn_link_kiemtraminibar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCheckMinibar form = new fCheckMinibar();
            form.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMainWindow form = new fMainWindow();
            form.ShowDialog();
            this.Close();
        }
    }
}

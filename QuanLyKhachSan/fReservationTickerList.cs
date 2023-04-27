using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace QuanLyKhachSan
{
    
    public partial class fReservationTickerList : Form
    {
        fRevervationTicket f = new fRevervationTicket();
        fDevideRoom f2 = new fDevideRoom();
        public fReservationTickerList()
        {
            InitializeComponent();
            
            //f.Hide();
            //f2.Hide();

        }

        private void btnDevideRoom_Click(object sender, EventArgs e)
        {
           
            //f2.Show();
            //this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void fReservationTickerList_Load(object sender, EventArgs e)
        {
            tableGrid.Rows.Add(1, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(2, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(3, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(4, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(4, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(6, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
        }
        private void btnAddReservationTicker_Click(object sender, EventArgs e)
        {
        
            //f.Show();
            //this.Hide();
        }

        private void btn_link_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCustomerList form = new fCustomerList();
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

        private void btn_link_kiemtraphong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCheckRoom form = new fCheckRoom();
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

        private void tableGrid_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPDH = tableGrid[1, rowIndex: e.RowIndex].Value.ToString();
            string maKH = tableGrid[2, rowIndex: e.RowIndex].Value.ToString();
            this.Hide();
            fRevervationTicket form = new fRevervationTicket(maPDH, maKH);
            form.ShowDialog();
            this.Show();
        }
    }
}

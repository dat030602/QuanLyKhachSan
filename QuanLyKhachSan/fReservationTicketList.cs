using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyKhachSan.fDevideRoom;
using static System.Windows.Forms.DataFormats;

namespace QuanLyKhachSan
{
    
    public partial class fReservationTicketList : Form
    {
        public static string sqlConn = DataConnection.sqlConn;
        public static SqlConnection conn = DataConnection.conn;
        fRevervationTicket f = new fRevervationTicket();
        fDevideRoom f2 = new fDevideRoom();
 
        public fReservationTicketList()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();

            }
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
        private void loadDataGrid(SqlConnection conn)
        {
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand("SELECT MaPhieuDat as N'Mã phiếu đặt phòng', MaKH as N'Mã khách hàng', NgayDat as 'Ngày đặt', NgayDen as N'Ngày đến', NgayDi as N'Ngày trả', TongTienPhong as N'Tổng tiền phòng'  FROM PHIEUDATPHONG", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                tableGrid.DataSource = dt;
            }
            tableGrid.RowHeaderMouseDoubleClick += (s, e) =>
            {
                foreach (DataGridViewRow r in tableGrid.SelectedRows)
                {
                    string maPDP = (tableGrid[0, r.Index].Value.ToString());
                    string maKH = (tableGrid[1, r.Index].Value.ToString());
             
                    this.Hide();
                    fRevervationTicket form = new fRevervationTicket(maPDP, maKH, true);
                    form.ShowDialog();
                    this.Show();

                }
            };
            

        }
        private void fReservationTickerList_Load(object sender, EventArgs e)
        {
            /*tableGrid.Rows.Add(1, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(2, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(3, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(4, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(4, "PDP2023", "KH003", "21/4/2023", "30/4/2023");
            tableGrid.Rows.Add(6, "PDP2023", "KH003", "21/4/2023", "30/4/2023");*/
            loadDataGrid(conn);
            if (tableGrid.SelectedRows.Count <= 0)
            {
                btn_submit.Enabled = false;
            }
            else
            {
                foreach (DataGridViewRow r in tableGrid.SelectedRows)
                {
                    btn_submit.Enabled = true;
                }
            }
            tableGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
        private void btn_submit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in tableGrid.SelectedRows)
            {
                string maPDP = (tableGrid[0, r.Index].Value.ToString());
                string maKH = (tableGrid[1, r.Index].Value.ToString());
                //string ngayDat = (tableGrid[2, r.Index].Value.ToString());
                string ngayDen = (tableGrid[3, r.Index].Value.ToString());
                string ngayDi = (tableGrid[4, r.Index].Value.ToString());
                //string tongTien = (tableGrid[5, r.Index].Value.ToString());
                this.Hide();
                fDevideRoom f = new fDevideRoom(maPDP, ngayDen, ngayDi);
                f.ShowDialog();
                this.Show();
            }
        }

        private void btn_link_vanchuyenhanhly_Click(object sender, EventArgs e)
        {

        }
    }
}

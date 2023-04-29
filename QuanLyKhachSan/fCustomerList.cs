using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fCustomerList : Form
    {
        private string maKH = "";
        private string tenKH = "";
        private string connetionString = DataConnection.sqlConn;
        private List<string[]> listCustomer = new List<string[]>();
        private int sizeListCustomer = 0;


        private void GetListCustomer(string queryString)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(queryString, cnn);
            SqlDataReader reader = cmd.ExecuteReader();

            //int i = 0;
            while (reader.Read())
            {
                string[] numb;
                numb = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                    numb[i] = reader[i].ToString();

                listCustomer.Add(numb);
                sizeListCustomer++;
            }
            cnn.Close();
        }


        public fCustomerList()
        {
            InitializeComponent();
            GetListCustomer("select * from dbo.KHACHHANG");
            add_data_datagridview();
        }

        void add_data_datagridview()
        {
            foreach (var item in listCustomer)
                tableGrid.Rows.Add(item[0], item[1], item[4], item[5], item[2], item[3]);
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCreateCustomer form = new fCreateCustomer();
            form.ShowDialog();
            this.Show();
        }

        private void onClick_DataGrid_Row(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < sizeListCustomer)
            {
                maKH = tableGrid[0, rowIndex: e.RowIndex].Value.ToString();
                tenKH = tableGrid[2, rowIndex: e.RowIndex].Value.ToString();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (maKH != "")
            {
                this.Hide();
                fCreateReservationTicket form = new fCreateReservationTicket(maKH, tenKH);
                form.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Chưa chọn khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string stringSearch = InputText.Text;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyKhachSan.fDevideRoom;

namespace QuanLyKhachSan
{
    public partial class fRevervationTicket : Form
    {
        private string maPDPfromList = "";
        private string maKHfromList = "";
        private string tenKH = "";
        private string sotien = "";
        public static string sqlConn = DataConnection.sqlConn;
        public static SqlConnection conn = DataConnection.conn;
        public fRevervationTicket()
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
        }

        public fRevervationTicket(string Message1, string Message2) : this()
        {
            maPDPfromList = Message1;
            maKHfromList = Message2;
            labelKh.Text = maKHfromList;
            labelphieu.Text = maPDPfromList;
            //this.lablePDP.Text = maPDPfromList;
        }
        public fRevervationTicket(string Message1, string Message2, bool View) : this()
        {
            labelKh.Text = Message2;
            labelphieu.Text = Message1; 
            maPDPfromList = Message1;
            maKHfromList = Message2;
            SqlCommand cmd = new SqlCommand("SELECT MaPhieuDat, HoTen, NgayDat,Sdt, NgayDen, NgayDi, TongTienPhong, NoiDung, TenDoan  FROM PHIEUDATPHONG JOIN KHACHHANG ON PHIEUDATPHONG.MaKH = KHACHHANG.MaKH JOIN PHIEUYEUCAU ON PHIEUDATPHONG.MaKH = PHIEUYEUCAU.MaKH LEFT JOIN THONGTINDOAN ON THONGTINDOAN.TruongDoan = KHACHHANG.MaKH WHERE MaPhieuDat = '"+ Message1 + "'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);
            foreach (DataRow row in currentRows)
            {
                textBoxBookDate.Text =  row["NgayDat"].ToString();
                textBoxCustomerName.Text = row["HoTen"].ToString();
                textBoxDateIn.Text = row["NgayDen"].ToString();
                textBoxDateOut.Text = row["NgayDi"].ToString();

                sotien = row["TongTienPhong"].ToString();

                var builder = new StringBuilder();
                int count = 0;
                int sizeSoTien = sotien.Length;
                for (var i = 0; i < sotien.Length; i++)
                {
                    builder.Append(sotien[sizeSoTien - 1 - i]);
                    if ((++count % 3) == 0)
                        builder.Append('.');
                }
                char[] array = (builder.ToString()).ToCharArray();
                Array.Reverse(array);

                textBoxValue.Text = new String(array);
                textBoxPhoneNum.Text = row["Sdt"].ToString();
                textBoxGroupName.Text = row["TenDoan"].ToString();
                textBoxSpecialRequirement.Text = row["NoiDung"].ToString();

                tenKH = row["HoTen"].ToString();

                /*foreach (DataColumn column in dt.Columns)
                {
                    list.Add((row[column].ToString()));
                    Console.Write("\t{0}", row[column]);
                }*/
            }
        }
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DatCoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDepositInvoice form = new fDepositInvoice(maPDPfromList, maKHfromList, textBoxCustomerName.Text, "Đặt cọc", "30000000");
            form.ShowDialog();
            this.Show();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDetailsRevervationTicket form = new fDetailsRevervationTicket(maPDPfromList);
            form.ShowDialog();
            this.Show();
        }

        private void fRevervationTicket_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

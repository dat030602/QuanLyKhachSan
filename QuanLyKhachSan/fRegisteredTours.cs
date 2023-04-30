using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
    public partial class fRegisteredTours : Form
    {
        string connectionString = DataConnection.sqlConn;
        SqlConnection sqlCon = null;
        public fRegisteredTours()
        {
            InitializeComponent();
        }
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTour form = new fTour();
            form.ShowDialog();
        }

        private void fRegisteredTours_Load(object sender, EventArgs e)
        {

        }

        private void button_complete_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            string maPhieuDat = textBoxMaKH.Text;
            string tour = "", dichVu = "", thoiGianBD = "",thoiGianKT = "", ycdb = "";
            string maHD = "";
            string maTour = "";
            string STT = "";
            int soLuong = 0;
            for (int i = 0; i< (dataGridView1.Rows.Count - 1); i++)
            {
                //get data from datagrid view
                tour = dataGridView1.Rows[i].Cells[0].Value.ToString();
                dichVu = dataGridView1.Rows[i].Cells[1].Value.ToString();
                soLuong = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                thoiGianBD = dataGridView1.Rows[i].Cells[3].Value.ToString();
                ycdb = dataGridView1.Rows[i].Cells[4].Value.ToString();
                //get maTour
                SqlCommand cmd2 = new SqlCommand("select MaTour from TOUR where TOUR.TenTour = N'" + tour + "'", sqlCon);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    maTour = reader2[0].ToString();
                }
                reader2.Close();
                //get thoi gian ket thuc
                SqlCommand cmd = new SqlCommand("select ThoiGian from LOTRINHTOUR where LOTRINHTOUR.MaTour = '" + maTour + "'"+" and LOTRINHTOUR.TenLoTrinh = N'Kết thúc'", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    thoiGianKT = reader[0].ToString();
                }
                reader.Close();
                //get MAHD
                SqlCommand cmd1 = new SqlCommand("select MaHD from HOADON where HOADON.MaPhieuDat = '"+maPhieuDat+"'", sqlCon);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while(reader1.Read())
                {
                    maHD = reader1[0].ToString();
                }
                reader1.Close();
                //get STT
                SqlCommand cmd3 = new SqlCommand("select count(*) from TTDANGKYTOUR where TTDANGKYTOUR.MaHD = '" + maHD + "'", sqlCon);
                SqlDataReader reader3 = cmd3.ExecuteReader();
                while (reader3.Read())
                {
                    STT = reader3[0].ToString();
                }
                reader3.Close();
                //insert data to database
                string queryStr = "INSERT INTO TTDANGKYTOUR(MaHD, Stt, MaTour, ThoiGianBatDau, ThoiGianKetThuc, YeuCau, SoLuong, TongTien, HinhThucDiChuyen, ThoiGianDangKy) VALUES('" + maHD + "'," + (Convert.ToInt32(STT)+1) + "," + "'" + maTour + "'," + "'" + DateTime.Parse(thoiGianBD) + "'," + "'" + DateTime.Parse(thoiGianKT) + "'," + "N'" + ycdb + "'," + "'" + soLuong + "'," + "100000," + "N'" + dichVu + "'," + "'"+DateTime.Today+"')";
                SqlCommand cmd4 = new SqlCommand("SET IDENTITY_INSERT TTDANGKYTOUR ON", sqlCon);
                SqlCommand cmd5 = new SqlCommand(queryStr, sqlCon);
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                SqlCommand cmd6 = new SqlCommand("SET IDENTITY_INSERT TTDANGKYTOUR OFF", sqlCon);
                cmd6.ExecuteNonQuery();
                MessageBox.Show("Thông tin đăng ký tour đã được ghi lại !! ");
            }
            sqlCon.Close();
        }
    }
}

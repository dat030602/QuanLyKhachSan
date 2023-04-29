using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fInvoice : Form
    {
        SqlConnection con = new SqlConnection(DataConnection.sqlConn);
        private string mapd;
        private string mahd;
        private string tonghd;
        public fInvoice()
        {
            InitializeComponent();
        }

        public fInvoice(string Message1, string Message2, string Message3, string Message4) : this()
        {
            textBox2.Text = Message1;
            mapd = Message1;
            textBox3.Text = Message2;
            textBox4.Text = Message3;
            textBox5.Text = Message4;
        }

        private void fInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select top 1 mahd from HOADON where maphieudat = '" + mapd + "' order by mahd desc", con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader[0].ToString();
                    mahd = reader[0].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ///////////////////
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd2 = new SqlCommand("XACNHAN_DVU_TOUR", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@mahd", mahd);
                SqlDataAdapter adt = new SqlDataAdapter(cmd2);
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ////////////////////
            try
            {
                con.Open();
                DataTable dt2 = new DataTable();
                SqlCommand cmd3 = new SqlCommand("select s.TenSanPham, tt.SoLuong, s.DonGia from TTSUDUNGSANPHAM tt join SANPHAM s on tt.MaSanPham=s.MaSanPham where tt.MaHD = '" + mahd + "'", con);
                SqlDataAdapter adt2 = new SqlDataAdapter(cmd3);
                adt2.Fill(dt2);
                dataGridView2.DataSource = dt2;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ///////////////////
            try
            {
                con.Open();
                DataTable dt3 = new DataTable();
                SqlCommand cmd4 = new SqlCommand("select p.SoPhong, l.DonGia from THONGTINDATPHONG tt join PHONG p on tt.SoPhong=p.SoPhong join LOAIPHONG l on p.MaLoaiPhong=l.MaLoaiPhong where tt.MaPhieuDat = '" + mapd + "'", con);
                SqlDataAdapter adt3 = new SqlDataAdapter(cmd4);
                adt3.Fill(dt3);
                dataGridView3.DataSource = dt3;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable dt4 = new DataTable();
                SqlCommand cmd4 = new SqlCommand("XACNHAN_KTPHONG", con);
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("@mapd", mapd);
                SqlDataAdapter adt4 = new SqlDataAdapter(cmd4);
                adt4.Fill(dt4);
                dataGridView4.DataSource = dt4;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ////
            try
            {
                con.Open();
                SqlCommand cmd5 = new SqlCommand("TONG_HOADON", con);
                cmd5.CommandType = CommandType.StoredProcedure;
                cmd5.Parameters.AddWithValue("@mahd", mahd);
                SqlDataReader reader5 = cmd5.ExecuteReader();
                if (reader5.Read())
                {
                    textBox6.Text = reader5[0].ToString();
                    tonghd = tonghd + reader5[0].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            fInfoRoom form = new fInfoRoom();
            form.ShowDialog();
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd6 = new SqlCommand("INSERT INTO LICHSUGIAODICH(MaHD, NoiDung, HinhThucThanhToan, DonGia) VALUES(@MaHD, N'Hóa đơn Check out', @HinhThucThanhToan, @DonGia)", con);
                cmd6.Parameters.AddWithValue("@MaHD", mahd);
                cmd6.Parameters.AddWithValue("@HinhThucThanhToan", comboBox1.Text.ToString());
                cmd6.Parameters.AddWithValue("@DonGia", tonghd);
                cmd6.ExecuteNonQuery();
                MessageBox.Show("Thanh toán thành công");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //////
            ///
            try
            {
                con.Open();
                SqlCommand cmd7 = new SqlCommand("UPDATE THONGTINDATPHONG SET TrangThai = N'Check out' WHERE MaPhieuDat = '" + mapd + "'", con);
                cmd7.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

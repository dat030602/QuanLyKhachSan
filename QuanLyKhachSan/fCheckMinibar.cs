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
using static QuanLyKhachSan.fDevideRoom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan
{
    public partial class fCheckMinibar : Form
    {
        public fCheckMinibar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PR8IEJS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
        private string madp;
        private string sophong;
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

        private void btn_link_kiemtraphong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCheckRoom form = new fCheckRoom();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("KT_TRANGTHAIPHONG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sophong", textBox2.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader[0].ToString() == "1")
                    {
                        textBox1.Text = "";
                        MessageBox.Show("Phòng chưa được đặt. Vui lòng nhập lại!");
                    }
                    else
                    {
                        textBox1.Text = reader[0].ToString();
                        madp = reader[0].ToString();
                        sophong = textBox2.Text.ToString();
                    }
                }
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
                SqlCommand cmd6 = new SqlCommand("INSERT INTO CTSUDUNGMINIBAR(MaPhieuDat, SoPhong, MaSanPham, SoLuong) VALUES(@MaPhieuDat, @SoPhong, @MaSP, @SoLuong)", con);
                cmd6.Parameters.AddWithValue("@MaPhieuDat", madp);
                cmd6.Parameters.AddWithValue("@SoPhong", sophong);
                cmd6.Parameters.AddWithValue("@MaSP", textBox3.Text.ToString());
                cmd6.Parameters.AddWithValue("@SoLuong", textBox4.Text.ToString());
                cmd6.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ////
            ///
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd3 = new SqlCommand("select MaSanPham, SoLuong from CTSUDUNGMINIBAR where MaPhieuDat = '" + madp + "' and SoPhong = " + sophong, con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd3);
                adt.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd6 = new SqlCommand("DELETE CTSUDUNGMINIBAR WHERE MaPhieuDat = @mapd and SoPhong = @sophong and MaSanPham = @masp", con);
                cmd6.Parameters.AddWithValue("@mapd", madp);
                cmd6.Parameters.AddWithValue("@sophong", sophong);
                cmd6.Parameters.AddWithValue("@masp", textBox3.Text.ToString());
                cmd6.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ////
            ///
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd3 = new SqlCommand("select MaSanPham, SoLuong from CTSUDUNGMINIBAR where MaPhieuDat = '" + madp + "' and SoPhong = " + sophong, con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd3);
                adt.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

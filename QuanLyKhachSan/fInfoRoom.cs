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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan
{
    public partial class fInfoRoom : Form
    {
        public fInfoRoom()
        {
            InitializeComponent();

        }
        //private string sqlConn = DataConnection.sqlConn;
        //private SqlConnection con = DataConnection.conn;
        SqlConnection con = new SqlConnection(DataConnection.sqlConn);
        private static ArrayList ListFirstname = new ArrayList();
        private static ArrayList ListLastname = new ArrayList();
        private static ArrayList ListTelephone = new ArrayList();
        private string mapd;
        private string makh;
        private string ngayden;
        private string ngaydi;
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
            fReservationTicketList form = new fReservationTicketList();
            form.ShowDialog();
            this.Close();
        }

        private void btn_link_khachhangchodat_Click(object sender, EventArgs e)
        {

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

        private void fInfoRoom_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("THONGTINPHONG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sophong", textBox1.Text);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dt.Columns.Remove("MaPhieuDat");
                dt.Columns.Remove("MaKH");
                dt.Columns.Remove("NgayDen");
                dt.Columns.Remove("HoTen");
                dt.Columns.Remove("NgayDi");
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader[0].ToString();
                    mapd = reader[0].ToString();
                    makh = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                    ngayden = reader[3].ToString();
                    textBox5.Text = reader[4].ToString();
                    ngaydi = reader[4].ToString();
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
            fInvoice form = new fInvoice(mapd, makh, ngayden, ngaydi);
            form.ShowDialog();
            this.Close();
        }
    }
}

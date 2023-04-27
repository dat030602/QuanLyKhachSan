using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fDetailsRevervationTicket : Form
    {
        public static string sqlConn = @"Data Source=LANTRINH_ASUS;Initial Catalog = QUANLYKHACHSAN; Persist Security Info=True;User ID = trinhasustuf; Password=1234";
        public static SqlConnection conn = null;
        private string maPDP = "";
        public fDetailsRevervationTicket()
        {
            InitializeComponent();
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();

            }
            this.tableGrid.DefaultCellStyle.Font = new Font("Tahoma", 15);

        }
        public fDetailsRevervationTicket(string Message) : this()
        {
            maPDP = Message;
            labelPhieuPDP.Text = maPDP;
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand("SELECT * from CTPHIEUDATPHONG WHERE MaPhieuDat = '" + maPDP + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
               
                tableGrid.DataSource = dt;
               
            }
        }
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDetailsRevervationTicket_Load(object sender, EventArgs e)
        {

        }
    }

}

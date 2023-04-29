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
using Microsoft.VisualBasic.ApplicationServices;

namespace QuanLyKhachSan
{
    public partial class fTour : Form
    {
        string connectionString = DataConnection.sqlConn;
        SqlConnection sqlCon = null;
        public fTour()
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
            fReservationTicketList form = new fReservationTicketList();
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            fScheduleTour form = new fScheduleTour();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fTour_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            DataTable dt = new DataTable();
            try
            {
                string queryStr = "SELECT Main.MaTour AS \"Mã tour\",T.TenTour AS \"Tên Tour \", T.DonGia AS \"Đơn Giá\", LEFT(Main.LOTRINH, Len(Main.LOTRINH)-1) AS \"Lộ trình\", LEFT(Main.THOIGIAN, Len(Main.THOIGIAN)-1) AS \"Thời gian\"" + "FROM (SELECT DISTINCT ST2.MaTour, (SELECT ST1.TenLoTrinh + ' - ' AS [text()] FROM dbo.LOTRINHTOUR ST1 WHERE ST1.MaTour = ST2.MaTour ORDER BY ST1.MaTour FOR XML PATH (''), TYPE).value('text()[1]','nvarchar(max)') [LOTRINH],(SELECT convert(varchar, ST1.ThoiGian) + ' - ' AS [text()] FROM dbo.LOTRINHTOUR ST1 WHERE ST1.MaTour = ST2.MaTour ORDER BY ST1.MaTour FOR XML PATH (''), TYPE).value('text()[1]','nvarchar(max)') [THOIGIAN] FROM dbo.LOTRINHTOUR ST2) [Main] JOIN dbo.TOUR T ON Main.MaTour = T.MaTour;";
                SqlCommand cmd = new SqlCommand(queryStr, sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }
    }
}

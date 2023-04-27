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
    public partial class fServiceProvided : Form
    {
        private string connetionString = "Data Source=DESKTOP-MMSPL40;Initial Catalog = QUANLYKHACHSAN; User ID = root; Password=root";
        
        private List<string[]> listService= new List<string[]>();
        private int sizeListSerive = 0;

        private List<string[]> listServiceSelect = new List<string[]>();

        public fServiceProvided()
        {
            InitializeComponent();
            GetListService("select DV.MADV, DV.TENDV, DVCC.MALOAIPHONG from dbo.DICHVU DV JOIN DBO.DVCUNGCAP DVCC ON DV.MADV=DVCC.MADV");
            add_data_datagridview();
        }

        private void GetListService(string queryString)
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

                listService.Add(numb);
                sizeListSerive++;
            }
            cnn.Close();
        }

        void add_data_datagridview()
        {
            foreach (var item in listService)
                tableGrid.Rows.Add(item[0], item[1], item[2]);
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

        private void tableGrid_Rows_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < sizeListSerive)
            {
                //tableGrid.Rows[e.RowIndex].Selected =true;
                //tableGrid[0, rowIndex: e.RowIndex].Selected =true;
                //tenKH = tableGrid[2, rowIndex: e.RowIndex].Value.ToString();
            }
            MessageBox.Show((tableGrid.Rows[0].Selected).ToString() + (tableGrid.Rows[1].Selected).ToString()+
                (tableGrid.Rows[2].Selected).ToString());
        }
    }
}

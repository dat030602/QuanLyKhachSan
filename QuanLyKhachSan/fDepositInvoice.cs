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
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyKhachSan
{
    public partial class fDepositInvoice : Form
    {
        private string connetionString = "Data Source=DESKTOP-MMSPL40;Initial Catalog = QUANLYKHACHSAN; User ID = root; Password=root";
        private string maKH = "";
        private string maPD = "";
        private string maHD = "";
        private string tenKH = "";
        private string noidung = "";
        private string sotien = "";
        public fDepositInvoice()
        {
            InitializeComponent();
        }

        public fDepositInvoice(string Message1, string Message2, string Message3,
            string Message4, string Message5) : this()
        {
            maPD = Message1;
            maKH = Message2;
            tenKH = Message3;
            noidung = Message4;
            sotien = Message5;
            labelKH.Text = maKH;
            GetMaHoaDon("select MAHD from dbo.HOADON");
            label_hoadon.Text = maHD;

            ExecuteSql("INSERT INTO DBO.HOADON VALUES('" + maHD + "','" + maPD + "'," + sotien + ")");

            textNoiDung.Text = noidung;
            textTenKhachHang.Text = tenKH;

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

            textTongTien.Text = new String(array);
        }

        private void GetMaHoaDon(string queryString)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(queryString, cnn);
            List<int> list = new List<int>();

            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                var temp = reader["MAHD"];

                list.Add(convertStringToInt((temp.ToString()).Substring(2, 4)));
            }
            i = list.Max() + 1;
            if (i < 10) maHD = "HD000" + i;
            else if (i < 100) maHD = "HD00" + i;
            else if (i < 1000) maHD = "HD0" + i;
            else if (i < 10000) maHD = "HD" + i;
            cnn.Close();
        }

        private void ExecuteSql(string queryString)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(queryString, cnn);
            int result = cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private int convertCharToInt(char a)
        {
            switch (a)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                default:
                    return -1;
            }

        }

        private int convertStringToInt(string inputString)
        {
            int sum = 0;
            int size = inputString.Length;
            int coefficient = System.Convert.ToInt32(Math.Pow(10, size - 1));
            for (int i = 0; i < size; i++)
            {
                sum += convertCharToInt(inputString[i]) * coefficient;
                coefficient /= 10;
            }
            return sum;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ExecuteSql("DELETE DBO.HOADON WHERE MAHD='" + maHD + "'");
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (textHinhThucThanhToan.Text != "")
            {
                if (MessageBox.Show("Bạn chắc chưa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ExecuteSql("INSERT INTO DBO.LICHSUGIAODICH(MAHD,NOIDUNG, HINHTHUCTHANHTOAN, DONGIA) VALUES('" + maHD +
                        "', N'" + noidung + "', N'" + textHinhThucThanhToan.Text + "', " + sotien + ")");

                    this.Close();
                }
            }
        }
    }
}

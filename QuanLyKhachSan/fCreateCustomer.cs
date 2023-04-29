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
    public partial class fCreateCustomer : Form
    {
        private string connetionString = DataConnection.sqlConn;

        private string maKH = "";
        public fCreateCustomer()
        {
            InitializeComponent();
            GetMaKH("select MAKH from dbo.KHACHHANG");
            label_makh.Text = maKH;
        }

        private void GetMaKH(string queryString)
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
                var temp = reader["MAKH"];

                list.Add(convertStringToInt((temp.ToString()).Substring(2, 4)));
            }
            i = list.Max() + 1;
            if (i < 10) maKH = "KH000" + i;
            else if (i < 100) maKH = "KH00" + i;
            else if (i < 1000) maKH = "KH0" + i;
            else if (i < 10000) maKH = "KH" + i;
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
            if (size == 1)
                sum = convertCharToInt(inputString[0]);
            else if (size == 2)
                sum = convertCharToInt(inputString[0]) * 10 + convertCharToInt(inputString[1]);
            else if (size == 3)
                sum = convertCharToInt(inputString[0]) * 100 + convertCharToInt(inputString[1]) * 10
                    + convertCharToInt(inputString[2]);
            else if (size == 4)
                sum = convertCharToInt(inputString[0]) * 1000 + convertCharToInt(inputString[1]) * 100 +
                    convertCharToInt(inputString[2]) * 10 + convertCharToInt(inputString[3]);
            return sum;
        }
        private string formatDateYYYYMMDD(string inputString)
        {
            string tmp = inputString.Substring(6, 4) + "/" +
                                inputString.Substring(3, 2) + "/" + inputString.Substring(0, 2);
            return tmp;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự hoàn thành tạo phiếu đặt phòng?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (textTenKhachHang.Text != "" && textDienThoai.Text != "" && textCMND.Text != "" &&
                    textGioiTinh.Text != "" && textNgaySinh.Text != "" && textSofax.Text != "" &&
                    text_diachi.Text != "")
                {
                    ExecuteSql("INSERT INTO dbo.KHACHHANG VALUES ('" + maKH + "','" +
                        textCMND.Text + "','" + textDienThoai.Text + "','" + textSofax.Text
                        + "',N'" + textTenKhachHang.Text + "',N'" + text_diachi.Text + "')");
                    this.Close();
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

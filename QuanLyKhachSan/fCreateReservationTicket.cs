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
using System.Linq.Expressions;

namespace QuanLyKhachSan
{
    public partial class fCreateReservationTicket : Form
    {
        private bool isCreateDetail = false;
        private bool isCreateRequired = false;

        private string connetionString = DataConnection.sqlConn;

        private string maKHfromCustomerList = "";
        private string tenKHfromCustomerList = "";
        private string maphieudatphong = "";
        public fCreateReservationTicket()
        {
            InitializeComponent();
        }
        public fCreateReservationTicket(string Message1, string Message2) : this()
        {
            maKHfromCustomerList = Message1;
            tenKHfromCustomerList = Message2;
            text_maKhachHang.Text = maKHfromCustomerList;
            GetMaPhieuDat("select MaPhieuDat from dbo.PHIEUDATPHONG");
            maphieu.Text = maphieudatphong;
            text_maKhachHang.Text = maKHfromCustomerList;
            textTenKH.Text = tenKHfromCustomerList;
            ExecuteSql("INSERT INTO DBO.PHIEUDATPHONG(MaPhieuDat, ngaydat) VALUES('" + maphieudatphong + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
        }

        private void GetMaPhieuDat(string queryString)
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
                var temp = reader["MaPhieuDat"];

                list.Add(convertStringToInt((temp.ToString()).Substring(2, 4)));
            }
            i = list.Max() + 1;
            if (i < 10) maphieudatphong = "PD000" + i;
            else if (i < 100) maphieudatphong = "PD00" + i;
            else if (i < 1000) maphieudatphong = "PD0" + i;
            else if (i < 10000) maphieudatphong = "PD" + i;
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
                    break;
                case '1':
                    return 1;
                    break;
                case '2':
                    return 2;
                    break;
                case '3':
                    return 3;
                    break;
                case '4':
                    return 4;
                    break;
                case '5':
                    return 5;
                    break;
                case '6':
                    return 6;
                    break;
                case '7':
                    return 7;
                    break;
                case '8':
                    return 8;
                    break;
                case '9':
                    return 9;
                    break;
                default:
                    return -1;
                    break;
            }

        }
        private int convertStringToInt(string inputString)
        {
            int sum = convertCharToInt(inputString[0]) * 1000 + convertCharToInt(inputString[1]) * 100 +
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
            ExecuteSql("DELETE DBO.PHIEUDATPHONG WHERE MaPhieuDat='" + maphieudatphong + "'");
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (isCreateDetail == false)
                MessageBox.Show("Bạn quên nhập chi tiết đặt phòng kìa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (isCreateRequired == false)
            {
                if (MessageBox.Show("Khách còn yêu cầu nào không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                {
                    if (MessageBox.Show("Bạn có thật sự hoàn thành tạo phiếu đặt phòng?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        string stringInput2 = textNgayDen.Text;
                        stringInput2 = formatDateYYYYMMDD(stringInput2);

                        string stringInput3 = textNgaydi.Text;
                        stringInput3 = formatDateYYYYMMDD(stringInput3);

                        ExecuteSql("UPDATE dbo.PHIEUDATPHONG SET makh='" + maKHfromCustomerList +
                            "' WHERE MaPhieuDat = '" + maphieudatphong + "'");

                        ExecuteSql("UPDATE dbo.PHIEUDATPHONG SET NgayDen='" + stringInput2 +
                            "' WHERE MaPhieuDat = '" + maphieudatphong + "'");

                        ExecuteSql("UPDATE dbo.PHIEUDATPHONG SET NgayDi='" + stringInput3 +
                            "' WHERE MaPhieuDat = '" + maphieudatphong + "'");

                        string stringInput5 = textTenDoan.Text;
                        if (stringInput5 != "")
                        {
                            string stringInput6 = textSoLuong.Text;
                            if (stringInput6 != "")
                            {
                                ExecuteSql("INSERT INTO dbo.THONGTINDOAN VALUES ('" + maKHfromCustomerList + "',N'"
                                    + stringInput5 + "'," + stringInput6 + ")");
                            }
                            else
                                MessageBox.Show("Chưa nhập số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        this.Close();
                    }
                }
            }
            else if (isCreateRequired == true)
            {
                if (MessageBox.Show("Bạn có thật sự hoàn thành tạo phiếu đặt phòng?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    string stringInput2 = textNgayDen.Text;
                    stringInput2 = formatDateYYYYMMDD(stringInput2);

                    string stringInput3 = textNgaydi.Text;
                    stringInput3 = formatDateYYYYMMDD(stringInput3);

                    ExecuteSql("UPDATE dbo.PHIEUDATPHONG SET makh='" + maKHfromCustomerList +
                        "' WHERE MaPhieuDat = '" + maphieudatphong + "'");

                    ExecuteSql("UPDATE dbo.PHIEUDATPHONG SET NgayDen='" + stringInput2 +
                        "' WHERE MaPhieuDat = '" + maphieudatphong + "'");

                    ExecuteSql("UPDATE dbo.PHIEUDATPHONG SET NgayDi='" + stringInput3 +
                        "' WHERE MaPhieuDat = '" + maphieudatphong + "'");

                    string stringInput5 = textTenDoan.Text;
                    if (stringInput5 != "")
                    {
                        string stringInput6 = textSoLuong.Text;
                        if (stringInput6 != "")
                        {
                            ExecuteSql("INSERT INTO dbo.THONGTINDOAN VALUES ('" + maKHfromCustomerList + "',N'"
                                + stringInput5 + "'," + stringInput6 + ")");
                        }
                        else
                            MessageBox.Show("Chưa nhập số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
        }

        private void SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCreateDetailsReservationTicket form = new fCreateDetailsReservationTicket(maphieudatphong);
            form.ShowDialog();
            isCreateDetail = form.IsCreateDetail;
            this.Show();
        }

        private void btn_YeuCauDacBiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSpecialRequirement form = new fSpecialRequirement(maphieudatphong, maKHfromCustomerList, tenKHfromCustomerList);
            form.ShowDialog();
            isCreateRequired = form.IsCreateRequired;
            this.Show();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ExecuteSql("DELETE DBO.PHIEUDATPHONG WHERE MaPhieuDat='" + maphieudatphong + "'");
            this.Close();
        }
    }
}
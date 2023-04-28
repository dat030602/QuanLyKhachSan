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
    public partial class fCreateDetailsReservationTicket : Form
    {
        private string connetionString = "Data Source=DESKTOP-MMSPL40;Initial Catalog = QUANLYKHACHSAN; User ID = root; Password=root";

        private bool isCreateDetail = false;
        public bool IsCreateDetail
        {
            get { return isCreateDetail; }
            set { isCreateDetail = value; }
        }

        private string maphieudatphong = "";

        private string[,] arrayAdd = new string[3, 2] { { "Phòng đơn", "0" }, { "Phòng đôi", "0" }, { "Phòng VIP", "0" } };

        public fCreateDetailsReservationTicket()
        {
            InitializeComponent();

            tableGrid.Rows.Add(arrayAdd[0, 0], arrayAdd[0, 1]);
            tableGrid.Rows.Add(arrayAdd[1, 0], arrayAdd[1, 1]);
            tableGrid.Rows.Add(arrayAdd[2, 0], arrayAdd[2, 1]);

        }
        public fCreateDetailsReservationTicket(string Message) : this()
        {
            maphieudatphong = Message;
            maphieu.Text = maphieudatphong;
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

        private void SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textLoaiPhong.Text != "")
            {
                if (textSoLuong.Text != "")
                    for (int i = 0; i < 3; i++)
                    {
                        if (textLoaiPhong.Text == arrayAdd[i, 0])
                        {
                            arrayAdd[i, 1] = textSoLuong.Text;
                            tableGrid.Rows[i].Cells[1].Value = arrayAdd[i, 1];
                            break;
                        }
                    }
                else
                    MessageBox.Show("Chưa chọn số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Chưa chọn loại phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn với lựa chọn của mình chưa?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (!(arrayAdd[0, 1] == "0" && arrayAdd[1, 1] == "0" && arrayAdd[2, 1] == "0"))
                {
                    isCreateDetail = true;
                    int soluong1 = convertStringToInt(arrayAdd[0, 1]);
                    int soluong2 = convertStringToInt(arrayAdd[1, 1]);
                    int soluong3 = convertStringToInt(arrayAdd[2, 1]);

                    if (soluong1 > 0)
                        ExecuteSql("INSERT INTO dbo.CTPHIEUDATPHONG VALUES ('" + maphieudatphong +
                            "', 'LOAI01', " + soluong1 + ")");
                    if (soluong2 > 0)
                        ExecuteSql("INSERT INTO dbo.CTPHIEUDATPHONG VALUES ('" + maphieudatphong +
                            "', 'LOAI02', " + soluong1 + ")");
                    if (soluong3 > 0)
                        ExecuteSql("INSERT INTO dbo.CTPHIEUDATPHONG VALUES ('" + maphieudatphong +
                            "', 'LOAI03', " + soluong1 + ")");
                    this.Close();
                }
                else
                    MessageBox.Show("Chưa chọn phòng nào cả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

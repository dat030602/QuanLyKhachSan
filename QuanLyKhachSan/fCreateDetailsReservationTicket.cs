using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fCreateDetailsReservationTicket : Form
    {
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
            for (int i = 0; i < 3; i++)
            {
                if (textLoaiPhong.Text == arrayAdd[i, 0])
                {
                    arrayAdd[i, 1] = textSoLuong.Text;
                    tableGrid.Rows[i].Cells[1].Value = arrayAdd[i, 1];
                    break;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fRevervationTicket : Form
    {
        private string maPDPfromList = "";
        private string maKHfromList = "";
        public fRevervationTicket()
        {
            InitializeComponent();
        }

        public fRevervationTicket(string Message1, string Message2) : this()
        {
            maPDPfromList = Message1;
            maKHfromList = Message2;
            labelKh.Text = maKHfromList;
            labelphieu.Text = maPDPfromList;
            //this.lablePDP.Text = maPDPfromList;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DatCoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDepositInvoice form = new fDepositInvoice(maKHfromList);
            form.ShowDialog();
            this.Show();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDetailsRevervationTicket form = new fDetailsRevervationTicket(maPDPfromList);
            form.ShowDialog();
            this.Show();
        }
    }
}

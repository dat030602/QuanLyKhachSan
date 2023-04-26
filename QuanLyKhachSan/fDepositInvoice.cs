using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fDepositInvoice : Form
    {
        private string maKH = "";
        public fDepositInvoice()
        {
            InitializeComponent();
        }

        public fDepositInvoice(string Message) : this()
        {
            maKH = Message;
            labelKH.Text = maKH;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class fDetailsRevervationTicket : Form
    {
        private string maPDP = "";
        public fDetailsRevervationTicket()
        {
            InitializeComponent();
        }
        public fDetailsRevervationTicket(string Message) : this()
        {
            maPDP = Message;
            labelPhieuPDP.Text = maPDP;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

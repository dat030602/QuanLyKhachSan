using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace QuanLyKhachSan
{
    
    public partial class fReservationTickerList : Form
    {
        fRevervationTicker f = new fRevervationTicker();
        fDevideRoom f2 = new fDevideRoom();
        public fReservationTickerList()
        {
            InitializeComponent();
            
            f.Hide();
            f2.Hide();

        }

        private void btnDevideRoom_Click(object sender, EventArgs e)
        {
           
            f2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void fReservationTickerList_Load(object sender, EventArgs e)
        {

        }
        private void btnAddReservationTicker_Click(object sender, EventArgs e)
        {
        
            f.Show();
            this.Hide();
        }
    }
}

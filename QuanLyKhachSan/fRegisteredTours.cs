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
    public partial class fRegisteredTours : Form
    {

        public fRegisteredTours()
        {
            InitializeComponent();
        }
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTour form = new fTour();
            form.ShowDialog();
        }

        private void fRegisteredTours_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class fScheduleTour : Form
    {
        public fScheduleTour()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void button_complete_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRegisteredTours form = new fRegisteredTours();
            form.ShowDialog();
        }

        private void comboBoxTour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

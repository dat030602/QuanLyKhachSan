﻿using System;
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
    public partial class fRevervationTicker : Form
    {
        public fRevervationTicker()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fReservationTickerList f = new fReservationTickerList();
            f.Show();
            this.Hide();
        }
    }
}

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
    public partial class fSpecialRequirement : Form
    {
        private string maphieudatphong = "";
        public fSpecialRequirement()
        {
            InitializeComponent();
        }
        public fSpecialRequirement(string Message) : this()
        {
            maphieudatphong = Message;
            maphieu.Text = maphieudatphong;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

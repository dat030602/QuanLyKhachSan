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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan
{
    public partial class fScheduleTour : Form
    {
        string connectionString = @"Data Source=LAPTOP-FLMRB1T8;Initial Catalog = QUANLYKHACHSAN; Persist Security Info=True;User ID = po; Password=1234";
        SqlConnection sqlCon = null;
        public fScheduleTour()
        {
            InitializeComponent();

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            fTour form = new fTour();
            form.ShowDialog();
        }

        private void button_complete_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRegisteredTours form = new fRegisteredTours();
            form.textBoxMaKH.Text = this.textBoxMaKH.Text;
            int n = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.Count != n + 1)
                {
                    form.dataGridView1.Rows.Add();
                    form.dataGridView1.Rows[n].Cells[0].Value = row.Cells[0].Value.ToString();
                    form.dataGridView1.Rows[n].Cells[1].Value = row.Cells[1].Value.ToString();
                    form.dataGridView1.Rows[n].Cells[2].Value = row.Cells[2].Value.ToString();
                    form.dataGridView1.Rows[n].Cells[3].Value = row.Cells[3].Value.ToString();
                    form.dataGridView1.Rows[n].Cells[4].Value = row.Cells[4].Value.ToString();
                    n += 1;
                }
            }
            form.ShowDialog();
        }

        private void comboBoxTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThoiGianKhoiHanh();
        }
        public void loadDataToComboboxTour()
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            string sqlStr = "select TenTour from TOUR";
            SqlCommand cmd = new SqlCommand(sqlStr, sqlCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxTour.Items.Add(reader.GetString(0));
            }
            sqlCon.Close();
        }
        public void addDataToComboBoxDichVu()
        {
            comboBoxDichVu.Items.Add("Đưa đón");
            comboBoxDichVu.Items.Add("Tự túc");
        }
        private void loadThoiGianKhoiHanh()
        {
            sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            string sqlStr = "select ThoiGian from LOTRINHTOUR join TOUR on LOTRINHTOUR.MaTour = TOUR.MaTour where STT = 1 and TenTour = @tenTour";
            SqlCommand cmd = new SqlCommand(sqlStr, sqlCon);
            cmd.Parameters.AddWithValue("@tenTour", comboBoxTour.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBoxThoiGian.Text = reader.GetValue(0).ToString();
            }
            sqlCon.Close();
        }
        private void fScheduleTour_Load(object sender, EventArgs e)
        {
            addDataToComboBoxDichVu();
            loadDataToComboboxTour();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTour_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (comboBoxTour.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tour !!!");
            }
            else if (comboBoxDichVu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hình thức di chuyển !!!");
            }
            else if (textBoxMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng !!!");
            }
            else if (textBoxSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng !!!");
            }
            else
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                dataGridView1.Rows.Add(comboBoxTour.Text, comboBoxDichVu.Text, textBoxSoLuong.Text, textBoxThoiGian.Text, textBoxYcdb.Text);
                sqlCon.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}

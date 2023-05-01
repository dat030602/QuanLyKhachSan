using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace QuanLyKhachSan

{


    public partial class fDevideRoom : Form
    {
        internal class Cons
        {
            public static int DayOfWeek = 7;
            public static int DayOfColumn = 6;
            public static int dateButtonWidth = 75;
            public static int dateButtonHeight = 40;
            public static int margin = 6;
        }
        private List<List<Button>> matrix;
        //private List<Button> buttonList;
        //private Button ylbutton = null;
        private List<string> listYellow = null;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        string connString = DataConnection.sqlConn;
        SqlConnection sqlConnection = DataConnection.conn;
        //private ArrayList label = new ArrayList(30);

        List<Button> disableButtonList = new List<Button>();
        private string maPDP = "";
        private string ngayDen = "";
        private string ngayDi = "";
        private List<string> listDivided;
        Int32 SoLuong = -1;
        public fDevideRoom()
        {
            InitializeComponent();
            LoadMatrix();

            //handleButton();


        }
        public fDevideRoom(string maPDP, string ngayDen, string ngayDi) : this()
        {
            lblMaPhieuDat.Text = "Mã PĐ: " + maPDP;
            this.maPDP = maPDP;
            this.ngayDen = ngayDen;
            this.ngayDi = ngayDi;
            //MessageBox.Show(ngayDi);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void ButtonDynamic_Click(object sender, EventArgs e)
        {

        }

        private void fDevideRoom_Load(object sender, EventArgs e)
        {
            listYellow = new List<string>();
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connString);
            }
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();

            }
            DataTable dt = new DataTable();
            string text = "SELECT TenLoaiPhong FROM PHIEUDATPHONG PD JOIN CTPHIEUDATPHONG CT ON CT.MaPhieuDat = PD.MaPhieuDat JOIN LOAIPHONG LP ON CT.MaLoaiPhong = LP.MaLoaiPhong WHERE PD.MaPhieuDat = '" + maPDP + "'";
            SqlCommand cmd = new SqlCommand("SELECT TenLoaiPhong FROM PHIEUDATPHONG PD JOIN CTPHIEUDATPHONG CT ON CT.MaPhieuDat = PD.MaPhieuDat JOIN LOAIPHONG LP ON CT.MaLoaiPhong = LP.MaLoaiPhong WHERE PD.MaPhieuDat = '" + maPDP + "'", sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            cbbLoaiPhong.DisplayMember = dt.Columns[0].ColumnName;
            cbbLoaiPhong.ValueMember = dt.Columns[0].ColumnName;
            cbbLoaiPhong.DataSource = dt;
            cbbLoaiPhong.SelectedIndex = 0;

            //tableLayoutPanel1.ColumnCount = 
            //MessageBox.Show(text);
            if (Matrix.Count == 9)
            {
                foreach (List<Button> temp in Matrix)
                {

                    foreach (Button button in temp)
                    {
                        button.Click += (s, e) =>
                        {

                            /*btnDevideRoom.Click += (s, e) =>
                            {
                                button.BackColor = Color.Red;
                            };*/
                            if (button.BackColor == Color.Red)
                            {
                                btnXacNhanPhanPhong.Enabled = false;
                                btnXacNhanPhanPhong.BackColor = Color.Gray;
                            }
                            else if (button.BackColor == Color.Green)
                            {
                                if (SoLuong > 0)
                                {
                                    btnXacNhanPhanPhong.Enabled = true;
                                    btnXacNhanPhanPhong.BackColor = Color.FromArgb(255, 192, 192);
                                    button.BackColor = Color.Yellow;
                                    listYellow.Add(button.Text);
                                    for (int k = 0; k < listYellow.Count; k++)
                                    {
                                        Console.Write(listYellow[k]);
                                    }
                                    SoLuong = SoLuong - 1;
                                    lblSoLuongConLai.Text = "Số lượng còn lại: " + SoLuong.ToString();
                                }

                            }
                            else if (button.BackColor == Color.Yellow)
                            {
                                btnXacNhanPhanPhong.Enabled = true;
                                btnXacNhanPhanPhong.BackColor = Color.FromArgb(255, 192, 192);
                                button.BackColor = Color.Green;
                                listYellow.Remove(button.Text);
                                for (int k = 0; k < listYellow.Count; k++)
                                {
                                    Console.Write(listYellow[k]);
                                }
                                SoLuong = SoLuong + 1;
                                lblSoLuongConLai.Text = "Số lượng còn lại: " + SoLuong.ToString();
                            }
                        };


                    }

                }

            }
            btnXacNhanPhanPhong.Click += (s, e) => {


                for (int m = 0; m < listDivided.Count; m++)
                {
                    if (!listYellow.Any(o => o == listDivided[m]))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM THONGTINVANCHUYENHANHLY WHERE MaPhieuDat = '" + maPDP + "' AND SoPhong = '" + listDivided[m] + "'", sqlConnection);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("DELETE FROM CTHOSOKIEMTRAPHONG WHERE MaPhieuDat = '" + maPDP + "' AND SoPhong = '" + listDivided[m] + "'", sqlConnection);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("DELETE FROM CTSUDUNGMINIBAR WHERE MaPhieuDat = '" + maPDP + "' AND SoPhong = '" + listDivided[m] + "'", sqlConnection);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("DELETE FROM THONGTINDATPHONG WHERE MaPhieuDat = '" + maPDP + "' AND SoPhong = '" + listDivided[m] + "'", sqlConnection);
                        cmd.ExecuteNonQuery();
                    }
                }
                Console.Write("Ok");
                for (int m = 0; m < listYellow.Count; m++)
                {
                    if (!listDivided.Any(o => o == listYellow[m]))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO THONGTINDATPHONG VALUES ('" + maPDP + "', '" + listYellow[m] + "',NULL)", sqlConnection);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Phân phòng thành công!", "Thông báo");
            };

        }

        void LoadMatrix()
        {

            Matrix = new List<List<Button>>();
            //List<Label> lbl = new List<Label>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            int y = 13;
            for (int i = 0; i < 9; i++)
            {
                Matrix.Add(new List<Button>());
                Label lb = new Label() { Location = new Point(0, y) };
                lb.Font = new Font("Arial", 13, FontStyle.Bold);
                y = y + 44;
                lb.Text = "Tầng " + (i + 1).ToString();
                panel4.Controls.Add(lb);
                for (int j = 0; j < 8; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Text = ((i + 1) * 100 + j + 1).ToString();
                    btn.BackColor = Color.Green;
                    //btn.Click += btn_Click;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    panelDanhSachPhong.Controls.Add(btn);
                    oldBtn = btn;
                    Matrix[i].Add(btn);
                    //buttonList.Add(btn);
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, oldBtn.Location.Y + 4 + Cons.dateButtonHeight) };
            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackToReversationList_Click(object sender, EventArgs e)
        {
            fReservationTicketList f = new fReservationTicketList();
            f.Show();
            this.Hide();
        }

        

        private void cbbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connString);
            }
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();

            }
            if (cbbLoaiPhong.SelectedIndex != -1)
            {
                for (int k = 0; k < listYellow.Count; k++)
                {
                    listYellow.Remove(listYellow[k]);
                }
                foreach (List<Button> tempB in Matrix)
                {

                    foreach (Button button in tempB)
                    {
                        if (button.BackColor == Color.Yellow)
                        {

                            listYellow.Remove(button.Text);

                        }
                    }

                }
                string temp = cbbLoaiPhong.SelectedValue.ToString();

                Console.WriteLine(temp);
                SqlCommand cmd = new SqlCommand("SELECT SoPhong from PHONG JOIN LOAIPHONG on PHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong where TenLoaiPhong = N'" + temp + "' and SoPhong not in (SELECT SoPhong FROM THONGTINDATPHONG JOIN PHIEUDATPHONG ON THONGTINDATPHONG.MaPhieuDat =  PHIEUDATPHONG.MaPhieuDat and ((PHIEUDATPHONG.NgayDen <='" + ngayDen + "' AND PHIEUDATPHONG.NgayDi >= '" + ngayDen + "') OR (PHIEUDATPHONG.NgayDen <='" + ngayDi + "' AND PHIEUDATPHONG.NgayDi >= '" + ngayDi + "')))", sqlConnection);
                DataTable dt = new DataTable();
                List<string> list = new List<string>();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                cmd = new SqlCommand("SELECT THONGTINDATPHONG.SoPhong FROM THONGTINDATPHONG JOIN PHONG ON PHONG.SoPhong = THONGTINDATPHONG.SoPhong JOIN LOAIPHONG ON LOAIPHONG.MaLoaiPhong = PHONG.MaLoaiPhong WHERE MaPhieuDat = '" + maPDP + "' AND TenLoaiPhong = N'" + temp + "'", sqlConnection);
                DataTable dt2 = new DataTable();
                listDivided = new List<string>();
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                adapter2.Fill(dt2);
                DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);
                DataRow[] currentRows2 = dt2.Select(null, null, DataViewRowState.CurrentRows);
                cmd = new SqlCommand("SELECT SoLuong FROM CTPHIEUDATPHONG JOIN LOAIPHONG ON CTPHIEUDATPHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong WHERE MaPhieuDat = '" + maPDP + "' AND TenLoaiPhong = N'" + temp + "'", sqlConnection);
                SoLuong = (Int32)cmd.ExecuteScalar();
                
                Console.WriteLine("So luong: " + SoLuong.ToString());
                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        list.Add((row[column].ToString()));
                        Console.Write("\t{0}", row[column]);
                    }
                }
                foreach (DataRow row in currentRows2)
                {
                    foreach (DataColumn column in dt2.Columns)
                    {
                        listDivided.Add((row[column].ToString()));
                        listYellow.Add((row[column].ToString()));
                        Console.Write("\t{0}", row[column]);
                        SoLuong = SoLuong - 1;
                    }

                }
                lblSoLuongConLai.Text = "Số lượng còn lại: " + SoLuong.ToString();
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (!list.Any(o => o == Matrix[i][j].Text))
                        {
                            Matrix[i][j].BackColor = Color.Red;
                        }
                        else
                        {
                            Matrix[i][j].BackColor = Color.Green;

                        }
                        if (listDivided.Any(o => o == Matrix[i][j].Text))
                        {
                            Matrix[i][j].BackColor = Color.Yellow;
                        }
                    }
                }


            }


        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMainWindow form = new fMainWindow();
            form.ShowDialog();
            this.Close();
        }
        private void btnDevideRoom_Click(object sender, EventArgs e)
        {

        }
    }
}


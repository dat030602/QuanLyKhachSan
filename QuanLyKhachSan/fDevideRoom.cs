using System;
using System.Collections;
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
    public partial class fDevideRoom : Form
    {
        //private ArrayList label = new ArrayList(30);
        List<Button> buttonList = new List<Button>();
        List<Button> disableButtonList = new List<Button>();
        public fDevideRoom()
        {
            InitializeComponent();
         
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void ButtonDynamic_Click(object sender, EventArgs e)
        {
            
        }

        private void fDevideRoom_Load(object sender, EventArgs e)
        {

            /*List<Button> buttonList = new List<Button>();
            for (int i = 0; i < 10; i++)
            {
                Button newButton = new Button();
                newButton.Text = "Button " + i;
                newButton.Name = "button" + i;
                newButton.Location = new Point(120*i, 10);
                buttonList.Add(newButton);
               

            }
            foreach (Button button in buttonList)
            {
                panel16.Controls.Add(button);
            }*/
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    if (j == 0)
                    {
                        Label newLable = new Label();
                        newLable.Text = "Tầng " + (i + 1);
                        newLable.Name = "lblFloor" + (i + 1);
                        tableLayoutPanel1.Controls.Add(newLable, j, i);
                    }
                    else
                    {
                        Button newButton = new Button();
                        newButton.Text = ((i+1) * 100 + j).ToString();
                        newButton.Name = "button" + i + "_" + j;
                        newButton.BackColor = Color.Green;
                        buttonList.Add(newButton);
                        tableLayoutPanel1.Controls.Add(newButton, j, i);
                    }
       
                }
            }
            foreach (Button button in buttonList)
            {
                button.Click += (s, e) => {foreach (Button button2 in buttonList)
                    {
                        if (button2 != button && button2.BackColor != Color.Red)
                        {
                            button2.BackColor = Color.Green;
                        }
                    }
                    
                    btnDevideRoom.Click += (s, e) => {button.BackColor = Color.Red;
                    };
                    if (button.BackColor == Color.Red)
                    {
                        btnDevideRoom.Enabled = false;
                        btnDevideRoom.BackColor = Color.Gray;
                    }
                    else
                    {
                        btnDevideRoom.Enabled = true;
                        btnDevideRoom.BackColor = Color.FromArgb(255, 192, 192);
                        button.BackColor = Color.Yellow;
                    }
                };
               
            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnBackToReversationList_Click(object sender, EventArgs e)
        {
            fReservationTickerList f = new fReservationTickerList();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMainWindow form = new fMainWindow();
            form.ShowDialog();
            this.Close();
        }
    }
}

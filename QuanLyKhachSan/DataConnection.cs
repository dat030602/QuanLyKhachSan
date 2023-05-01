using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyKhachSan
{
    internal class DataConnection
    {
        //Ngoc
        public static string sqlConn = @"Data Source=DESKTOP-PR8IEJS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";

        // Oanh
        //public static string sqlConn = @"Data Source=LAPTOP-FLMRB1T8;Initial Catalog = QUANLYKHACHSAN; Persist Security Info=True;User ID = po; Password=1234";

        // Dat
        //public static string sqlConn = "Data Source=DESKTOP-MMSPL40;Initial Catalog = QUANLYKHACHSAN; User ID = root; Password=root";

        // Trinh
        //public static string sqlConn = @"Data Source=LANTRINH_ASUS;Initial Catalog = QUANLYKHACHSAN; Persist Security Info=True;User ID = trinhasustuf; Password=1234";

        public static SqlConnection conn = null;
    }

}

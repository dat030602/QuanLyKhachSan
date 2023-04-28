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
        public static string sqlConn = @"Data Source=LANTRINH_ASUS;Initial Catalog = QUANLYKHACHSAN; Persist Security Info=True;User ID = trinhasustuf; Password=1234";
        public static SqlConnection conn = null;
    }

}

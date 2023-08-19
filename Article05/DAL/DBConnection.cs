using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article05.DAL
{
    public class DBConnection
    {
        public DBConnection()
        {

        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=VANHUNG\SQLEXPRESS; Initial Catalog = sale1; User Id = sa; Password=sa";
            return conn;
        }
    }
}

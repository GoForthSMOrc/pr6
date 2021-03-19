using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pr6
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "KnockOut";
            string username = "student";
            string password = "student";

            return DBMySQLUtils.GetConnection(host, port, database, username, password);
        }
    }
}

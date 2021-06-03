using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mysql_ir_CSharp
{
    class DBConnectcs
    {


        private MySqlConnection connection = new MySqlConnection ("server = 127.0.0.1; database = Parduotuve; Uid = root; Password = root; ");


        public MySqlConnection GetCon()
        {
            return connection;
        }
        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed) {
                connection.Open(); ;
            }
        }
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close(); ;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scibook
{
    internal class DBconnect
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-R7313PU\SQLEXPRESS;Initial Catalog=scibook;Integrated Security=True");

        public void openConnetion()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnetion()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnetion()
        {
            return sqlConnection;
        }

    }
}

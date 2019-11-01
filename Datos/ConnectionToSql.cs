using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Datos
{
    public abstract class ConnectionToSql
    {
        private readonly string ConnStr;

        public ConnectionToSql()
        {
             ConnStr = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;Database=bodega_campito;uid=willi;pwd=1234";

        }

        protected OdbcConnection getConnection()
        {
            OdbcConnection con = new OdbcConnection(ConnStr);
            return con;
        }
    }
}

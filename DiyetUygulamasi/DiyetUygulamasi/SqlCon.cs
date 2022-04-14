using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DiyetUygulamasi
{
    class SqlCon
    {
        public SqlConnection SqlConnect()
        { 
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DiyetDatabase;Integrated Security=True");//Bağlantı açma
            connection.Open();
            return connection;
        }
    }
}

using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Electro
{
    internal sealed class ConnectionManager
    {
        public static SqlConnection Getconnection()
        {
            //
            // TODO: Add constructor logic here
            //

            string connectionstring = ConfigurationManager.ConnectionStrings["Electro.Properties.Settings.Database1ConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            return connection;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace BankManagement
{
    public class DbConnection
    {

        public int executeQuary(String Quary)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand command = new SqlCommand(Quary, con);

            try
            {
                return command.ExecuteNonQuery();
            }catch(SqlException e)
            {

            }

            return 0;
        }
    }
}
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Muhasebe.ORM
{
    public static class Tools
    {
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                return connection ?? new SqlConnection(ConfigurationManager.ConnectionStrings["MuhasebeConnection_Local"].ConnectionString);
            }
            set { connection = value; }
        }

        public static bool ExecuteQuerry(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                    cmd.Connection.Open();
                int affected = cmd.ExecuteNonQuery();
                return affected > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }

    }
}

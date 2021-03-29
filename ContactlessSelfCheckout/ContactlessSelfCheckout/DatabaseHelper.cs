using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ContactlessSelfCheckout
{
    class DatabaseHelper
    {
        private static readonly SqlConnection connection = new SqlConnection();
        private static readonly SqlCommand command = new SqlCommand();
        private SqlDataAdapter DbAdapter = new SqlDataAdapter();

        private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Db_Products.mdf;Integrated Security=True";

        public void CreateConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void ReadDataThroughAdapter(string query, DataTable tableName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    CreateConnection();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                DbAdapter = new SqlDataAdapter(command);
                DbAdapter.Fill(tableName);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

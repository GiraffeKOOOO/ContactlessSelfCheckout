using System;
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

        /// <summary>
        /// This function is called to open a connection to the database
        /// </summary>
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

        /// <summary>
        /// This function is called to close the connection to the database
        /// </summary>
        public void CloseConnection()
        {
            connection.Close();
        }

        /// <summary>
        /// This function is called to read the data from a database and return the data using the Database Adapter
        /// </summary>
        /// <param name="query">String variable that is used to query the database</param>
        /// <param name="tableName">DataTable variable that is used to identify which table to be queried</param>
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

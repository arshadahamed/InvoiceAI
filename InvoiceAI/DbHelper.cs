using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace InvoiceAI
{
    public class DbHelper
    {
        private string connectionString;

        public DbHelper(string server, string port, string database, string user, string password)
        {
            connectionString = $"Server={server};Port={port};Database={database};Uid={user};Pwd={password};";
        }

        public int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }
    }
}

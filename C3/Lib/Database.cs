using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3.Lib
{
    class Database
    {
        // kunci untuk mengakses database
        private String _connectionString = @"Data Source=ANDROID\SQLEXPRESS;Initial Catalog=SMK_Database;Integrated Security=True";

        public void Create(string query)
        {

        }

        public DataTable Read(string query)
        {
            var dataTable = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(query, connection);
                
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        public void Update(string query)
        {

        }

        public void Delete(string query)
        {

        }

       
    }
}

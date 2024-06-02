using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit
{
    public class Database
    {
        private string _connectionString = @"Data Source=ANDROID\SQLEXPRESS;Initial Catalog=RumahSakit;Integrated Security=True";

        public DataTable Read(string query)
        {
            var dt = new DataTable();

            using (var cn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cn.Open();
                        da.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public void Execute(string query)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}

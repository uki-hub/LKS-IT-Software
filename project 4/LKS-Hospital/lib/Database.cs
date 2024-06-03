using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.lib
{
    public abstract class Database
    {
        //private string _connectionString = "Data Source=DESKTOP-O4D7PNN;Initial Catalog=DESKTOP_05;Integrated Security=True;";
        private string _connectionString = @"Data Source=android\sqlexpress;Initial Catalog=DESKTOP_99;Integrated Security=True";

        public DataTable ReadAsDataTable(string query, List<SqlParameter> parameters = null)
        {
            var dt = new DataTable();

            using (var cn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    if (parameters != null) parameters.ForEach(x => cmd.Parameters.Add(x));

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cn.Open();
                        da.Fill(dt);
                    }
                }
            }

            return dt;          
        }

        public List<T> Read<T>(string query, List<SqlParameter> parameters = null, Func<DataRow, T> selector = null)
        {
            var dt = ReadAsDataTable(query, parameters);

            var result = dt.AsEnumerable().Select(selector).ToList();

            return result;
        }

        public void Execute(string query, List<SqlParameter> parameters = null)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    if(parameters != null) parameters.ForEach(x => cmd.Parameters.Add(x));

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

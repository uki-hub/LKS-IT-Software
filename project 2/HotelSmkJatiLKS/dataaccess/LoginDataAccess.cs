using HotelSmkJatiLKS.db;
using HotelSmkJatiLKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSmkJatiLKS.dataaccess
{
    public class LoginDataAccess
    {
        Database db = new Database();

        public EmployeeModel Login(string Username, string Password)
        {
            var dt = db.Read($"select * from Employee where Username = '{Username}' and Password = '{Password}'");

            if (dt.Rows.Count == 0) throw new Exception("username dan password tidak ditemukan");

            var data = dt.Rows[0];

            return new EmployeeModel
            {
                ID = data["ID"].ToString(),
                Username = data["Username"].ToString(),
                Password = data["Password"].ToString(),
                Name = data["Name"].ToString(),
                Email = data["Email"].ToString(),
                Address = data["Address"].ToString(),
                DateOfBirth = DateTime.Parse(data["DateOfBirth"].ToString()),
                JobID = data["JobID"].ToString(),
                Photo = data["Photo"].ToString()
            };
        }
    }
}

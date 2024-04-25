using LKS.lib;
using LKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.data_access
{
    public class LoginDataAccess
    {
        Database db = new Database();

        public EmployeeModel Login(string email, string password)
        {
            var dt = db.Read($"select * from Msemployee where Email = '{email}' and password = '{password}'");

            if (dt.Rows.Count == 0) throw new Exception("Username dan Password tidak ditemukan");

            var data = dt.Rows[0];

            return new EmployeeModel
            {
                EmployeeID = data["EmployeeID"].ToString(),
                Name = data["Name"].ToString(),
                Email = data["Email"].ToString(),
                Handphone = data["Handphone"].ToString(),
                Position = data["Position"].ToString()
            }; 
        }
    }
}

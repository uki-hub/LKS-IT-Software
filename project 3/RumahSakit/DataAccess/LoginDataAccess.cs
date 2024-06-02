using RumahSakit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit.DataAccess
{
    public class LoginDataAccess
    {
        Database db = new Database();

        public UserModel Login(string username, string passwordSecret)
        {
            var dt = db.Read($"Select * from [User] where Username = '{username}' and password = '{passwordSecret}'");

            if (dt.Rows.Count < 1) return null; //user tidak ditemukan

            var data = dt.Rows[0];

            var user = new UserModel();
            user.ID = data["Id"].ToString();
            user.Username = data["Username"].ToString();
            user.Posisi = data["Posisi"].ToString();

            return user;
        }
    }
}

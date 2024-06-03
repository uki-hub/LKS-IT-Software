using LKS_Hospital.lib;
using LKS_Hospital.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class AuthDataAccess : Database
    {
        public UserModel Login(string username, string passwordSecret)
        {
            var users = Read<UserModel>($"select * from [user] where username = @Username and password = @Password and coalesce(deleted_at, '') = '' ", new List<SqlParameter>()
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", passwordSecret)
            }, UserModel.Map);

            if (users.Count < 1) return null;

            return users[0];
        }

        public void UserSigned(int userid)
        {
            Execute("update [user] set last_login_at = GETDATE() where id = @id", new List<SqlParameter> { 
                new SqlParameter("@id", userid)
            });
        }
    }
}

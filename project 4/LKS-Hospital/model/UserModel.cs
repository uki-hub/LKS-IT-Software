using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.model
{
    public class UserModel
    {
        public int id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public DateTime last_login_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public static UserModel Map(DataRow x)
        {
            return new UserModel
            {
                id = int.Parse(x["id"].ToString()),
                username = x["username"].ToString(),
                password = x["password"].ToString(),
                last_login_at = Common.objectToDateTime(x["last_login_at"]).Value,
                deleted_at = Common.objectToDateTime(x["deleted_at"])
            };
        }

    }

}

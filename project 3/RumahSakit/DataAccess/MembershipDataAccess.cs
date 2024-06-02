using RumahSakit.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit.DataAccess
{
    public class MembershipDataAccess
    {
        Database db = new Database();

        public List<MembershipModel> GetListMembership()
        {
            var list = new List<MembershipModel>();

            var dt = db.Read("select * from Membership");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                list.Add(new MembershipModel
                {
                    ID = int.Parse(data["ID"].ToString()),
                    Nama = data["Nama"].ToString(),
                    NoHP = data["NoHP"].ToString(),
                    UserID = data["UserID"].ToString(),
                    Photo = data["Photo"].ToString(),
                    Expired = DateTime.Parse(data["Expiered"].ToString()),
                });
            }

            return list;
        }
        
        public DataTable GetListMembershipDataTable()
        {
            return db.Read("select * from Membership");
        }
        
        public MembershipModel GetMembership(string UserID)
        {
            var dt = db.Read($"select * from Membership where UserID = '{UserID}'");

            if (dt.Rows.Count == 0) return null;

            var data = dt.Rows[0];

            var membership = new MembershipModel();
            membership.ID = int.Parse(data["ID"].ToString());
            membership.UserID = data["UserID"].ToString();
            membership.Nama = data["Nama"].ToString();
            membership.NoHP = data["NoHP"].ToString();
            membership.Photo = data["Photo"].ToString();
            membership.Expired = DateTime.Parse(data["Expired"].ToString());

            return membership;
        }

        public void UpdatePhoto(string userID, string photoLocation)
        {
            db.Execute($"update Membership set Photo = '{photoLocation}' where UserID = '{userID}'");
        }

    }
}

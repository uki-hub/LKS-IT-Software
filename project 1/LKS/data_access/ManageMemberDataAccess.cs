using LKS.lib;
using LKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.data_access
{
    public class ManageMemberDataAccess
    {
        Database db = new Database();

        public List<MemberModel> GetMembers()
        {
            var result = new List<MemberModel>();

            var dt = db.Read("select * from Msmember");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                result.Add(new MemberModel
                {
                    MemberID = data["MemberID"].ToString(),
                    Name = data["Name"].ToString(),
                    Email = data["Email"].ToString(),
                    Handphone = data["Handphone"].ToString(),
                    JoinDate = DateTime.Parse(data["JoinDate"].ToString()),
                });
            }

            return result;
        }

        public void InsertMember(MemberModel newMember)
        {
            db.Execute($@"
                insert into Msmember
	                (
	                MemberID,
	                Name,
	                Email,
	                Handphone,
	                JoinDate
	                )
	                values
	                (
	                '{newMember.MemberID}',
	                '{newMember.Name}',
	                '{newMember.Email}',
	                '{newMember.Handphone}',
	                GETDATE()
	                )
            ");
        } 
        
        public void UpdateMember(MemberModel updatedMember)
        {
            db.Execute($@"
                update Msmember set
	                Name = '{updatedMember.Name}',
	                Email = '{updatedMember.Email}',
	                Handphone = '{updatedMember.Handphone}'
                where
	                MemberID = '{updatedMember.MemberID}'
            ");
        }

        public void DeleteMember(string memberID)
        {
            db.Execute($"delete from Msmember where MemberID = '{memberID}'");
        }
    }
}

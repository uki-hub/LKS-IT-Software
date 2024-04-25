using LKS.lib;
using LKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.data_access
{
    

    public class ManageEmployeesDataAccess
    {
        Database db = new Database();

        public List<EmployeeModel> GetEmployees()
        {
            var result = new List<EmployeeModel>();

            var dt = db.Read("select * from Msemployee");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                result.Add(new EmployeeModel
                {
                    EmployeeID = data["EmployeeID"].ToString(),
                    Name = data["Name"].ToString(),
                    Email = data["Email"].ToString(),
                    Handphone = data["Handphone"].ToString(),
                    Position = data["Position"].ToString()
                });
            }

            return result;
        }

        public void InsertEmployee(EmployeeModel newEmplyoee)
        {
            db.Execute($@"
                insert into Msemployee
	                (
	                EmployeeID,
	                Email,
	                password,
	                name,
	                Handphone,
	                Position
	                )
	                values
	                (
	                '{newEmplyoee.EmployeeID}',
	                '{newEmplyoee.Email}',
	                '',
	                '{newEmplyoee.Name}',
	                '{newEmplyoee.Handphone}',
	                '{newEmplyoee.Position}'
	                )
            ");
        }

        public void UpdateEmployee(EmployeeModel updatedEmployee)
        {
            db.Execute($@"
                update Msemployee set
	                Email = '{updatedEmployee.Email}',
	                Name = '{updatedEmployee.Name}',
	                Handphone = '{updatedEmployee.Handphone}',
	                Position = '{updatedEmployee.Position}'
                where
	                EmployeeID = '{updatedEmployee.EmployeeID}'
            ");
        }
        
        public void DeleteEmployee(string employeeID)
        {
            db.Execute($"delete from Msemployee where EmployeeID = '{employeeID}'");
        }

        public void ChangePassword(string employeeID, string oldPassword, string newPassowrd)
        {
            var dt = db.Read($"select password from Msemployee where EmployeeID = '{employeeID}'");
            var currentPassword = dt.Rows[0]["password"].ToString();

            if (oldPassword != currentPassword) throw new Exception("Password lama tidak sesuai");

            db.Execute($"update Msemployee set password = '{newPassowrd}' where EmployeeID = '{employeeID}'");
        }
    }
}

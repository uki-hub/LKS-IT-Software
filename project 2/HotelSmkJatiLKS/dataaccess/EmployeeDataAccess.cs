using HotelSmkJatiLKS.db;
using HotelSmkJatiLKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSmkJatiLKS.dataaccess
{
    public class EmployeeDataAccess
    {
        Database db = new Database();

        public List<EmployeeModel> getEmployee()
        {
            var result = new List<EmployeeModel>();

            var dt = db.Read("select * from Employee");

            for (int i = 0; i <dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                result.Add(new EmployeeModel
                {
                    ID = data["ID"].ToString(),
                    Username = data["Username"].ToString(),
                    Password = data["Password"].ToString(),
                    Email = data["Email"].ToString(),
                    Address = data["Address"].ToString(),
                    DateOfBirth = DateTime.Parse(data["Name"].ToString()),
                    JobID = data["JobID"].ToString(),
                    Photo = data["Photo"].ToString()
                });
            }
            return result;
        }

        public void InsertEmployee(EmployeeModel insertEmployee)
        {
            db.Execute($@"
                insert into Employee
                (
                ID,
                Username,
                Password,
                Email,
                Address,
                DateOfBirth,
                JobID,
                Photo
                )
                values
                (
                '{insertEmployee.ID}',
                '{insertEmployee.Username}',
                '{insertEmployee.Password}',
                '{insertEmployee.Email}',
                '{insertEmployee.Address}',
                '{insertEmployee.DateOfBirth}',
                '{insertEmployee.JobID}',
                '{insertEmployee.Photo}'
                ");
        }

        public void UpdateEmployee(EmployeeModel updateEmployee)
        {
            db.Execute($@"
                update Employee set
                    Username = '{updateEmployee.Username}',
                    Password = '{updateEmployee.Password}',
                    Name = '{updateEmployee.Name}',
                    Email = '{updateEmployee.Email}',
                    Address = '{updateEmployee.Address}',
                    DateOfBirth = '{updateEmployee.DateOfBirth}',
                    JobID = '{updateEmployee.JobID}',
                    Photo= '{updateEmployee.Photo}'
            ");
        }

        public void DeleteEmployee(EmployeeModel ID)
        {
            db.Execute($"delete from Employee where ID = '{ID}'");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.models
{
    public class EmployeeModel
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Handphone { get; set; }
        public string Position { get; set; }

        
        public int GetPositionIndex()
        {
            switch (Position)
            {
                case "Admin":
                    return 0;

                case "Chef":
                    return 1;

                case "Cashier":
                    return 2;

                default:
                    return -1;

            }
        }
    }
}

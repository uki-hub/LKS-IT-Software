using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSmkJatiLKS.models
{
    public class ReservationModel
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public string BookingCode { get; set; }
    }
}

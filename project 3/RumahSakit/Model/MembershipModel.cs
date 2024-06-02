using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit.Model
{
    public class MembershipModel
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Nama { get; set; }
        public string NoHP { get; set; }
        public string Photo { get; set; }
        public DateTime Expired { get; set; }
    }
}

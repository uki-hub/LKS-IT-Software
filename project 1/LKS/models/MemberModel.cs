using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.models
{
    public class MemberModel
    {
        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Handphone { get; set; }
        public DateTime JoinDate{ get; set; }
    }
}

using LKS_Hospital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.store
{
    public class MainStore
    {
        public static UserModel User { get; set; }

        public static void Clear()
        {
            User = null;
        }
    }
}

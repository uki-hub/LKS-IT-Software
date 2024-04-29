using HotelSmkJatiLKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSmkJatiLKS.store
{
    public static class MainStore
    {
        public static EmployeeModel user;

        public static void Clear()
        {
            user = null;
        }

    }
}

using LKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.store
{
    public static class MainStore
    {
        public static EmployeeModel user;

        public static void Clear()
        {
            user = null;
        }

        ///
        /// OrderStatus
        /// Pending
        /// Cooking
        /// Deliver
        /// Done
        ///
    }
}

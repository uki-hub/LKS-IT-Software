using LKS.lib;
using LKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.data_access
{
    public class OrderDataAccess
    {
        Database db = new Database();

        public List<MenuModel> GetListMenu()
        {
            var manageMenuDataAccess = new ManageMenuDataAccess();

            return manageMenuDataAccess.GetListMenu();
        }

        public string GenerateOrderID()
        {
            var dt = db.Read("select top 1 OrderID from Headerorder order by OrderID desc");

            if(dt.Rows.Count <= 0) return "OD000001";

            var lastID = dt.Rows[0]["OrderID"].ToString().Trim();

            var digit = int.Parse(lastID.Substring(2, lastID.Length - 2)) + 1;

            return $"OD{digit.ToString("000000")}";
        }

        public void Order(string cashierId, string memberId, List<OrderModel> orderList)
        {
            var newOrderId = GenerateOrderID();

            db.Execute($@"
                insert into Headerorder 
                (
                OrderID,
                Employeeid,
                Memberid,
                Date,
                Payment,
                bank
                )
                values
                (
                '{newOrderId}',
                '{cashierId}',
                '{memberId}',
                GETDATE(),
                '',
                ''
                )
            ");

            foreach (var order in orderList)
            {
                db.Execute($@"
                    insert into Detailorder
                    (
                    Orderid,
                    Menuid,
                    Qty,
                    Price,
                    status
                    )
                    values
                    (
                    '{newOrderId}',
                    '{order.Menu.MenuID}',
                    {order.Qty},
                    {order.Qty * order.Menu.Price},
                    'Pending'
                    )
                ");
            }
        }
    }
}

using LKS.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.data_access
{
    public class ViewOrderDataAccess
    {
        Database db = new Database();

        public List<string> GetOrderIdList()
        {
            var paymentDataAccess = new PaymentDataAccess();

            return paymentDataAccess.GetOrderIdList();
        }

        public void UpdateStatus(string orderID, string menuID, string status)
        {
            db.Execute($"update Detailorder set status = '{status}' where Orderid = '{orderID}' and Menuid = '{menuID}'");
        }

        public DataTable GetOrderStatus(string orderID)
        {
            return db.Read($@"
                select
	                Msmenu.Name as Menu,
	                Msmenu.MenuID as MenuID,
	                Detailorder.Qty as Qty,
	                Detailorder.status as Status
	                from Detailorder
	                left join Msmenu on Msmenu.MenuID = Detailorder.Menuid
	                where Orderid = '{orderID}'
            ");
        }
    }
}

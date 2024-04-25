using LKS.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.data_access
{

    public class PaymentDataAccess
    {

        Database db = new Database();

        public List<string> GetOrderIdList()
        {
            var dt = db.Read("select OrderID from Headerorder where Payment = '' and Bank = ''");

            var result = new List<string>();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(dt.Rows[i]["Orderid"].ToString());
            }

            return result;
        }

        public DataTable GetOrderDetail(string orderID)
        {
            return db.Read($@"
                select 
	                Msmenu.Name as Menu,
	                Detailorder.Qty as Qty,
	                Msmenu.Price as Price,
	                (Msmenu.Price * Detailorder.Qty) as Total
	                from Headerorder 
	                join Detailorder on Detailorder.Orderid = Headerorder.OrderID
	                join Msmenu on Msmenu.MenuID = Detailorder.Menuid
	                where 
			                Headerorder.OrderID = '{orderID}'
            ");
        }

        public void Pay(string orderID, string payment, string bank)
        {
            db.Execute($"update Headerorder set Payment = '{payment}', bank = '{bank}' where OrderID = '{orderID}' ");
        }
    }
}

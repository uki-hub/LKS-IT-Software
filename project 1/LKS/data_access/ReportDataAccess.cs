using LKS.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.data_access
{
    public class ReportDataAccess
    {
        Database db = new Database();

        public List<DateTime> GetDateList()
        {
            var result = new List<DateTime>();

            var dt = db.Read("select Headerorder.Date as Date from Headerorder");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var month = DateTime.Parse(dt.Rows[i]["Date"].ToString());
                
                result.Add(month);
            }

            return result;
        }

        public DataTable GetReport(DateTime fromMonth, DateTime toMonth)
        {
            return db.Read($@"
                select
	                Month(Headerorder.Date) as Month,
	                sum(Detailorder.Price * Detailorder.Qty) as Income	
	                from Headerorder
	                join Detailorder on Detailorder.Orderid = Headerorder.OrderID
	                where
                        {fromMonth.Month} >= Month(Headerorder.Date) and Month(Headerorder.Date) <= {toMonth.Month}
	                group by Headerorder.Date
            ");
        }
    }
}

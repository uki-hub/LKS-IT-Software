using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.model
{
    public class PaymentDetailModel
    {
        public int id { get; set; }

        public int payment_id { get; set; }

        public string item { get; set; }

        public decimal nominal { get; set; }

        public string notes { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? last_updated_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public static PaymentDetailModel Map(DataRow x)
        {
            return new PaymentDetailModel
            {
                id = int.Parse(x["id"].ToString()),
                payment_id = int.Parse(x["payment_id"].ToString()),
                item = x["item"].ToString(),
                nominal = decimal.Parse(x["nominal"].ToString()),
                notes = x["notes"].ToString(),
                created_at = Common.objectToDateTime(x["created_at"]).Value,
                deleted_at = Common.objectToDateTime(x["deleted_at"]),
                last_updated_at = Common.objectToDateTime(x["last_updated_at"])
            };
        }

    }
}

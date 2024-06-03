using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.model
{
    public class PaymentModel
    {
        public int id { get; set; }

        public int meeting_id { get; set; }

        public string card_holder_name { get; set; }

        public string primary_account_number { get; set; }

        public DateTime expiration_date { get; set; }

        public int service_code { get; set; }

        public decimal total_payment { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? last_updated_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public static PaymentModel Map(DataRow x)
        {
            return new PaymentModel
            {
                id = int.Parse(x["id"].ToString()),
                meeting_id = int.Parse(x["meeting_id"].ToString()),
                card_holder_name = x["card_holder_name"].ToString(),
                primary_account_number = x["primary_account_number"].ToString(),
                expiration_date = Common.objectToDateTime(x["expiration_date"]).Value,
                service_code = int.Parse(x["service_code"].ToString()),
                total_payment = decimal.Parse(x["total_payment"].ToString()),                
                created_at = Common.objectToDateTime(x["created_at"]).Value,
                deleted_at = Common.objectToDateTime(x["deleted_at"]),
                last_updated_at = Common.objectToDateTime(x["last_updated_at"])
            };
        }

    }
}

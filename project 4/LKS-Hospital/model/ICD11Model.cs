using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.model
{
    public class ICD11Model
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? last_updated_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public static ICD11Model Map(DataRow x)
        {
            return new ICD11Model
            {
                id = int.Parse(x["id"].ToString()),
                name = x["name"].ToString(),
                description = x["description"].ToString(),
                created_at = Common.objectToDateTime(x["created_at"]).Value,
                deleted_at = Common.objectToDateTime(x["deleted_at"]),
                last_updated_at = Common.objectToDateTime(x["last_updated_at"])
            };
        }

    }
}

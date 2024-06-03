using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.model
{
    public class ICD11ExclusionModel
    {
        public int id { get; set; }

        public int icd11_id { get; set; }

        public string exclusion { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? last_updated_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public static ICD11ExclusionModel Map(DataRow x)
        {
            return new ICD11ExclusionModel
            {
                id = int.Parse(x["id"].ToString()),
                icd11_id = int.Parse(x["icd-11_id"].ToString()),
                exclusion = x["exclusion"].ToString(),
                created_at = Common.objectToDateTime(x["created_at"]).Value,
                deleted_at = Common.objectToDateTime(x["deleted_at"]),
                last_updated_at = Common.objectToDateTime(x["last_updated_at"])
            };
        }

    }
}

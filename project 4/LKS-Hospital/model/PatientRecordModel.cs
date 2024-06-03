using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.model
{
    public class PatientRecordModel
    {
        public int id { get; set; }

        public int patient_id { get; set; }

        public int meeting_id { get; set; }

        public string notes { get; set; }

        public DateTime date { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? last_updated_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public static PatientRecordModel Map(DataRow x)
        {
            return new PatientRecordModel
            {
                id = int.Parse(x["id"].ToString()),
                patient_id = int.Parse(x["patient_id"].ToString()),
                meeting_id = int.Parse(x["meeting_id"].ToString()),
                notes = x["notes"].ToString(),
                date = Common.objectToDateTime(x["date"]).Value,
                created_at = Common.objectToDateTime(x["created_at"]).Value,
                deleted_at = Common.objectToDateTime(x["deleted_at"]),
                last_updated_at = Common.objectToDateTime(x["last_updated_at"])
            };
        }

    }
}

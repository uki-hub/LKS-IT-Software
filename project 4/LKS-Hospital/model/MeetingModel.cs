using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.model
{
    public class MeetingModel
    {
        public int id { get; set; }

        public int patient_id { get; set; }

        public int doctor_id { get; set; }

        public string room { get; set; }

        public DateTime date { get; set; }

        public int queue_number { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? last_updated_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public static MeetingModel Map(DataRow x)
        {
            return new MeetingModel
            {
                id = int.Parse(x["id"].ToString()),
                patient_id = int.Parse(x["patient_id"].ToString()),
                doctor_id = int.Parse(x["doctor_id"].ToString()),
                room = x["room"].ToString(),
                date = Common.objectToDateTime(x["date"]).Value,
                queue_number = int.Parse(x["queue_number"].ToString()),
                created_at = Common.objectToDateTime(x["created_at"]).Value,
                deleted_at = Common.objectToDateTime(x["deleted_at"]),
                last_updated_at = Common.objectToDateTime(x["last_updated_at"])
            };
        }

    }
}

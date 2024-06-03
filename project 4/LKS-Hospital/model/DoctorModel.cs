using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.model
{
    public class DoctorModel
    {
        public int id { get; set; }

        public int doctor_category_id { get; set; }

        public string name { get; set; }

        public string phone_number { get; set; }

        public string email { get; set; }

        public string city_of_birth { get; set; }

        public DateTime date_of_birth { get; set; }

        public string address { get; set; }

        public string gender { get; set; }

        public string assigned_room { get; set; }

        public DateTime created_at { get; set; }

        public DateTime? last_updated_at { get; set; }

        public DateTime? deleted_at { get; set; }

        public static DoctorModel Map(DataRow x)
        {
            return new DoctorModel
            {
                id = int.Parse(x["id"].ToString()),
                doctor_category_id = int.Parse(x["doctor_category_id"].ToString()),
                name = x["name"].ToString(),
                phone_number = x["phone_number"].ToString(),
                email = x["email"].ToString(),
                city_of_birth = x["city_of_birth"].ToString(),
                date_of_birth = Common.objectToDateTime(x["date_of_birth"]).Value,
                address = x["address"].ToString(),
                gender = x["gender"].ToString(),
                assigned_room = x["assigned_room"].ToString(),                
                created_at = Common.objectToDateTime(x["created_at"]).Value,
                deleted_at = Common.objectToDateTime(x["deleted_at"]),
                last_updated_at = Common.objectToDateTime(x["last_updated_at"])
            };
        }

    }
}

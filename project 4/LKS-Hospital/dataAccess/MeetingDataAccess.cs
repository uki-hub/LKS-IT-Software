using LKS_Hospital.lib;
using LKS_Hospital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class MeetingDataAccess : Database
    {
        public PatientModel SearchPatientByName(string name)
        {
            return Read<PatientModel>(
                $"select top 1 * from patient where name = '{name}' and coalesce(deleted_at, '') = '' ",
                selector: PatientModel.Map
            ).FirstOrDefault();
        }

        public int GenerateQueueNumber(int doctorId, DateTime date)
        {
            return Read<int>(
                $"select coalesce(max(queue_number), 0) as queue from meeting where doctor_id = {doctorId} and date = '{date.ToString("yyyy-MM-dd")}'",
                selector: (s) => int.Parse(s["queue"].ToString()) + 1
            ).FirstOrDefault();
        }

        public bool IsScheduleValid(int doctorId, DateTime date)
        {
            return Read<int>(
                $"select count(id) as count from meeting where doctor_id = {doctorId} and date = '{date.ToString("yyyy-MM-dd HH:mm:ss")}'",
                selector: (s) => int.Parse(s["count"].ToString())
            ).FirstOrDefault() < 1;
        }

        public void SaveMeeting(int patientId, int doctorId, string room, int queue)
        {
            Execute($@"
                insert into meeting 
                (
                patient_id,
                doctor_id,
                room,
                date,
                queue_number,
                created_at,
                last_updated_at
                )
                values
                (
                {patientId},
                {doctorId},
                '{room}',
                GETDATE(),
                {queue},
                GETDATE(),
                GETDATE()
                )
            ");
        }
    }
}

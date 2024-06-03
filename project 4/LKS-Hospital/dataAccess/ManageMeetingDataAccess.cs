using LKS_Hospital.lib;
using LKS_Hospital.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class ManageMeetingDataAccess : Database
    {
        //public List<MeetingModel> GetMeetings()
        //{
        //    return Read(
        //        "select * from meeting where coalesce(deleted_at, '') = '' ",
        //        selector: MeetingModel.Map);
        //}

        public List<PatientRecordModel> GetPatientRecords(int patientId)
        {
            return Read(
                $"select * from patient_record where id = {patientId} and coalesce(deleted_at, '') = '' ",
                selector: PatientRecordModel.Map);
        }

        public DataTable GetMeetings()
        {
            return ReadAsDataTable(@"
                        select
	                        meeting.id as Id,
	                        patient.id as patientId,
	                        meeting.date as Date,
	                        patient.name as Name,
	                        doctor_category.category as DoctorCategory,
	                        doctor.name as DoctorName,
	                        meeting.queue_number as Queue
	                        from meeting
	                        join patient on patient.id = meeting.patient_id
	                        join doctor on doctor.id = meeting.doctor_id
	                        join doctor_category on doctor_category.id = doctor.doctor_category_id"
            );
        }
    }
}

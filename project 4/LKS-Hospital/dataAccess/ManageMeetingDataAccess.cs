using LKS_Hospital.lib;
using LKS_Hospital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class ManageMeetingDataAccess : Database
    { 
        public List<MeetingModel> GetMeetings()
        {
            return Read(
                "select * from meeting where coalesce(deleted_at, '') = '' ",
                selector: MeetingModel.Map);
        }

        public List<PatientRecordModel> GetPatientRecords()
        {
            return Read(
                "select * from patient_record where coalesce(deleted_at, '') = '' ",
                selector: PatientRecordModel.Map);
        }
    }
}

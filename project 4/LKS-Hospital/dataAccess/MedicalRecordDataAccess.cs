using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class MedicalRecordDataAccess : Database
    {
        public DataTable GetRecords(int patientId)
        {
			return ReadAsDataTable($@"
				select 
					patient_record.date as Date,
					doctor_category.category as 'Doctor Category',
					doctor.name as 'Doctor Name',
					patient_record.notes as Record
					from 
					patient_record
					join meeting on meeting.id = patient_record.meeting_id
					join doctor on doctor.id = meeting.doctor_id
					join doctor_category on doctor_category.id = doctor.doctor_category_id
					where 
						patient_record.patient_id = {patientId}
			");
        }
    }
}

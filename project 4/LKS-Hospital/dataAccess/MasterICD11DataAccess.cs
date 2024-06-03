using LKS_Hospital.lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class MasterICD11DataAccess : Database
    {
		public DataTable GetSpecialist(int icd11ID)
		{
			return ReadAsDataTable($@"
				select 
					doctor.id as doctor_id,
					doctor.name as doctor_name,
					doctor_category.category as category
	
					from [icd-11_doctor_recommendation] 
					join doctor_category on doctor_category.id = [icd-11_doctor_recommendation].doctor_category_id
					join doctor on doctor.doctor_category_id = doctor_category.id
					where 
						[icd-11_id] = {icd11ID}
			");
        }
    }
}

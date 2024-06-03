using LKS_Hospital.lib;
using LKS_Hospital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class DoctorDataAccess : Database
    {
        public List<DoctorModel> GetDoctors()
        {
            return Read(
                "select * from doctor where coalesce(deleted_at, '') = ''",
                selector: DoctorModel.Map);
        }

        public List<DoctorCategoryModel> GetDoctorCategories()
        {
            return Read(
                "select * from doctor_category where coalesce(deleted_at, '') = ''",
                selector: DoctorCategoryModel.Map);
        }
    }
}

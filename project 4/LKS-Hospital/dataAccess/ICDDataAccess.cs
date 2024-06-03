using LKS_Hospital.lib;
using LKS_Hospital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class ICDDataAccess : Database
    {
        public List<ICD11Model> GetICD11s() => Read<ICD11Model>(
            "select * from [icd-11] where coalesce(deleted_at, '') = ''", 
            selector: ICD11Model.Map);

        public List<ICD11ExclusionModel> GetICD11Exclusions() => Read<ICD11ExclusionModel>(
            "select * from [icd-11_exclusion] where coalesce(deleted_at, '') = ''",
            selector: ICD11ExclusionModel.Map);

        public List<ICD11DoctorRecommendationModel> GetICD11DoctorRecommendations() => Read<ICD11DoctorRecommendationModel>(
            "select * from [icd-11_doctor_recommendation] where coalesce(deleted_at, '') = ''",
            selector: ICD11DoctorRecommendationModel.Map);
    }
}

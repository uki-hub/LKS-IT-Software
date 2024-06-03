using LKS_Hospital.lib;
using LKS_Hospital.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_Hospital.dataAccess
{
    public class PatientDataAccess : Database
    {
        public List<PatientModel> GetPatients()
        {
            return Read<PatientModel>(
                "select * from patient where coalesce(deleted_at, '') = '' ",
                selector: PatientModel.Map
                );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosisOfRetinal
{
    class PatientDAO : IdbWorkable<Patient>
    {

        public Patient read(long patient_id)
        {
            return (from patient in DbContextInfo.getContext().Patients
                    where patient.ID == patient_id
                    select patient).Single();
        }

        public long insert(Patient patient)
        {
            try
            {
                Patient patientNew = DbContextInfo.getContext().Patients.Add(patient);
                DbContextInfo.getContext().SaveChanges();
                return patientNew.ID;
            }
            catch
            {
                return -1;
            }
        }

        public bool delete(Patient patient)
        {
            try
            {
                DbContextInfo.getContext().Patients.Remove(patient);
                DbContextInfo.getContext().SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(int patient_id)
        {
            try
            {
                Patient patient = this.read(patient_id);
                DbContextInfo.getContext().Patients.Remove(patient);
                DbContextInfo.getContext().SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(Patient patient)
        {
                DbContextInfo.getContext().Entry(patient).State = System.Data.Entity.EntityState.Modified;
                DbContextInfo.getContext().SaveChanges();
                return true;
        }

        public List<Patient> get_all_patients()
        {
            return (from patient in DbContextInfo.getContext().Patients
                    orderby patient.Surname ascending
                    select patient).ToList();
        }
    }
}

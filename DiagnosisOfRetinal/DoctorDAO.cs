/*
    Copyright 2016,2017 Sergey Potemkin
    This file is part of the DOR.
   (Diagnosis of Retina)

   DOR is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License v3.0.
    
    You should have received a copy of the GNU General Public License v3.0
    along with DOR.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosisOfRetinal
{
    class DoctorDAO : IdbWorkable<Doctor>
    {

        public Doctor read(long doctor_id) //получение модели-записи из таблицы Doctor
        {
            return (from doctor in DbContextInfo.getContext().Doctors
                    where doctor.ID == doctor_id
                    select doctor).Single();
        }

        public long insert(Doctor doctor) //создание записи в таблице Doctor
        {
            try
            {
                Doctor doctorNew = DbContextInfo.getContext().Doctors.Add(doctor);
                DbContextInfo.getContext().SaveChanges();
                return doctorNew.ID;
            }
            catch
            {
                return -1;
            }
        }

        public bool delete(Doctor doctor) //удаление записи из таблицы Doctor
        {
            try
            {
                DbContextInfo.getContext().Doctors.Remove(doctor);
                DbContextInfo.getContext().SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(int dector_id)
        {
            try
            {
                Doctor doctor = this.read(dector_id);
                DbContextInfo.getContext().Doctors.Remove(doctor);
                DbContextInfo.getContext().SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(Doctor doctor)
        {
            try
            {
                DbContextInfo.getContext().Entry(doctor).State = System.Data.Entity.EntityState.Modified;
                DbContextInfo.getContext().SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Doctor> get_all_doctors()
        {
            return (from doctor in DbContextInfo.getContext().Doctors
                    orderby doctor.Surname ascending
                    select doctor).ToList();
        }
    }
}

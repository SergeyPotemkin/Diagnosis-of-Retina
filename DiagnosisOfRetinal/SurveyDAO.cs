using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosisOfRetinal
{
    class SurveyDAO : IdbWorkable<Survey>
    {
        public Survey read(long survey_id)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    where survey.ID == survey_id
                    select survey).Single();
        }

        public long insert(Survey survey)
        {
            try
            {
                Survey surveyNew = DbContextInfo.getContext().Surveys.Add(survey);
                DbContextInfo.getContext().SaveChanges();
                return surveyNew.ID;
            }
            catch
            {
                return -1;
            }
        }

        public bool delete(Survey survey)
        {
            try
            {
                DbContextInfo.getContext().Surveys.Remove(survey);
                DbContextInfo.getContext().SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(int survey_id)
        {
            try
            {
                Survey survey = this.read(survey_id);
                DbContextInfo.getContext().Surveys.Remove(survey);
                DbContextInfo.getContext().SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool update(Survey newSurvey)
        {
            Survey oldSurvey = (from s in DbContextInfo.getContext().Surveys
                                where s.ID == newSurvey.ID
                                select s).First();
            oldSurvey.Area_of_folds = newSurvey.Area_of_folds;
            oldSurvey.Correlations = newSurvey.Correlations;
            oldSurvey.Critical_points = newSurvey.Critical_points;
            oldSurvey.Foldings = newSurvey.Foldings;
            oldSurvey.Foveas = newSurvey.Foveas;
            oldSurvey.Global_angles = newSurvey.Global_angles;
            oldSurvey.Global_correlation = newSurvey.Global_correlation;
            oldSurvey.Global_critical_points = newSurvey.Global_critical_points;
            oldSurvey.Global_fovea_coef_normality = newSurvey.Global_fovea_coef_normality;
            oldSurvey.Global_fovea_coef_symmetry = newSurvey.Global_fovea_coef_symmetry;
            oldSurvey.Global_fovea_depth_bot = newSurvey.Global_fovea_depth_bot;
            oldSurvey.Global_fovea_depth_top = newSurvey.Global_fovea_depth_top;
            oldSurvey.Global_fovea_length = newSurvey.Global_fovea_length;
            oldSurvey.Global_max_amplitude = newSurvey.Global_max_amplitude;
            oldSurvey.Global_mean_amplitude = newSurvey.Global_mean_amplitude;
            oldSurvey.Global_min_amplitude = newSurvey.Global_min_amplitude;
            oldSurvey.Global_n = newSurvey.Global_n;
            oldSurvey.Location = newSurvey.Location;
            oldSurvey.Snapshots = newSurvey.Snapshots;
            //DbContextInfo.getContext().Entry(survey).State = System.Data.Entity.EntityState.Modified;
            DbContextInfo.getContext().SaveChanges();
            return true;
        }

        public List<Survey> get_all_survey_by_patientID(long patient_id)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    where survey.ID_patient == patient_id
                    select survey).ToList();
        }
        public List<Survey> get_all_survey_by_doctorID(int doctor_id)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    where survey.ID_doctor == doctor_id
                    select survey).ToList();
        }

        //получить обследования по ИД пациента и дате
        public List<Survey> get_surveys_by_patientID_and_Date(int patient_id, DateTime date)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    where survey.ID_patient == patient_id && survey.Date_survey == date
                    select survey).ToList();
        }

        //получить обследования по ИД врача и дате
        public List<Survey> get_surveys_by_doctorID_and_Date(int doctor_id, DateTime date)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    where survey.ID_doctor == doctor_id && survey.Date_survey == date
                    select survey).ToList();
        }

        //получить обследования по ИД пациента и диапазону дат (ПРОВЕРИТЬ ПО ПЕРЕВОДЧИКУ)
        public List<Survey> get_surveys_by_patientID_and_diapason_Date(int patient_id, DateTime start_date, DateTime end_date)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    where survey.ID_patient == patient_id && survey.Date_survey <= start_date && survey.Date_survey >= end_date
                    select survey).ToList();
        }

        //получить обследования по ИД врача и диапазону дат (ПРОВЕРИТЬ ПО ПЕРЕВОДЧИКУ)
        public List<Survey> get_surveys_by_doctorID_and_diapason_Date(int doctor_id, DateTime start_date, DateTime end_date)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    where survey.ID_doctor == doctor_id && survey.Date_survey <= start_date && survey.Date_survey >= end_date
                    select survey).ToList();
        }

        public List<object> get_general_info_about_survey_by_patientID(int patient_id)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    join patient in DbContextInfo.getContext().Patients
                    on survey.ID_patient equals patient.ID
                    join doctor in DbContextInfo.getContext().Doctors
                    on survey.ID_doctor equals doctor.ID
                    where survey.ID_patient == patient_id
                    select new
                    {
                        id = survey.ID,
                        fio_patient = patient.Surname + " " + patient.Name + " " + patient.Middlename,
                        fio_doctor = doctor.Surname + " " + doctor.Name + " " + doctor.Middlename,
                        data = survey.Date_survey,
                        location = survey.Location
                    }).ToList<object>();
        }

        public List<object> get_general_info_about_survey_by_doctorID(int doctor_id)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    join patient in DbContextInfo.getContext().Patients
                    on survey.ID_patient equals patient.ID
                    join doctor in DbContextInfo.getContext().Doctors
                    on survey.ID_doctor equals doctor.ID
                    where survey.ID_doctor == doctor_id
                    select new
                    {
                        id = survey.ID,
                        fio_patient = patient.Surname + " " + patient.Name + " " + patient.Middlename,
                        fio_doctor = doctor.Surname + " " + doctor.Name + " " + doctor.Middlename,
                        data = survey.Date_survey,
                        location = survey.Location
                    }).ToList<object>();
        }
        
        public List<Folding> get_local_foldings_by_surveyID(int survey_id)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    join folding in DbContextInfo.getContext().Foldings
                    on survey.ID equals folding.ID_survey
                    where survey.ID == survey_id
                    select folding).ToList();
        }

        public List<Correlation> get_local_correlations_by_surveyID(int survey_id)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    join correlation in DbContextInfo.getContext().Correlations
                    on survey.ID equals correlation.ID_survey
                    where survey.ID == survey_id
                    select correlation).ToList();
        }

        public List<Critical_points> get_local_critical_points_by_surveyID(int survey_id)
        {
            return (from survey in DbContextInfo.getContext().Surveys
                    join critical_points in DbContextInfo.getContext().Critical_points
                    on survey.ID equals critical_points.ID_survey
                    where survey.ID == survey_id
                    select critical_points).ToList();
        }
    }
}

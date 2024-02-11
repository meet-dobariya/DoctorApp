using DoctorApp.Interface;
using DoctorApp.Models;

namespace DoctorApp.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ISqlRepository<Patient> _patient;
        public PatientRepository(ISqlRepository<Patient> patient) 
        {
            _patient = patient;
        }

        public async Task<Patient>AddPatient(Patient patient)
        {
            patient.CreatedDate = DateTime.Now;
            _patient.Insert(patient);
            return patient;
        }

        public async Task<IEnumerable<Patient>> GetAllPatient()
        {
            var data = await _patient.Get();
            var newdata = data.OrderByDescending(p => p.CreatedDate);
            return newdata.ToList();
        }
    }
}

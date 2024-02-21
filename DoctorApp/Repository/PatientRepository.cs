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
            DateTime today = DateTime.Today;
            var returndata = data.Where(p => p.CreatedDate.Date == today).OrderByDescending(p => p.CreatedDate);
            return returndata.ToList();
        }

        public async Task<int> TotalAmount()
        {
            var data = await _patient.Get();
            DateTime today = DateTime.Today;
            var returndata=data.Where(p => p.CreatedDate.Date == today);
            int totalAmount = 0;
            foreach (var item in returndata)
            {
                totalAmount += item.Amount;
            }
            return totalAmount;
        }
    }
}

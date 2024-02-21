using DoctorApp.Models;

namespace DoctorApp.Interface
{
    public interface IPatientRepository
    {
        Task<Patient> AddPatient(Patient patient);
        Task<IEnumerable<Patient>> GetAllPatient();
        Task<int> TotalAmount();
    }
}

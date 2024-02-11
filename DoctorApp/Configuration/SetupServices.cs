
using DoctorApp.Interface;
using DoctorApp.Models;
using DoctorApp.Repository;

namespace DoctorApp.Configuration
{
    public static class SetupServices
    {
        public static void SetupDIServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(ISqlRepository<>), typeof(SqlDBRepository<>));
            services.AddScoped<IPatientRepository, PatientRepository>();
        }
    }
}
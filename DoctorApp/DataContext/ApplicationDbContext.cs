using DoctorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorApp.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Patient> Patient { get; set; }
    }
}

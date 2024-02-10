using System.ComponentModel.DataAnnotations;

namespace DoctorApp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public int PatientNo { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}

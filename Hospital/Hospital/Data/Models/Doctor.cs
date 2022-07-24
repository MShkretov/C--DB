using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }

        public string Speciality { get; set; }
    }
}

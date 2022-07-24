using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string LastName { get; set; }

        [MaxLength(250)]
        [Unicode(true)]
        public string Address { get; set; }

        [MaxLength(80)]
        [Unicode(false)]
        public string Email { get; set; }

        public bool HasInsurance { get; set; }
    }
}

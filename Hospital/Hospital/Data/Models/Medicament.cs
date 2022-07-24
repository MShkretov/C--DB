using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Data.Models
{
    public class Medicament
    {
        [Key]

        public int MedicamentId { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }
    }
}

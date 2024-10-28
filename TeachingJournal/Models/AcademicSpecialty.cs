using System.ComponentModel.DataAnnotations;

namespace TeachingJournal.Models
{
    public class AcademicSpecialty
    {
        [Key]
        [StringLength(50)]
        public string SpecialtyCode { get; set; }

        [StringLength(50)]
        public string SpecialtyName { get; set; }
    }
}

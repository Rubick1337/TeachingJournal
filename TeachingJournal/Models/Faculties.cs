using System.ComponentModel.DataAnnotations;

namespace TeachingJournal.Models
{
    public class Faculty
    {
        [Key]
        public int FId { get; set; }

        [StringLength(50)]
        public string FName { get; set; }

        public int DeanPersonId { get; set; }

        [StringLength(50)]
        public string FFullName { get; set; }
    }
}

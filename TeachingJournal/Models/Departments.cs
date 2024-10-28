using System.ComponentModel.DataAnnotations;

namespace TeachingJournal.Models
{
    public class Departments
    {
        [Key]
        public int DpId { get; set; }

        [StringLength(50)]
        public string DpName { get; set; }

        public int ChairpersonOfTheDepartmentPersonId { get; set; }

        public int DpFId { get; set; }

        [StringLength(50)]
        public string DpFullName { get; set; }
    }
}

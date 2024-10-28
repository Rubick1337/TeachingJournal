using System.ComponentModel.DataAnnotations;

namespace TeachingJournal.Models
{
    public class Persons
    {
        [Key]
        public int PersonId { get; set; }

        [StringLength(50)]
        public string PersonSurname { get; set; }

        [StringLength(50)]
        public string PersonName { get; set; }

        [StringLength(50)]
        public string PersonMiddleName { get; set; }

        [StringLength(50)]
        public string PersonPhoneNumber { get; set; }

        [StringLength(14)]
        public string PersonalIdentificationNumber { get; set; }

        [StringLength(100)]
        public string PersonAddress { get; set; }
    }
}

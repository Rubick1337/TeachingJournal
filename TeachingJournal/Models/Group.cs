using System.ComponentModel.DataAnnotations;

namespace TeachingJournal.Models
{
    public class Group
    {
        [Key]
        public int GrId { get; set; }

        [StringLength(50)]
        public string GrName { get; set; }

        public int FId { get; set; }

        public int ClassRepresentativePersonId { get; set; }

        public DateTime GraduationYear { get; set; }

        public int GrTeacherCuratorId { get; set; }

        public int GrDpId { get; set; }

        [StringLength(50)]
        public string GrSpecialtyCode { get; set; }

        public int YearOfBeginningOfStudy { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingJournal.Models
{
    public class Curriculum
    {
        [Key, Column(Order = 0)]
        public int CurriculumId { get; set; }

        [Key, Column(Order = 1)]
        public int CurriculumSjId { get; set; }

        [Key, Column(Order = 2)]
        public int CurriculumTopicId { get; set; }

        [Key, Column(Order = 3)]
        public byte CurriculumNumberSemester { get; set; }

        public int CurriculumCountHours { get; set; }
        [Key, Column(Order = 4)]
        public int CurriculumNumberTypeOfAssessment { get; set; }

        [StringLength(50)]
        public string CurriculumSpecialtyCode { get; set; }

        public int YearOfSpecialtyTraining { get; set; }
    }
}

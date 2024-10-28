using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingJournal.Models
{

    public class Grades
    {
        [Key, Column(Order = 0)]
        public int GradeId { get; set; }

        public int GradeValue { get; set; }

        public int GradeStId { get; set; }

        public int GradeLessonId { get; set; }

        public int GradeGrId { get; set; }
        [Key, Column(Order = 1)]
        public int GradeTopicId { get; set; }

        public int PtId { get; set; }

        public DateTime PtDatePass { get; set; }
    }
}

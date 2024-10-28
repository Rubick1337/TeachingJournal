using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingJournal.Models
{

    public class AcademicPerformance
    {
        [Key, Column(Order = 0)]
        public int ApId { get; set; }

        [Key, Column(Order = 1)]
        public int ApStId { get; set; }

        [Key, Column(Order = 2)]
        public byte ApSemesterNumber { get; set; }

        [Key, Column(Order = 3)]
        public byte ApSjId { get; set; }

        public byte Module1Score { get; set; }

        public byte Module2Score { get; set; }

        public byte ExamScore { get; set; }

        public int TotalGradeId { get; set; }

        public int SjId { get; set; }
    }
}

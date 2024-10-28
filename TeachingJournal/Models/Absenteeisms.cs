using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingJournal.Models
{
    public class Absenteeism
    {
        [Key, Column(Order = 0)]
        public int AbId { get; set; }

        public int AbGrId { get; set; }

        public int AbLessonId { get; set; }

        public int AbStudentId { get; set; }

        public byte AbCountExcusedHour { get; set; } = 0;

        public byte AbCountUnexcusedHour { get; set; } = 0;
    }
}

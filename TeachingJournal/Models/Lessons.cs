using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingJournal.Models
{

    public class Lessons
    {
        [Key, Column(Order = 0)]
        public int LessonId { get; set; }

        [Key, Column(Order = 1)]
        public int LessonWithGrId { get; set; }

        public DateTime LessonDatetime { get; set; }

        public int LessonOnTheSjId { get; set; }

        public int LessonTeacherId { get; set; }

        public int LessonTopicId { get; set; }

        public byte NumberSemester { get; set; }
    }
}
